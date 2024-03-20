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
    public partial class Lab01_Bai04 : Form
    {
        public Lab01_Bai04()
        {
            InitializeComponent();
        }

        private void Lab01_Bai04_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "";
            string result = "";
            name = textBox1.Text;
            result = result + $"Họ tên khách hàng: {name}\n";
            string loaiVe = "";
            if ((comboBox3.Text == "A" && ((comboBox4.Text == "1") || (comboBox4.Text == "5"))) || (comboBox3.Text == "C" && ((comboBox4.Text == "1")) || (comboBox4.Text == "5")))
            {
                loaiVe = "Vé vớt";
            }
            else if ((comboBox3.Text == "A" && (comboBox4.Text == "2" || comboBox4.Text == "3" || comboBox4.Text == "4")) || (comboBox3.Text == "C" && (comboBox4.Text == "2" || comboBox4.Text == "3" || comboBox4.Text == "4")) || (comboBox3.Text == "B" && ((comboBox4.Text == "1")|| (comboBox4.Text == "5" ))))
            {
                loaiVe = "Vé thường";

            }
            else if (comboBox3.Text == "B" && ((comboBox4.Text == "2") || (comboBox4.Text == "3") || (comboBox4.Text == "4")))
            {
                loaiVe = "Vé Vip";
            }

            long giaVe = 1;
            if (comboBox1.Text == "Đào, phở và piano")
            {
                giaVe = 45000;
            }
            else if (comboBox1.Text == "Mai")
            {
                giaVe = 100000;
            }
            else if (comboBox1.Text == "Gặp lại chị bầu")
            {
                giaVe = 70000;
            }
            else if (comboBox1.Text == "Tarot")
            {
                giaVe = 90000;
            }
            long thanhtien = 1;

            if (loaiVe == "Vé Vip")
            {
                thanhtien = giaVe * 2;
            }
            else if (loaiVe == "Vé thường")
            {
                thanhtien = giaVe;
            }
            else if (loaiVe == "Vé vớt")
            {
                thanhtien = giaVe / 4;
            }
            string phong = comboBox2.Text;
            if (comboBox1.Text == "Mai" && comboBox2.Text == "1")
            {
                MessageBox.Show("Phim không chiếu ở phòng này!");
                phong = "";

            }
            else if (comboBox1.Text == "Gặp lại chị bầu" && (comboBox2.Text == "2" || comboBox2.Text == "3"))
            {
                MessageBox.Show("Phim không chiếu ở phòng này!");
                phong = "";
            }
            else if (comboBox1.Text == "Tarot" && (comboBox2.Text == "1" || comboBox2.Text == "2"))
            {
                MessageBox.Show("Phim không chiếu ở phòng này!");
                phong = "";
            }
             
            result = result + $"Loại vé: {loaiVe}\n";
            result = result + $"Tên phim: {comboBox1.Text}\n";
            result = result + $"Phòng: {phong}\n";
            result = result + $"Thành tiền: {thanhtien}\n";

            richTextBox1.Text = result;
        }
    }
}
