using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk_2E
{
    public partial class uc5_addDis : UserControl
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


        public uc5_addDis()
        {
            InitializeComponent();
        }

        private void telecomDis_Click(object sender, EventArgs e)
        {
            //통신사 할인 페이지 팝업
            MainForm.aD.Dis = "";
            MainForm.aD.Total = "";

            MainForm.Instance.pnlContainer.Controls.Add(MainForm.slt);

            MainForm.Instance.pnlContainer.Controls["uc5w_selectTel"].Location = new Point(0, 261);
            MainForm.Instance.pnlContainer.Controls["uc5w_selectTel"].BringToFront();
            
        }

        private void payForIt_Click(object sender, EventArgs e)
        {
            //최종결제 control7 이동
            MainForm.Instance.pnlContainer.Controls.Add(MainForm.pmt);
            MainForm.Instance.pnlContainer.Controls["uc6_payment"].Location = new Point(0, 261);
            // Location = 유저 폼 생성 
            // new Point (유저폼 생성 위치 ( 왼쪽 0 , 위로 0)
            MainForm.Instance.pnlContainer.Controls["uc6_payment"].BringToFront();
            MainForm.page += 1;

            switch (MainForm.slt.Telecom)
            {
                case "0.2":
                    MainForm.pmt.disDetail.Text = "KT 멤버쉽";
                    break;

                case "0.15":
                    MainForm.pmt.disDetail.Text = "SKT 멤버쉽";
                    break;

                case "0.1":
                    MainForm.pmt.disDetail.Text = "LG 멤버쉽";
                    break;
            }

            if(MainForm.pmt.disDetail.Text != "")
            {
                MainForm.pmt.disDetail.Text += ", ";
            }

            if (MainForm.youth != 0)
            {
                MainForm.pmt.disDetail.Text += "청소년 우대 " + MainForm.youth + "명";
            }
        }
    }
}
