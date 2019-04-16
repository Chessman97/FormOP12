using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceTable
{
    public partial class Reference : Form
    {
        String[] a = Documents.getInst4().getSum();
        double totalSum;
        int proc1, proc2;
        public Reference()
        {
            InitializeComponent();
            textBox3.Text = a[0];
            textBox4.Text = a[1];
            totalSum = Convert.ToInt32(a[0]) + Convert.ToInt32(a[1]);
            textBox5.Text = Convert.ToString(totalSum);
            textBox1.TextChanged += textBox1_TextChanged;
            textBox2.TextChanged += textBox2_TextChanged;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            totalSum = GetTotalSum();
            textBox5.Text = Convert.ToString(totalSum);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            totalSum = GetTotalSum();
            textBox5.Text = Convert.ToString(totalSum);
        }

        private double GetTotalSum()
        {
            int p1 = 100 - Convert.ToInt32(textBox1.Text);
            int p2 = 100 - Convert.ToInt32(textBox2.Text);
            double s1 = Convert.ToDouble(textBox3.Text);
            double s2 = Convert.ToDouble(textBox4.Text);
            return p1 * s1 * 0.01 + p2 * s2 * 0.01;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm obj = new MainForm();
            String[] refer = new string[5];
            
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Ошибка", "Вы ввели не все данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            refer[0] = textBox1.Text;
            refer[1] = textBox2.Text;
            refer[2] = textBox3.Text;
            refer[3] = textBox4.Text;
            refer[4] = textBox5.Text;
            obj.setReference(refer);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
