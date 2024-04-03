﻿using System;
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
    public partial class Lab02_Bai07 : Form
    {
        string path = @"D:\";
        public Lab02_Bai07()
        {
            InitializeComponent();
            if (Directory.Exists(path))
            {
                TreeNode root = new TreeNode() { Text = path };
                treeView1.Nodes.Add(root);
                LoadExplorer(root);
            }
        }
        void LoadExplorer(TreeNode root)
        {
            if (root == null)
                return;
            try
            {


                var folderList = new DirectoryInfo(root.Text).GetDirectories();

                if (folderList.Count() == 0)
                    return;

                foreach (DirectoryInfo item in folderList)
                {
                    if (Directory.Exists(item.FullName))
                    {
                        TreeNode node = new TreeNode() { Text = item.FullName };
                        root.Nodes.Add(node);
                        LoadExplorer(node);
                    }
                }
            }
            catch
            {
                return;
            }
        }

        void LoadTreeView()
        {
            treeView1.CheckBoxes = true;
           
        }

        
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
