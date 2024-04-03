using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab02_Bai03 : Form
    {
        public Lab02_Bai03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
             
              string[] lines = File.ReadAllLines("C:\\Users\\MSI\\source\\repos\\Lab2\\input3.txt");

                using (StreamWriter writer = new StreamWriter("C:\\Users\\MSI\\source\\repos\\Lab2\\output3.txt"))
                {
                    foreach (string line in lines)
                    {
                       
                        double result = Tinh(line);
                        writer.WriteLine($"{line} = {result}");
                    }
                }
            }

             double Tinh(string chuoi)
            {
        
                var matches = Regex.Matches(chuoi, @"(\d+(\.\d+)?|\+|-|\*|\/)");

                double result = 0;
                double num = 0;
                char phepToan = '+';

                foreach (Match match in matches)
                {
                    string value = match.Value;

                    if (double.TryParse(value, out double number))
                    {
                       
                        if (phepToan == '+')
                        {
                            result += number;
                        }
                        else if (phepToan == '-')
                        {
                            result -= number;
                        }
                        else if (phepToan == '*')
                        {
                            result *= number;
                        }
                        else if (phepToan == '/')
                        {
                            result /= number;
                        }

                      num = number;
                    }
                    else
                    {

                        phepToan = value[0];
                    }
                }

                return result;
            }
        }
    }
}
