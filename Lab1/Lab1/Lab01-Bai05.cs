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
    public partial class Lab01_Bai05 : Form
    {
        public Lab01_Bai05()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            long result;
            
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
                         
            if (comboBox1.Text == "Bảng cửu chương"){
              richTextBox1.Text = $"Bảng cửu chương: B - A";
                for (int i = 1; i <= 10; i++){
                   richTextBox1.Text = richTextBox1.Text + Environment.NewLine + $"{(b - a)} x {i} = {(b - a) * i}";
                   
                }
                        
            }
            if (comboBox1.Text == "Tính toán giá trị")
            {

                result = 1;
                for (int i = 1; i <= (a -b); i++)
                {
                    result = result * i;

                }

                long sum = 0;
                for (int i = 1; i <= b; i++) {
                    sum = sum + (long)Math.Pow(a, i);
                }



                richTextBox1.Text = $"(A - B)! = " + result.ToString();
                richTextBox1.Text = richTextBox1.Text + Environment.NewLine + $"Tổng S = A^1 + A^2 + A^3 + A^4 + … + A^B = " + sum.ToString();
            }
            


        }

        private void Lab01_Bai05_Load(object sender, EventArgs e)
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
            richTextBox1.Clear();
        }
    }
}
