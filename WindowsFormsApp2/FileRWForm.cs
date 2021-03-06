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
    public partial class FileRWForm : Form
    {

        public delegate void SendMsgDele(int msg);
        public event SendMsgDele SendMsg; // sekisuri 20190407 부모와 통신하기 위해 이벤트 선언
        public FileRWForm()
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

        private void BtnWASave_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(this.txtWPath.Text))
                {
                    sw.WriteLine(this.txtWView.Text);
                }
            }
            catch { return; }
            MessageBox.Show("파일이 정상적으로 저장되었습니다.", "알림",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnWPath_Click(object sender, EventArgs e)
        {

            if (this.sfdFile.ShowDialog() == DialogResult.OK)
            {
                this.txtWPath.Text = this.sfdFile.FileName;
            }
        }

        private void BtnWLSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(this.txtWPath.Text))
                {
                    foreach (var str in this.txtWView.Lines)
                    {
                        sw.WriteLine(str);
                    }
                }
            }
            catch { return; }
            MessageBox.Show("파일이 정상적으로 저장되었습니다.", "알림",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FileRWForm_FormClosed(object sender, FormClosedEventArgs e)
        {


            SendMsg(100); // sekisuri 20190407 자식이 종료되면 부모에게 메시지를 보낸다.
        }

        private void FileRWForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Form1 main = new Form1();
            //main.Show();
        }

        private void FileRWForm_Load(object sender, EventArgs e)
        {
        }
    }
}
