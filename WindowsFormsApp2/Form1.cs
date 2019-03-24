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
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

      

        private void BtnRPath_Click(object sender, EventArgs e)
        {
            if(this.ofdFile.ShowDialog() == DialogResult.OK)
            {
                this.txtRPath.Text = this.ofdFile.FileName;
            }
        }

        private void BtnRARead_Click(object sender, EventArgs e)
        {
            if(TxtCheck() == false)
            {
                return;
            }

            if (File.Exists(this.txtRPath.Text))
            {
                using(StreamReader sr = new StreamReader(this.txtRPath.Text, Encoding.Default))
                {
                    this.txtRView.Text = sr.ReadToEnd();
                }
            }
            else
            {
                MessageBox.Show("읽을 파일이 없습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
          
        private bool TxtCheck()
        {
            if(this.txtRPath.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void BtnRLRead_Click(object sender, EventArgs e)
        {
            if(TxtCheck() == false)
            {
                return;
            }
            this.txtRView.Clear();
            if (File.Exists(this.txtRPath.Text))
            {
                using(StreamReader sr = new StreamReader(this.txtRPath.Text, Encoding.Default))
                {
                    string line = null;
                    while((line = sr.ReadLine()) != null)
                    {
                        this.txtRView.AppendText(line + "\r\n");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("읽을 파일이 없습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
