using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // sekisuri 20190407 자식폼을 불러오면 메인은 숨겼다가 자식폼을 종료하면 나타난다.
        private void HideForm(int value)
        {
            this.Opacity = value;
        }
        private void FileWR_Click(object sender, EventArgs e)
        {
            HideForm(0); // sekisuri 20190407 부모폼을 숨긴다.
            FileRWForm FileRW = new FileRWForm();
            FileRW.SendMsg += new FileRWForm.SendMsgDele(Child_SendMsg);
            FileRW.Show(); // 모달 옵션으로 폼 실행

            
        }

        void Child_SendMsg(int msg)
        {
            HideForm(msg); // sekisuri 20190405 자식이 종료하면 숨겨둔 부모를 보여준다.
        }

       
    }
}
