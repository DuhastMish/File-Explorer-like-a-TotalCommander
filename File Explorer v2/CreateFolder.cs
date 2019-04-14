﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Explorer_v2
{
    public partial class CreateFolder : Form
    {
        public CreateFolder()
        {
            InitializeComponent();
        }

        public static string NameFolder = null;

        private void button_accept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Name_Folder.Text))
            {
                MessageBox.Show("Введите имя!");

            }
            else
            {
                NameFolder = Name_Folder.Text;
                Close();
                Dispose();
            }
        }
    }
}
