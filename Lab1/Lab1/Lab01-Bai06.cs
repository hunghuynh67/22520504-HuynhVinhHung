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
    public partial class Lab01_Bai06 : Form
    {
        public Lab01_Bai06()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ng, th, nam;
            ng = int.Parse(textBox1.Text);
            th = int.Parse(textBox2.Text);
            nam = int.Parse(textBox3.Text);
            string result;
            switch (th)
            {
                case 1:
                    if (ng >= 20) result = "Bảo Bình"; 
                    else result = "Ma Kết"; break;
                case 2:
                    if (ng >= 19) result = "Song Ngư";
                    else result = "Bảo Bình"; break;
                case 3:
                    if (ng >= 21) result = "Bạch Dương";
                    else result = "Song Ngư"; break;
                case 4:
                    if (ng >= 20) result = "Kim Ngưu";
                    else result = "Bạch Dương"; break;
                case 5:
                    if (ng >= 21) result = "Song Tử";
                    else result = "Kim Ngưu"; break;
                case 6:
                    if (ng >= 21) result = "Cự Giải";
                    else result = "Song Tử"; break;
                case 7:
                    if (ng >= 23) result = "Sư Tử";
                    else result = "Cự Giải"; break;
                case 8:
                    if (ng >= 23) result = "Xử Nữ";
                    else result = "Sư Tử"; break;
                case 9:
                    if (ng >= 23) result = "Thiên Bình";
                    else result = "Xử Nữ"; break;
                case 10:
                    if (ng >= 23) result = "Bọ Cạp";
                    else result = "Thiên Bình"; break;
                case 11:
                    if (ng >= 22) result = "Nhân Mã";
                    else result = "Bọ Cạp"; break;
                case 12:
                    if (ng >= 22) result = "Ma Kết";
                    else result = "Nhân Mã"; break;
                default:
                    result = "Không xác định"; break;
            }
            textBox4.Text = result.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Lab01_Bai06_Load(object sender, EventArgs e)
        {

        }
    }
}
