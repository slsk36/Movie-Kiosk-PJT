using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WpfAnimatedGif;
using System.Data.SqlClient;

namespace Kiosk
{

    public partial class Main : Form
    {
        public static UserControl1 uc1 = new UserControl1();
        public static UserControl2 uc2 = new UserControl2();
        public static UserControl3 uc3 = new UserControl3();
        public static UserControl4 uc4 = new UserControl4();
        public static UserControl5 uc5 = new UserControl5();
        public static UserControl6 uc6 = new UserControl6();
        public static UserControl7 uc7 = new UserControl7();


        private void WriteLog(string contents) //로그파일을 만들어서 수정내역 추적
        {
            string logContents = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}] {contents}";
            LogWrite.PrintLog(logContents);
        }

        static Main _obj;

        public void PictureBoxShow()    //메인화면 보여주기 함수
        {
            pictureBox1.Show();
        }


        public static Main Instance
        {
            get
            {
                if(_obj == null)
                {
                    _obj = new Main();
                }
                return _obj;
            }
        }

        public Panel pnlContainer
        {
            get { return panel3; }
            set { panel3 = value;  }
        }

        public Main()
        {
            InitializeComponent();
        }


        private void ticket_page1_Click(object sender, EventArgs e)
        {
            _obj = this;

            uc1.Dock = DockStyle.Fill;
            panel3.Controls.Add(uc1);
            pictureBox1.Hide();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



    }
}
