using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Lab1
{
    public partial class Lab01_Bai08 : Form
    {
        private List<string> danhSachChuoi = new List<string>();
        public Lab01_Bai08()
        {
            InitializeComponent();
           
            danhSachChuoi.Add("Bún riêu");
            danhSachChuoi.Add("Bún thịt nướng");
            danhSachChuoi.Add("Cơm tấm sườn trứng");
            danhSachChuoi.Add("Phở");
            danhSachChuoi.Add("Gỏi cuốn");
            foreach (string chuoi in danhSachChuoi)
            {
                richTextBox1.AppendText(chuoi + "\n");
            }

           }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Lab01_Bai08_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            danhSachChuoi.Add((string)textBox1.Text);
            richTextBox1.AppendText((string)textBox1.Text + "\n");
         

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int index = random.Next(danhSachChuoi.Count);
            string monan = danhSachChuoi[index];
            textBox2.Text = monan;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
