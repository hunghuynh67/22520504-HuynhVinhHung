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
    public partial class Lab02_Bai01 : Form
    {
        public Lab02_Bai01()
        {
            InitializeComponent();
        }

        private void Lab02_Bai01_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("C:\\Users\\MSI\\source\\repos\\Lab2\\input1.txt", FileMode.Open);
            StreamReader rd = new StreamReader(fs, Encoding.UTF8);
            String giatri = rd.ReadToEnd();
            richTextBox1.Text = giatri;   

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string noidung = richTextBox1.Text;
            File.WriteAllText("C:\\Users\\MSI\\source\\repos\\Lab2\\output1.txt", noidung);
            MessageBox.Show("File đã được ghi!");
        }
    }
}
