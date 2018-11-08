﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace MailList
{
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            if (idTextBox.Text == "" || nameTextBox.Text == "" || workPlacetextBox.Text == "" || phoneTextBox.Text == "" || emailTextBox.Text == "")
            {
                MessageBox.Show("some input is empty");
            }
            else {
                string sex = "male";
                if (femaleRadio.Checked)
                {
                    sex = "female";
                }

                // 利用string的加法操作构造新纪录，作为一行，写入txt文件中
                string newrecord = idTextBox.Text + " " +
                                   nameTextBox.Text + " " +
                                   sex + " " +
                                   workPlacetextBox.Text + " " +
                                   phoneTextBox.Text + " " +
                                   emailTextBox.Text + "\r\n";
                File.AppendAllText("C:\\Users\\某杰\\Desktop\\MailList.txt", newrecord, UTF8Encoding.Default);
                // 结束insert的调用
                Dispose(true);
            }
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //结束insert的调用
            Dispose(true);
        }
    }
}
