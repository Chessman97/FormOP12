using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Diagnostics;


using Application = Microsoft.Office.Interop.Excel.Application;

namespace InterfaceTable
{
    enum names
    {
        Борщ, Оливье, Манты, Чай
    }
    public partial class MainForm : Form
    {
        private List<Record> records = new List<Record>();
        private int INDEX = 0;
        private int fillFlag = 0;
        private List<Employee> employees;
        private String[] refer = new string[5];
        private String[] rev = new string[3];
        private Documents obj = Documents.getInstance1();
        private Documents obj1 = Documents.getInstance2();
        

        //export to Excel
        private Application application;
        private Workbook workBook;
        private Worksheet worksheet;

        private Record findRecord(int number)
        {
            for (int i = 0; i < records.Count; i++)
                if (records[i].Number == number)
                    return records[i];
            return null;
        }

        private int nextIndex()
        {
            return ++INDEX;
        }

        public MainForm()
        {
            InitializeComponent();
            Title.DataSource = Enum.GetNames(typeof(names));
            Title1.DataSource = Enum.GetNames(typeof(names));
            formOKUD.Text = 0330512.ToString();
        }

        private void signature_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignaturesFrom signForm = new SignaturesFrom();
            signForm.Owner = this;
            signForm.ShowDialog();
        }

        public void setSignatures(List<Employee> employees)
        {
            this.employees = employees;
        }

        public void setReference(String[] refer)
        {
            this.refer = refer;         
            obj.setRe(refer);
        }
        public void setRevenue(String[] rev)
        {
            this.rev = rev;
            obj1.setSum(rev);
        }

        private void addRow(DataGridView table, int rowIndex)
        {
            if (table.Rows[rowIndex - 1].Cells[0].Value == null)
                table.Rows[rowIndex - 1].Cells[0].Value = nextIndex();

            Record record = new Record((int)table.Rows[rowIndex - 1].Cells[0].Value);
            records.Add(record);
        }

