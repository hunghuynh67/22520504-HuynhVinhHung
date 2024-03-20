using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Lab2_Bai02 : Form
    {
        public Lab2_Bai02()
        {
            InitializeComponent();
        }

        private void Lab2_Bai02_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num1, num2, num3;
            num1 = float.Parse(textBox1.Text);
            num2 = float.Parse(textBox2.Text);
            num3 = float.Parse(textBox3.Text);


            float max = num1, min = num1;

            if (num2 > max)
            {
                max = num2;
            }

            if (num3 > max)
            {
                max = num3;
            }

            if (num2 < min)
            {
                min = num2;
            }

            if (num3 < min)
            {
                min = num3;
            }

            textBox4.Text = max.ToString();
            textBox5.Text = min.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
