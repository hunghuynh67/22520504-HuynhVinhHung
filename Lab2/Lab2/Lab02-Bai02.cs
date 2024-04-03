using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab2
{
    public partial class Lab02_Bai02 : Form
    {
        public Lab02_Bai02()
        {
            InitializeComponent();
        }

        private void Lab02_Bai02_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\MSI\source\repos\Lab2\input2.txt";

            
            if (!File.Exists(filePath))
            {
                MessageBox.Show("File không tồn tại!");
                return;
            }

            FileInfo fileInfo = new FileInfo(filePath);
            string fileName = fileInfo.Name;
            long fileSize = fileInfo.Length;
            
           
            int lineCount = 0, wordCount = 0, charCount = 0;
            using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lineCount++;
                    wordCount += line.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
                    charCount += line.Length;
                }
            }

           
            string fileContent = File.ReadAllText(filePath);
            textBox1.Text = fileName.ToString();
            textBox2.Text = fileSize.ToString();
            textBox3.Text = filePath.ToString();
            textBox4.Text = lineCount.ToString();
            textBox5.Text = wordCount.ToString();
            textBox6.Text = charCount.ToString();
            richTextBox1.Text = fileContent;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

 }