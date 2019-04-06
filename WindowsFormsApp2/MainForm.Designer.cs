namespace WindowsFormsApp2
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FileWR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileWR
            // 
            this.FileWR.Location = new System.Drawing.Point(35, 12);
            this.FileWR.Name = "FileWR";
            this.FileWR.Size = new System.Drawing.Size(100, 39);
            this.FileWR.TabIndex = 0;
            this.FileWR.Text = "파일읽기/쓰기";
            this.FileWR.UseVisualStyleBackColor = true;
            this.FileWR.Click += new System.EventHandler(this.FileWR_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FileWR);
            this.Name = "MainForm";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FileWR;
    }
}