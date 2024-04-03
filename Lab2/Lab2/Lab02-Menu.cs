using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab02_Bai01 frm1 = new Lab02_Bai01();
            frm1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab02_Bai02 frm2 = new Lab02_Bai02();
            frm2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab02_Bai03 frm3 = new Lab02_Bai03();
            frm3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab02_Bai04 frm4 = new Lab02_Bai04();
            frm4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lab02_Bai05 frm5 = new Lab02_Bai05();
            frm5.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Lab02_Bai06 frm6 = new Lab02_Bai06();
            frm6.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        { 
            Lab02_Bai07 frm7 = new Lab02_Bai07();
            frm7.ShowDialog();
        }
    }
}
