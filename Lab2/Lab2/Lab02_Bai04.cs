using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab02_Bai04 : Form
    {
        public Lab02_Bai04()
        {
            InitializeComponent();
        }
       
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lab02_Bai04_Load(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            float tb = 0;
            textBox7.Text = textBox1.Text;
            textBox8.Text = textBox2.Text;
            textBox9.Text = textBox3.Text;
            textBox10.Text = textBox4.Text;
            textBox11.Text = textBox5.Text;
            textBox12.Text = textBox6.Text;
            textBox13.Text = textBox14.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string msv = textBox2.Text;
            string phone = textBox3.Text;
            string mon1 = textBox4.Text;
            string mon2 = textBox5.Text;
            string mon3 = textBox6.Text;    
            float course1 = float.Parse(mon1);
            float course2 = float.Parse(mon2);
            float course3 = float.Parse(mon3);
            float tb = 0;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(msv) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string filePath = "C:\\Users\\MSI\\source\\repos\\Lab2\\input4.txt";
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine($"{name}\n{msv}\n{phone}\n{mon1}\n{mon2}\n{mon3}");
            }
            MessageBox.Show("Thêm thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string text = File.ReadAllText(filePath);
            richTextBox1.Text = text;
            tb = (course1 + course2 + course3) / 3;
            textBox14.Text = tb.ToString();
        }
    }
}
