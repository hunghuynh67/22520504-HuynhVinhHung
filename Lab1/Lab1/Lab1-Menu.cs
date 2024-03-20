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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab2_Bai02 frm2 = new Lab2_Bai02();
            frm2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab01_Bai03 frm3 = new Lab01_Bai03();
            frm3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab01_Bai04 frm4 = new Lab01_Bai04();
            frm4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lab01_Bai05 frm5 = new Lab01_Bai05();
            frm5.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Lab01_Bai06 frm6 = new Lab01_Bai06();
            frm6.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Lab01_Bai07 frm7 = new Lab01_Bai07();
            frm7.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Lab01_Bai08 frm8 = new Lab01_Bai08();
            frm8.ShowDialog();
        }
    }
}
