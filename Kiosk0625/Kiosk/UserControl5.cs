using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Kiosk
{
    public partial class UserControl5 : UserControl
    {
        

        public string Dis //디스카운트
        {
            get { return dis.Text; }
            set { dis.Text = value; }
        }

        public string Sum // 좌석선택후 넘겨받은 금액
        {
            get { return sum.Text; }
            set { sum.Text = value; }
        }
                
        public string Total //총금액
        {
            get { return total.Text; }
            set { total.Text = value; }
        }

        public UserControl5()
        {
            InitializeComponent();
            
            
        }
        private void pictureBox2_Click_1(object sender, EventArgs e)
            //뒤로가기 및 모든 금액 초기화-유니나 수정
        {
            Main.Instance.pnlContainer.Controls["UserControl4"].BringToFront();
            Sum = "0";
            Dis = "0";
            Total = "0";
        }

        private void buttn2_Click(object sender, EventArgs e)
        {
            //최종결제 control7 이동
            Main.Instance.pnlContainer.Controls.Add(Main.uc7);
            Main.Instance.pnlContainer.Controls["UserControl7"].Location = new Point(0, 200);
            // Location = 유저 폼 생성 
            // new Point (유저폼 생성 위치 ( 왼쪽 0 , 위로 0)
            Main.Instance.pnlContainer.Controls["UserControl7"].BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //통신사 할인 페이지로 이동
            Main.Instance.pnlContainer.Controls.Add(Main.uc6);
            Main.Instance.pnlContainer.Controls["UserControl6"].Location = new Point(0, 200);
            Main.Instance.pnlContainer.Controls["UserControl6"].BringToFront();

        }

      
    }
}