        private void accountTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (fillFlag == 1)
                return;
            addRow((DataGridView)sender, e.RowIndex);
        }

        private Record cellChange(DataGridView table, int rowIndex, int columnIndex)
        {
            int number = (int)table.Rows[rowIndex].Cells[0].Value;
            Record current = findRecord(number);
            if (current == null)
                return null;
            String val = (String)table.Rows[rowIndex].Cells[columnIndex].Value;
            switch (columnIndex)
            {              
                case 2:
                    {
                        current.Recname = val;
                        current.setRec(val, current.CostFact, current.CostEnterprise);                   
                        fillAccountTable();
                        fillConditionTable();
                    } break;
                case 4:
                    {
                        if (table.Columns[columnIndex].Name == "ColRelise")
                        {
                            int result;
                            bool correct = int.TryParse(val, out result);
                            if (correct)
                            {
                                current.ColRelise = result;
                                current.setRec(current.Recname, current.CostFact, current.CostEnterprise);
                                fillAccountTable();
                                fillConditionTable();
                            }
                            else
                            {
                                MessageBox.Show("Введите числовое значение", "Вы ввели некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                table.Rows[rowIndex].Cells[columnIndex].Value = "";
                            }
                        }
                        else
                        {
                            int result;
                            bool correct = int.TryParse(val, out result);
                            if (correct)
                            {
                                current.CostEnterprise = result;
                                current.setRec(current.Recname, current.CostFact, current.CostEnterprise);
                                fillAccountTable();
                                fillConditionTable();
                            }
                            else
                            {
                                MessageBox.Show("Введите числовое значение", "Вы ввели некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                table.Rows[rowIndex].Cells[columnIndex].Value = "";
                            }
                        }
                            
                    } break;
                case 5:
                    {
                        if (table.Columns[columnIndex].Name == "Note")
                            current.Note = val;
                        else
                        {
                            int result;
                            bool correct = int.TryParse(val, out result);
                            if (correct)
                            {
                                current.CostFact = result;
                                current.setRec(current.Recname, current.CostFact, current.CostEnterprise);
                                fillAccountTable();
                                fillConditionTable();
                            }
                            else
                            {
                                MessageBox.Show("Введите числовое значение", "Вы ввели некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                table.Rows[rowIndex].Cells[columnIndex].Value = "";
                            }
                        }
                    } break;
            }
            return current;
        }

        private void accountTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (fillFlag == 1)
                return;
            if (e.RowIndex < 0)
                return;
            Record current = cellChange((DataGridView)sender, e.RowIndex, e.ColumnIndex);
            if (current == null)
                return;
            //accountTable.Rows[e.RowIndex].Cells[3].Value = current.Code.ToString();
            //accountTable.Rows[e.RowIndex].Cells[5].Value = current.SumFact.ToString();
            //accountTable.Rows[e.RowIndex].Cells[6].Value = current.SumEnterprise.ToString();

            //accountTable.Rows[e.RowIndex].Cells[9].Value = current.SumTotal.ToString();
            //accountTable.Rows[e.RowIndex].Cells[8].Value = current.NumTotal.ToString();

            countTotal();
        }

        private void conditionsTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (fillFlag == 1)
                return;
            addRow((DataGridView)sender, e.RowIndex);
        }

        private void conditionsTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || fillFlag == 1)
                return;
            cellChange((DataGridView)sender, e.RowIndex, e.ColumnIndex);

            countTotal();
        }

        private void countTotal()
        {
            int totalCol = 0;
            int totalSumFact = 0;
            int totalSumEnter = 0;
            for (int i = 0; i < accountTable.Rows.Count; i++)
            {
                if (accountTable.Rows[i].Cells[4].Value != null)
                    totalCol += int.Parse(accountTable.Rows[i].Cells[4].Value.ToString());
                if (accountTable.Rows[i].Cells[6].Value != null)
                    totalSumFact += int.Parse(accountTable.Rows[i].Cells[6].Value.ToString());
            }

            for (int i = 0; i < conditionsTable.Rows.Count; i++)
            {
                if (conditionsTable.Rows[i].Cells[5].Value != null)
                    totalSumEnter += int.Parse(conditionsTable.Rows[i].Cells[5].Value.ToString());
            }

            total.Text = totalCol.ToString();
            totalSumF.Text = totalSumFact.ToString();
            totalSumEn.Text = totalSumEnter.ToString();
            Documents.getInst3().setStr(totalSumF.Text);
            textBox1.Text = Documents.getInst3().getStr();
            String text = Prog.returnTextNumber(textBox1.Text);
            textBox1.Text = text;
        }

        private void AccountingTab_Selected(object sender, TabControlEventArgs e)
        {
            if (records.Count == 0)
                return;
            int selectedTab = ((TabControl)sender).SelectedIndex;
            if (selectedTab == 0)
                fillAccountTable();
            else fillConditionTable();
        }

        private void fillAccountTable()
        {
            fillFlag = 1;
            accountTable.Rows.Clear();
            accountTable.Rows.Add(records.Count);
            for (int i = 0 ; i < records.Count; i++)
            {
                accountTable.Rows[i].Cells[0].Value = records[i].Number;
                accountTable.Rows[i].Cells[1].Value = records[i].NumberCalc;
                accountTable.Rows[i].Cells[2].Value = records[i].Recname;
                accountTable.Rows[i].Cells[3].Value = records[i].Code.ToString();
                accountTable.Rows[i].Cells[4].Value = records[i].ColRelise.ToString();
                accountTable.Rows[i].Cells[5].Value = records[i].CostFact.ToString();
                accountTable.Rows[i].Cells[6].Value = records[i].SumFact.ToString();
            }
            fillFlag = 0;
        }

        private void fillConditionTable()
        {
            fillFlag = 1;
            conditionsTable.Rows.Clear();
            conditionsTable.Rows.Add(records.Count);
            for (int i = 0; i < records.Count; i++)
            {
                conditionsTable.Rows[i].Cells[0].Value = records[i].Number;
                conditionsTable.Rows[i].Cells[1].Value = records[i].NumberCalc;
                conditionsTable.Rows[i].Cells[2].Value = records[i].Recname;
                conditionsTable.Rows[i].Cells[3].Value = records[i].Code.ToString();
                conditionsTable.Rows[i].Cells[4].Value = records[i].CostEnterprise.ToString();
                conditionsTable.Rows[i].Cells[5].Value = records[i].SumEnterprise.ToString();
                //conditionsTable.Rows[i].Cells[4].Value = records[i].Conditions;
                conditionsTable.Rows[i].Cells[6].Value = records[i].Note;
            }
            fillFlag = 0;
        }


        private void deleteRecord(DataGridViewRow row)
        {
            if (fillFlag == 1)
                return;
            int number = (int)row.Cells[0].Value;
            Record current = findRecord(number);
            records.Remove(current);
        }

        private void conditionsTable_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            deleteRecord(e.Row);
        }

        private void accountTable_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            deleteRecord(e.Row);
        }

        private void btnToExcel_Click(object sender, EventArgs e)
        {
            // Открываем приложение
            application = new Application
            {
                DisplayAlerts = false
            };

            // Файл шаблона
            const string template = "op12.xlsx";

            // Открываем книгу
            workBook = application.Workbooks.Open(Path.Combine(Environment.CurrentDirectory, template));

            // Получаем активную таблицу
            worksheet = workBook.ActiveSheet as Worksheet;

            refer = obj.getRe();
            rev = obj1.getSum();

            // Записываем данные
            worksheet.Range["A6"].Value = organ.SelectedItem;
            worksheet.Range["A8"].Value = division.SelectedItem;
            if (formOKUD.Text == "" || formOKPO.Text == "" || viewOKPD.Text == "" || viewOperation.Text == "" || actNumber.Text == "")
            {
                MessageBox.Show("Вы не указали коды для документа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                worksheet.Range["AO5"].Value = formOKUD.Text;
                worksheet.Range["AO6"].Value = formOKPO.Text;
                worksheet.Range["AO9"].Value = viewOKPD.Text;
                worksheet.Range["AO10"].Value = viewOperation.Text;
                worksheet.Range["U14"].Value = actNumber.Text;
                worksheet.Range["AB14"].Value = dateDocument.Value.Date;
            }
            
            if (employees != null)
            {
                worksheet.Range["AM13"].Value = employees[0].Post;
                worksheet.Range["AQ15"].Value = employees[0].FullName;
                worksheet.Range["AC100"].Value = employees[1].FullName;
                worksheet.Range["H102"].Value = employees[2].Post;
                worksheet.Range["AC102"].Value = employees[2].FullName;
                worksheet.Range["H104"].Value = employees[3].Post;
                worksheet.Range["AC104"].Value = employees[3].FullName;
                //worksheet.Range["H104"].Value = employees[4].Post;
                worksheet.Range["U113"].Value = employees[4].FullName;
                //worksheet.Range["H104"].Value = employees[5].Post;
                worksheet.Range["O111"].Value = employees[5].FullName;
            }
            else
            {
                MessageBox.Show("Ошибка", "Вы не указали руководство", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int pivot = 25;
            for (int i = 0; i < records.Count; i++)
            {
                pivot++;
                if (pivot == 55)
                    pivot = 65;
                if (pivot == 89)
                    break;
                worksheet.Cells[pivot, "A"].Value = records[i].Number;
                worksheet.Cells[pivot, "D"].Value = records[i].NumberCalc;
                worksheet.Cells[pivot, "H"].Value = records[i].Recname;
                worksheet.Cells[pivot, "S"].Value = records[i].Code;
                worksheet.Cells[pivot, "V"].Value = records[i].ColRelise;
                worksheet.Cells[pivot, "Z"].Value = records[i].CostFact;
                worksheet.Cells[pivot, "AE"].Value = records[i].SumFact;
                worksheet.Cells[pivot, "AJ"].Value = records[i].CostEnterprise;
                worksheet.Cells[pivot, "AO"].Value = records[i].SumEnterprise;
                worksheet.Cells[pivot, "AT"].Value = records[i].Note;
            }

            worksheet.Cells[91, "V"].Value = total.Text;
            worksheet.Cells[91, "AE"].Value = totalSumF.Text;
            worksheet.Cells[91, "AO"].Value = totalSumEn.Text;
            worksheet.Cells[107, "I"].Value = textBox1.Text;

            //refer[]
            if (refer[0] == "" || refer[1] == "" || refer[2] == "" || refer[3] == "")
            {
                MessageBox.Show("Вы не указали коды для документа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                worksheet.Range["E93"].Value = refer[0];
                worksheet.Range["D95"].Value = refer[1];
                worksheet.Range["T93"].Value = refer[2];
                worksheet.Range["T95"].Value = refer[3];
                worksheet.Range["T97"].Value = refer[4];
            }

            

            // Показываем приложение
            application.Visible = true;


            string savedFileName = "Унифицированная форма ОП-12.xlsx";
            workBook.SaveAs(Path.Combine(Environment.CurrentDirectory, savedFileName));
        }

        private void accountTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SignaturesFrom a = new SignaturesFrom();
            a.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignaturesFrom signForm = new SignaturesFrom();
            signForm.Owner = this;
            signForm.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void spravka_Click(object sender, EventArgs e)
        {
            String[] strRes = new string[2];
            strRes[0] = totalSumEn.Text;
            strRes[1] = totalSumEn.Text;
            Documents.getInst4().setSum(strRes);
            Reference refForm = new Reference();
            refForm.Owner = this;
            refForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Revenue revForm = new Revenue();
            revForm.Owner = this;
            revForm.ShowDialog();
        }

    }
}
