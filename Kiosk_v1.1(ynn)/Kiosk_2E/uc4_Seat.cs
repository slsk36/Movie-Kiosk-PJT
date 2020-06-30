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
    public partial class uc4_Seat : UserControl
    {

        //public static DateTime dt;  //날짜
        //public static string movie; //영화
        //public static int hall;     //상영관
        //public static int round;    //회차
        //public static string customer;  //고객ID

        public string seat; //좌석
        public static string booked = ""; //예약완료

        const int aPrice = 10000;    //성인 요금
        const int yDis = -3000;    //청소년 할인

        public string chk;           //해당자리
        
        public int ticket = 0;          //선택 티켓 수
        
        public uc4_Seat()
        {
            InitializeComponent();

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
        public int money = 0;

        public void Select(Label lbl)  //좌석 선택 메소드
        {

            if (MainForm.person > 0)
            {
                if ((lbl != null) && (lbl.BackColor != Color.Purple))
                {
                    lbl.BackColor = (lbl.BackColor == SystemColors.ControlDark) ? Color.Purple : SystemColors.ControlDark;
                    if ((lbl.BackColor == Color.Purple) && (MainForm.selected == ""))
                    {
                        MainForm.selected += chk;
                        MainForm.person--;
                        ticket++;
                    }
                    else if ((lbl.BackColor == Color.Purple) && (MainForm.selected != ""))
                    {
                        MainForm.selected += "," + chk;
                        MainForm.person--;
                        ticket++;
                    }

                }
                else
                {
                    lbl.BackColor = SystemColors.ControlDark;
                    MainForm.selected = MainForm.selected.Replace(chk, "");
                    MainForm.person++;
                    ticket--;
                }
            }

            else if ((MainForm.person == 0) && (lbl.BackColor == Color.Purple))
            {
                lbl.BackColor = SystemColors.ControlDark;
                MainForm.selected = MainForm.selected.Replace(chk, "");
                MainForm.person++;
                ticket--;
            }

            else
            {
                MessageBox.Show("좌석선택이 완료되었습니다.");
            }

            if (MainForm.selected == "")
            {

            }
            else if (MainForm.selected[0] == ',')
            {
                MainForm.selected = MainForm.selected.Substring(1);
            }

            else if (MainForm.selected[(MainForm.selected.Length) - 1] == ',')
            {
                MainForm.selected = MainForm.selected.Substring(0, MainForm.selected.Length - 1);
            }

            else if (MainForm.selected.Contains(",,"))
            {
                MainForm.selected = MainForm.selected.Replace(",,", ",");
            }


            Console.WriteLine("선택좌석 : " + MainForm.selected);
            selectedSeats.Text = MainForm.selected;

            Console.WriteLine("인원 수 : " + MainForm.person);
            money = ticket * aPrice;
            if (MainForm.person == 0)
            {
                money += MainForm.youth * yDis;
            }
            sum.Text = money.ToString();

        }

        // 선택 표시 초기화 메소드
        public void seatUnchk()
        {
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

        public void ssReset()
        {
            sum.Text = "";
            selectedSeats.Text = "";
            MainForm.selected = "";
        }

        // 선택 초기화
        public void reset_Click(object sender, EventArgs e)
        {
            ssReset();
            Console.WriteLine("선택좌석 : " + MainForm.selected);

            MainForm.person += ticket;
            Console.WriteLine("인원 수 : " + MainForm.person);
            ticket = 0;
            seatUnchk();

        }


        //결제하기
        public void pay_Click(object sender, EventArgs e)   //유니나 수정
        {
            if (MainForm.person != 0)    //인원수만큼 좌석선택을 하지 않으면 다음으로 넘어가지 않게
            {
                MessageBox.Show("좌석을 선택해주세요");
            }
            else
            {
                if (!MainForm.Instance.pnlContainer.Controls.ContainsKey("uc5_addDis"))
                {
                    MainForm.aD.Dock = DockStyle.Fill;
                    MainForm.Instance.pnlContainer.Controls.Add(MainForm.aD);
                }

                MainForm.Instance.pnlContainer.Controls["uc5_addDis"].BringToFront();
                seat = selectedSeats.Text; // 좌석 선택
                MainForm.aD.Sum = sum.Text;    //금액 uc5_addDis로 넘기기- 금액 주고받는 오류수정
                MainForm.aD.Total = sum.Text;
                MainForm.page += 1;
            }
        }


        //클릭시 좌석 선택 및 취소
        private void A1_Click(object sender, EventArgs e)
        {
            chk = "A1";
            Label lab = sender as Label;
            Select(lab);
        }

        private void A2_Click(object sender, EventArgs e)
        {
            chk = "A2";
            Label lab = sender as Label;
            Select(lab);
        }

        private void A3_Click(object sender, EventArgs e)
        {
            chk = "A3";
            Label lab = sender as Label;
            Select(lab);
        }
        
        private void A4_Click(object sender, EventArgs e)
        {
            chk = "A4";
            Label lab = sender as Label;
            Select(lab);
        }

        private void B1_Click(object sender, EventArgs e)
        {
            chk = "B1";
            Label lab = sender as Label;
            Select(lab);
        }

        private void B2_Click(object sender, EventArgs e)
        {
            chk = "B2";
            Label lab = sender as Label;
            Select(lab);
        }

        private void B3_Click(object sender, EventArgs e)
        {
            chk = "B3";
            Label lab = sender as Label;
            Select(lab);
        }

        private void B4_Click(object sender, EventArgs e)
        {
            chk = "B4";
            Label lab = sender as Label;
            Select(lab);
        }

        private void B5_Click(object sender, EventArgs e)
        {
            chk = "B5";
            Label lab = sender as Label;
            Select(lab);
        }

        private void C1_Click(object sender, EventArgs e)
        {
            chk = "C1";
            Label lab = sender as Label;
            Select(lab);
        }

        private void C2_Click(object sender, EventArgs e)
        {
            chk = "C2";
            Label lab = sender as Label;
            Select(lab);
        }

        private void C3_Click(object sender, EventArgs e)
        {
            chk = "C3";
            Label lab = sender as Label;
            Select(lab);
        }

        private void C4_Click(object sender, EventArgs e)
        {
            chk = "C4";
            Label lab = sender as Label;
            Select(lab);
        }

        private void C5_Click(object sender, EventArgs e)
        {
            chk = "C5";
            Label lab = sender as Label;
            Select(lab);
        }

        private void D3_Click(object sender, EventArgs e)
        {
            chk = "D3";
            Label lab = sender as Label;
            Select(lab);
        }

        private void D4_Click(object sender, EventArgs e)
        {
            chk = "D4";
            Label lab = sender as Label;
            Select(lab);
        }

        private void D5_Click(object sender, EventArgs e)
        {
            chk = "D5";
            Label lab = sender as Label;
            Select(lab);
        }
    }
}
