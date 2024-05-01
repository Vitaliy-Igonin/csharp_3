using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите Name");
            }

            if (textBox2.TextLength < 8)
            {
                MessageBox.Show("Пароль должен содержать не менее 8 символов");
            }

            if (textBox3.Text != textBox2.Text)
            {
                MessageBox.Show("Пароли не совпадают");
            }

            Regex regex_v = new Regex(@"[^@\s]+@[^@\s]+\.[^@\s]+");
            bool isvalid_v = regex_v.IsMatch(textBox4.Text);
            if (isvalid_v == false)
            {
                MessageBox.Show("Неправильный формат электронной почты");
            }

            int num = Convert.ToInt32(textBox5.Text);

            if (num < 18 || num > 65)
            {
                MessageBox.Show("Введите свой возраст");
            }
        }
    }
}
