﻿namespace WindowsFormsApp2
{
    partial class FileRWForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tapMenu = new System.Windows.Forms.TabControl();
            this.tpRead = new System.Windows.Forms.TabPage();
            this.txtRView = new System.Windows.Forms.TextBox();
            this.txtRPath = new System.Windows.Forms.TextBox();
            this.btnRLRead = new System.Windows.Forms.Button();
            this.btnRARead = new System.Windows.Forms.Button();
            this.btnRPath = new System.Windows.Forms.Button();
            this.tpWrite = new System.Windows.Forms.TabPage();
            this.btnWPath = new System.Windows.Forms.Button();
            this.btnWLSave = new System.Windows.Forms.Button();
            this.btnWASave = new System.Windows.Forms.Button();
            this.txtWView = new System.Windows.Forms.TextBox();
            this.txtWPath = new System.Windows.Forms.TextBox();
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tapMenu.SuspendLayout();
            this.tpRead.SuspendLayout();
            this.tpWrite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // tapMenu
            // 
            this.tapMenu.Controls.Add(this.tpRead);
            this.tapMenu.Controls.Add(this.tpWrite);
            this.tapMenu.Location = new System.Drawing.Point(12, 25);
            this.tapMenu.Name = "tapMenu";
            this.tapMenu.SelectedIndex = 0;
            this.tapMenu.Size = new System.Drawing.Size(752, 404);
            this.tapMenu.TabIndex = 0;
            // 
            // tpRead
            // 
            this.tpRead.Controls.Add(this.txtRView);
            this.tpRead.Controls.Add(this.txtRPath);
            this.tpRead.Controls.Add(this.btnRLRead);
            this.tpRead.Controls.Add(this.btnRARead);
            this.tpRead.Controls.Add(this.btnRPath);
            this.tpRead.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tpRead.Location = new System.Drawing.Point(4, 22);
            this.tpRead.Name = "tpRead";
            this.tpRead.Padding = new System.Windows.Forms.Padding(3);
            this.tpRead.Size = new System.Drawing.Size(744, 378);
            this.tpRead.TabIndex = 0;
            this.tpRead.Text = "파일 읽기";
            this.tpRead.UseVisualStyleBackColor = true;
            // 
            // txtRView
            // 
            this.txtRView.Location = new System.Drawing.Point(23, 126);
            this.txtRView.Multiline = true;
            this.txtRView.Name = "txtRView";
            this.txtRView.ReadOnly = true;
            this.txtRView.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRView.Size = new System.Drawing.Size(694, 219);
            this.txtRView.TabIndex = 4;
            // 
            // txtRPath
            // 
            this.txtRPath.Location = new System.Drawing.Point(23, 36);
            this.txtRPath.Name = "txtRPath";
            this.txtRPath.ReadOnly = true;
            this.txtRPath.Size = new System.Drawing.Size(544, 21);
            this.txtRPath.TabIndex = 3;
            // 
            // btnRLRead
            // 
            this.btnRLRead.Location = new System.Drawing.Point(115, 78);
            this.btnRLRead.Name = "btnRLRead";
            this.btnRLRead.Size = new System.Drawing.Size(75, 23);
            this.btnRLRead.TabIndex = 2;
            this.btnRLRead.Text = "라인읽기";
            this.btnRLRead.UseVisualStyleBackColor = true;
            this.btnRLRead.Click += new System.EventHandler(this.BtnRLRead_Click);
            // 
            // btnRARead
            // 
            this.btnRARead.Location = new System.Drawing.Point(23, 78);
            this.btnRARead.Name = "btnRARead";
            this.btnRARead.Size = new System.Drawing.Size(75, 23);
            this.btnRARead.TabIndex = 1;
            this.btnRARead.Text = "전체읽기";
            this.btnRARead.UseVisualStyleBackColor = true;
            this.btnRARead.Click += new System.EventHandler(this.BtnRARead_Click);
            // 
            // btnRPath
            // 
            this.btnRPath.Location = new System.Drawing.Point(592, 36);
            this.btnRPath.Name = "btnRPath";
            this.btnRPath.Size = new System.Drawing.Size(75, 23);
            this.btnRPath.TabIndex = 0;
            this.btnRPath.Text = "파일";
            this.btnRPath.UseVisualStyleBackColor = true;
            this.btnRPath.Click += new System.EventHandler(this.BtnRPath_Click);
            // 
            // tpWrite
            // 
            this.tpWrite.Controls.Add(this.btnWPath);
            this.tpWrite.Controls.Add(this.btnWLSave);
            this.tpWrite.Controls.Add(this.btnWASave);
            this.tpWrite.Controls.Add(this.txtWView);
            this.tpWrite.Controls.Add(this.txtWPath);
            this.tpWrite.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tpWrite.Location = new System.Drawing.Point(4, 22);
            this.tpWrite.Name = "tpWrite";
            this.tpWrite.Padding = new System.Windows.Forms.Padding(3);
            this.tpWrite.Size = new System.Drawing.Size(744, 378);
            this.tpWrite.TabIndex = 1;
            this.tpWrite.Text = "파일 쓰기";
            this.tpWrite.UseVisualStyleBackColor = true;
            // 
            // btnWPath
            // 
            this.btnWPath.Location = new System.Drawing.Point(596, 50);
            this.btnWPath.Name = "btnWPath";
            this.btnWPath.Size = new System.Drawing.Size(75, 23);
            this.btnWPath.TabIndex = 8;
            this.btnWPath.Text = "파일";
            this.btnWPath.UseVisualStyleBackColor = true;
            this.btnWPath.Click += new System.EventHandler(this.BtnWPath_Click);
            // 
            // btnWLSave
            // 
            this.btnWLSave.Location = new System.Drawing.Point(113, 91);
            this.btnWLSave.Name = "btnWLSave";
            this.btnWLSave.Size = new System.Drawing.Size(75, 23);
            this.btnWLSave.TabIndex = 7;
            this.btnWLSave.Text = "라인저장";
            this.btnWLSave.UseVisualStyleBackColor = true;
            this.btnWLSave.Click += new System.EventHandler(this.BtnWLSave_Click);
            // 
            // btnWASave
            // 
            this.btnWASave.Location = new System.Drawing.Point(21, 91);
            this.btnWASave.Name = "btnWASave";
            this.btnWASave.Size = new System.Drawing.Size(75, 23);
            this.btnWASave.TabIndex = 6;
            this.btnWASave.Text = "전체저장";
            this.btnWASave.UseVisualStyleBackColor = true;
            this.btnWASave.Click += new System.EventHandler(this.BtnWASave_Click);
            // 
            // txtWView
            // 
            this.txtWView.Location = new System.Drawing.Point(21, 135);
            this.txtWView.Multiline = true;
            this.txtWView.Name = "txtWView";
            this.txtWView.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtWView.Size = new System.Drawing.Size(694, 219);
            this.txtWView.TabIndex = 5;
            // 
            // txtWPath
            // 
            this.txtWPath.Location = new System.Drawing.Point(21, 50);
            this.txtWPath.Name = "txtWPath";
            this.txtWPath.ReadOnly = true;
            this.txtWPath.Size = new System.Drawing.Size(544, 21);
            this.txtWPath.TabIndex = 4;
            // 
            // sfdFile
            // 
            this.sfdFile.Filter = "텍스트 파일 (*.txt)|*.txt";
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "openFileDialog1";
            this.ofdFile.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // FileRWForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tapMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileRWForm";
            this.Text = "파일 읽기/쓰기";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FileRWForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FileRWForm_FormClosed);
            this.Load += new System.EventHandler(this.FileRWForm_Load);
            this.tapMenu.ResumeLayout(false);
            this.tpRead.ResumeLayout(false);
            this.tpRead.PerformLayout();
            this.tpWrite.ResumeLayout(false);
            this.tpWrite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tapMenu;
        private System.Windows.Forms.TabPage tpRead;
        private System.Windows.Forms.TextBox txtRView;
        private System.Windows.Forms.TextBox txtRPath;
        private System.Windows.Forms.Button btnRLRead;
        private System.Windows.Forms.Button btnRARead;
        private System.Windows.Forms.Button btnRPath;
        private System.Windows.Forms.TabPage tpWrite;
        private System.Windows.Forms.Button btnWPath;
        private System.Windows.Forms.Button btnWLSave;
        private System.Windows.Forms.Button btnWASave;
        private System.Windows.Forms.TextBox txtWView;
        private System.Windows.Forms.TextBox txtWPath;
        private System.Windows.Forms.SaveFileDialog sfdFile;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

