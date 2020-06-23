using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class UserControl3 : UserControl
    {
        public static int adult;    //성인 수
        public static int youth;    //청소년 수

        public UserControl3()
        {
            InitializeComponent();
        }

        //결제 완료 버튼
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (adult  == 0 && youth == 0 ) //성인 청소년 둘다 0명이면
            {
                MessageBox.Show("인원을 선택하세요");
            }
            else
            {
                if (!Main.Instance.pnlContainer.Controls.ContainsKey("UserControl4"))
                {
                    UserControl4 uc4 = new UserControl4(adult, youth);
                    uc4.Dock = DockStyle.Fill;
                    Main.Instance.pnlContainer.Controls.Add(uc4);
                }
                Main.Instance.pnlContainer.Controls["UserControl4"].BringToFront();
                
            }
        }
        
        // X버튼 기능 : 뒤로가기
        private void btn_del_Click(object sender, EventArgs e)
        {
            Main.Instance.pnlContainer.Controls["UserControl2"].BringToFront();
            Info.Text = "-";
            Info_Y.Text = "-";
        }



        // 성인 인원 수 선택
        private void btnPs_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;       //버튼의 값 받아옴
            Info.Text = btn.Tag.ToString();   //출력창에 버튼의 tag값 text로 변경
            adult = Convert.ToInt32(Info.Text); //adult값 정수로 변환
        }


        //청소년 인원 수 선택
        private void btnYt_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;       //버튼의 값 받아옴
            Info_Y.Text = btn.Tag.ToString();
            youth = Convert.ToInt32(Info_Y.Text);

        }

    }

    
}
