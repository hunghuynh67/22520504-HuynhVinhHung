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
    public partial class Lab01_Bai03 : Form
    {
        public Lab01_Bai03()
        {
            InitializeComponent();
        }

        private void Lab01_Bai03_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                int num;
                num = Int32.Parse(textBox1.Text);
                string speak;
                switch (num)
                {
                    case 0: speak = "Không"; break;
                    case 1: speak = "Một"; break;
                    case 2: speak = "Hai"; break;
                    case 3: speak = "Ba"; break;
                    case 4: speak = "Bốn"; break;
                    case 5: speak = "Năm"; break;
                    case 6: speak = "Sáu"; break;
                    case 7: speak = "Bảy"; break;
                    case 8: speak = "Tám"; break;
                    case 9: speak = "Chín"; break;
                default: speak = "Số khác"; break;
                }

                textBox2.Text = speak.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
