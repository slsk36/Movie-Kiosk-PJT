using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class UserControl4 : UserControl
    {
        public static DateTime dt;  //날짜
        public static string movie; //영화
        public static int hall;     //상영관
        public static int round;    //회차

        public static string customer;  //고객ID
        public int adult;    //성인 수
        public int youth;    //청소년 수
        public static int person; //총 인원수

        public static int aPrice = 10000;    //성인 요금
        public static int yDis = -3000;    //청소년 할인

        public static string chk;           //해당자리
        public static string selected = "";    //선택좌석
        public static int ticket = 0;          //선택 티켓 수
        public static string booked = ""; //예약완료


        public UserControl4(int adult, int youth)   //매개변수 추가함
        {
            InitializeComponent();
            this.adult = adult;
            this.youth = youth;
            person = adult + youth;

            //예매완료된 좌석 선택 방지
            if (booked.Contains("A1")) { stateA1.BringToFront(); }
            if (booked.Contains("A2")) { stateA2.BringToFront(); }
            if (booked.Contains("A3")) { stateA3.BringToFront(); }
            if (booked.Contains("A4")) { stateA4.BringToFront(); }
            if (booked.Contains("B1")) { stateB1.BringToFront(); }
            if (booked.Contains("B2")) { stateB2.BringToFront(); }
            if (booked.Contains("B3")) { stateB3.BringToFront(); }
            if (booked.Contains("B4")) { stateB4.BringToFront(); }
            if (booked.Contains("B5")) { stateB5.BringToFront(); }
            if (booked.Contains("C1")) { stateC1.BringToFront(); }
            if (booked.Contains("C2")) { stateC2.BringToFront(); }
            if (booked.Contains("C3")) { stateC3.BringToFront(); }
            if (booked.Contains("C4")) { stateC4.BringToFront(); }
            if (booked.Contains("C5")) { stateC5.BringToFront(); }
            if (booked.Contains("D3")) { stateD3.BringToFront(); }
            if (booked.Contains("D4")) { stateD4.BringToFront(); }
            if (booked.Contains("D5")) { stateD5.BringToFront(); }
        }

        public void Select(Label lbl)  //좌석 선택 메소드
        {

            if (person > 0)
            {
                if ((lbl != null) && (lbl.BackColor != Color.Purple))
                {
                    lbl.BackColor = (lbl.BackColor == SystemColors.ControlDark) ? Color.Purple : SystemColors.ControlDark;
                    if ((lbl.BackColor == Color.Purple) && (selected == ""))
                    {
                        selected += chk;
                        person--;
                        ticket++;
                    }
                    else if ((lbl.BackColor == Color.Purple) && (selected != ""))
                    {
                        selected += "," + chk;
                        person--;
                        ticket++;
                    }

                }
                else
                {
                    lbl.BackColor = SystemColors.ControlDark;
                    selected = selected.Replace(chk, "");
                    person++;
                    ticket--;
                }
            }

            else if ((person == 0) && (lbl.BackColor == Color.Purple))
            {
                lbl.BackColor = SystemColors.ControlDark;
                selected = selected.Replace(chk, "");
                person++;
                ticket--;
            }

            else
            {
                MessageBox.Show("좌석선택이 완료되었습니다.");
            }

            if (selected == "")
            {

            }
            else if (selected[0] == ',')
            {
                selected = selected.Substring(1);
            }

            else if (selected[(selected.Length) - 1] == ',')
            {
                selected = selected.Substring(0, selected.Length - 1);
            }

            else if (selected.Contains(",,"))
            {
                selected = selected.Replace(",,", ",");
            }


            Console.WriteLine("선택좌석 : " + selected);
            selectedSeats.Text = selected;

            Console.WriteLine("인원 수 : " + person);
            int money = ticket * aPrice;
            if (person == 0)
            {
                money += youth * yDis;
            }
            sum.Text = money.ToString();

        }

        // 선택 초기화
        private void reset_Click_1(object sender, EventArgs e)
        {
            sum.Text = "";
            selectedSeats.Text = "";
            selected = "";
            Console.WriteLine("선택좌석 : " + selected);

            person += ticket;
            Console.WriteLine("인원 수 : " + person);
            ticket = 0;
            

            if (A1.BackColor == Color.Purple) { A1.BackColor = SystemColors.ControlDark; };
            if (A2.BackColor == Color.Purple) { A2.BackColor = SystemColors.ControlDark; };
            if (A3.BackColor == Color.Purple) { A3.BackColor = SystemColors.ControlDark; };
            if (A4.BackColor == Color.Purple) { A4.BackColor = SystemColors.ControlDark; };
            if (B1.BackColor == Color.Purple) { B1.BackColor = SystemColors.ControlDark; };
            if (B2.BackColor == Color.Purple) { B2.BackColor = SystemColors.ControlDark; };
            if (B3.BackColor == Color.Purple) { B3.BackColor = SystemColors.ControlDark; };
            if (B4.BackColor == Color.Purple) { B4.BackColor = SystemColors.ControlDark; };
            if (B5.BackColor == Color.Purple) { B5.BackColor = SystemColors.ControlDark; };
            if (C1.BackColor == Color.Purple) { C1.BackColor = SystemColors.ControlDark; };
            if (C2.BackColor == Color.Purple) { C2.BackColor = SystemColors.ControlDark; };
            if (C3.BackColor == Color.Purple) { C3.BackColor = SystemColors.ControlDark; };
            if (C4.BackColor == Color.Purple) { C4.BackColor = SystemColors.ControlDark; };
            if (C5.BackColor == Color.Purple) { C5.BackColor = SystemColors.ControlDark; };
            if (D3.BackColor == Color.Purple) { D3.BackColor = SystemColors.ControlDark; };
            if (D4.BackColor == Color.Purple) { D4.BackColor = SystemColors.ControlDark; };
            if (D5.BackColor == Color.Purple) { D5.BackColor = SystemColors.ControlDark; };
        }

        //결제하기
        private void pay_Click(object sender, EventArgs e)
        {
            if (!Main.Instance.pnlContainer.Controls.ContainsKey("UserControl5"))
            {
                UserControl5 uc5 = new UserControl5();
                uc5.Dock = DockStyle.Fill;
                Main.Instance.pnlContainer.Controls.Add(uc5);
            }
            Main.Instance.pnlContainer.Controls["UserControl5"].BringToFront();
        }


        //클릭시 좌석 선택 및 취소
        private void A2_Click_1(object sender, EventArgs e)
        {
            chk = "A2";
            Label lab = sender as Label;
            Select(lab);
        }

        private void A3_Click_1(object sender, EventArgs e)
        {
            chk = "A3";
            Label lab = sender as Label;
            Select(lab);
        }

        private void A1_Click(object sender, EventArgs e)
        {
            chk = "A1";
            Label lab = sender as Label;
            Select(lab);
        }

        private void A4_Click_1(object sender, EventArgs e)
        {
            chk = "A4";
            Label lab = sender as Label;
            Select(lab);
        }

        private void B1_Click_1(object sender, EventArgs e)
        {
            chk = "B1";
            Label lab = sender as Label;
            Select(lab);
        }

        private void B2_Click_1(object sender, EventArgs e)
        {
            chk = "B2";
            Label lab = sender as Label;
            Select(lab);
        }

        private void B3_Click_1(object sender, EventArgs e)
        {
            chk = "B3";
            Label lab = sender as Label;
            Select(lab);
        }

        private void B4_Click_1(object sender, EventArgs e)
        {
            chk = "B4";
            Label lab = sender as Label;
            Select(lab);
        }

        private void B5_Click_1(object sender, EventArgs e)
        {
            chk = "B5";
            Label lab = sender as Label;
            Select(lab);
        }

        private void C1_Click_1(object sender, EventArgs e)
        {
            chk = "C1";
            Label lab = sender as Label;
            Select(lab);
        }

        private void C2_Click_1(object sender, EventArgs e)
        {
            chk = "C2";
            Label lab = sender as Label;
            Select(lab);
        }

        private void C3_Click_1(object sender, EventArgs e)
        {
            chk = "C3";
            Label lab = sender as Label;
            Select(lab);
        }

        private void C4_Click_1(object sender, EventArgs e)
        {
            chk = "C4";
            Label lab = sender as Label;
            Select(lab);
        }

        private void C5_Click_1(object sender, EventArgs e)
        {
            chk = "C5";
            Label lab = sender as Label;
            Select(lab);
        }

        private void D3_Click_1(object sender, EventArgs e)
        {
            chk = "D3";
            Label lab = sender as Label;
            Select(lab);
        }

        private void D4_Click_1(object sender, EventArgs e)
        {
            chk = "D4";
            Label lab = sender as Label;
            Select(lab);
        }

        private void D5_Click_1(object sender, EventArgs e)
        {
            chk = "D5";
            Label lab = sender as Label;
            Select(lab);
        }


        //뒤로가기(이전화면)
        private void back_Click(object sender, EventArgs e)
        {
            Main.Instance.pnlContainer.Controls["UserControl3"].BringToFront();
            person = 0;
        }
    }
}
