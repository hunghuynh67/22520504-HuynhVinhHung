using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            long sum = 0;

            if (int.TryParse(textBox1.Text.Trim(), out num1) &&
                int.TryParse(textBox2.Text.Trim(), out num2) &&
                Regex.IsMatch(textBox1.Text, @"^\d+$") &&
                Regex.IsMatch(textBox2.Text, @"^\d+$"))
            {
                sum = num1 + num2;
                textBox3.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
            }
        }

    }
}
