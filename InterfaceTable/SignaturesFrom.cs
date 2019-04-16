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
    enum posts
    {
        Директор, Бухгалтер, Администратор, Кассир
    };
    public partial class SignaturesFrom : Form
    {
        public SignaturesFrom()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetNames(typeof(posts));
            comboBox3.DataSource = Enum.GetNames(typeof(posts));
            textBox5.Text = "Бригадир";
            comboBox4.DataSource = Enum.GetNames(typeof(posts));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm parent = (MainForm)this.Owner;
            List<Employee> employees = new List<Employee>();
            Employee director = new Employee();
            director.Post = (String)comboBox1.SelectedValue;
            director.FullName = textBox1.Text;
            employees.Add(director);

            Employee mat = new Employee();
            mat.Post = textBox5.Text;
            mat.FullName = textBox2.Text;
            employees.Add(mat);

            Employee kom = new Employee();
            kom.Post = (String)comboBox3.SelectedValue;
            kom.FullName = textBox3.Text;
            employees.Add(kom);

            kom = new Employee();
            kom.Post = (String)comboBox4.SelectedValue;
            kom.FullName = textBox4.Text;
            employees.Add(kom);

            kom = new Employee();
            kom.Post = "Бухгалтер";
            kom.FullName = textBox6.Text;
            employees.Add(kom);

            kom = new Employee();
            kom.Post = "Кассир";
            kom.FullName = textBox7.Text;
            employees.Add(kom);

            parent.setSignatures(employees);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
