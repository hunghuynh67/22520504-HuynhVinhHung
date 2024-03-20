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
    public partial class Lab01_Bai07 : Form
    {
        public Lab01_Bai07()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hoTenDiem = textBox1.Text; 

            
            string[] hoTenDiemArr = hoTenDiem.Split(',');
            string hoTen = hoTenDiemArr[0];
            string danhSachDiem = string.Join(",", hoTenDiemArr.Skip(1));

           
            string[] diemStr = danhSachDiem.Split(',');

            double[] diem = Array.ConvertAll(diemStr, double.Parse);

            double diemTB = diem.Average();

            string kq = $"Họ và tên: {hoTen}\n";
           
            for (int i = 0; i < diem.Length; i++)
            {
                kq += $"Môn {i + 1}: {diem[i]}\n";
            }
            kq += $"Điểm trung bình: {diemTB}\n";

            double diemMax = diem[0];
            double diemMin = diem[0];
            int sttMonMax = 1;
            int sttMonMin = 1;

            for (int i = 1; i < diem.Length; i++)
            {
                if (diem[i] > diemMax)
                {
                    diemMax = diem[i];
                    sttMonMax = i + 1;
                }
                if (diem[i] < diemMin)
                {
                    diemMin = diem[i];
                    sttMonMin = i + 1;
                }
            }
            int soMonDau = 0;
            int soMonKhongDau = 0;
            double diemDat = 5; 

            for (int i = 0; i < diem.Length; i++)
            {
                if (diem[i] >= diemDat)
                {
                    soMonDau++;
                }
                else
                {
                    soMonKhongDau++;
                }
            }

            string xepLoai = "";
            bool coMonDuoiDieuKien = false;

            
            for (int i = 0; i < diem.Length; i++)
            {
                if (xepLoai == "Trung Bình" && diem[i] < 3.5)
                {
                    coMonDuoiDieuKien = true;
                    break;
                }
                else if (xepLoai == "Khá" && diem[i] < 5)
                {
                    coMonDuoiDieuKien = true;
                    break;
                }
                else if (xepLoai == "Giỏi" && diem[i] < 6.5)
                {
                    coMonDuoiDieuKien = true;
                    break;
                }
            }

            if (diemTB >= 8 && coMonDuoiDieuKien == false)
            {
                xepLoai = "Giỏi";
            }
            else if (diemTB >= 6.5 && coMonDuoiDieuKien == false)
            {
                xepLoai = "Khá";
            }
            else if (diemTB >= 5 && coMonDuoiDieuKien == false)
            {
                xepLoai = "Trung bình";
            }
           else if (diemTB >= 3.5 && coMonDuoiDieuKien == false)
            {
                 xepLoai = "Yếu";
            }
           else
            {
                  xepLoai = "Kém";
            }

            kq += $"Môn có điểm cao nhất: Môn {sttMonMax} với điểm {diemMax}\n";
            kq += $"Môn có điểm thấp nhất: Môn {sttMonMin} với điểm {diemMin}\n";
            kq += $"Số môn đậu: {soMonDau}\n";
            kq += $"Số môn không đậu: {soMonKhongDau}\n";
            kq += $"Xếp loại: {xepLoai}";
            richTextBox1.Text = kq;


        }
    }
}
