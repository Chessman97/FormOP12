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
    public partial class Revenue : Form
    {
        public Revenue()
        {
            InitializeComponent();
            //textBox1.Text = Documents.getInst3().getStr();
           // String text = Prog.returnTextNumber(textBox1.Text);
            //textBox1.Text = text;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm obj = new MainForm();
            String[] refer = new string[3];

            if (textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Ошибка", "Вы ввели не все данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            refer[0] = textBox1.Text;
            refer[1] = textBox2.Text;
            refer[2] = textBox3.Text;
            obj.setRevenue(refer);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
