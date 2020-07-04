using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kiosk_2E
{
    public partial class uc4_Seat : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=munggu.iptime.org,25000;Initial Catalog=KinoDB;Persist Security Info=True;User ID=sa;Password=8765432!");

        const int aPrice = 10000;    //성인 요금
        const int yDis = -3000;    //청소년 할인
        public string chk;           //해당자리
        public int ticket = 0;          //선택 티켓 수
        public string DateText { get { return date.Text; } set { date.Text = value; } }
        public string TimeText { get { return time.Text; } set { time.Text = value; } }
        public ListBox EndList { get { return listBox1; } set { listBox1 = value; } } //★uc2의 리스트박스와 연동하기

        public uc4_Seat()
        {
            InitializeComponent();
            listBox1.Visible = false;
            reset_label(); //좌석 라벨 숨기기★
        }

        //예매완료된 좌석 선택 방지
        public void NotBook()
        {
            if (MainForm.m1r.EndList2.Items.Contains("A1")) { stateA1.BringToFront(); }
            if (MainForm.m1r.EndList2.Items.Contains("A2")) { stateA2.BringToFront(); }
            if (MainForm.m1r.EndList2.Items.Contains("A3")) { stateA3.BringToFront(); }
            if (MainForm.m1r.EndList2.Items.Contains("A4")) { stateA4.BringToFront(); }
            if (MainForm.m1r.EndList2.Items.Contains("B1")) { stateB1.BringToFront(); }
            if (MainForm.m1r.EndList2.Items.Contains("B2")) { stateB2.BringToFront(); }
            if (MainForm.m1r.EndList2.Items.Contains("B3")) { stateB3.BringToFront(); }
            if (MainForm.m1r.EndList2.Items.Contains("B4")) { stateB4.BringToFront(); }
            if (MainForm.m1r.EndList2.Items.Contains("B5")) { stateB5.BringToFront(); }
            if (MainForm.m1r.EndList2.Items.Contains("C1")) { stateC1.BringToFront(); }
            if (MainForm.m1r.EndList2.Items.Contains("C2")) { stateC2.BringToFront(); }
            if (MainForm.m1r.EndList2.Items.Contains("C3")) { stateC3.BringToFront(); }
            if (MainForm.m1r.EndList2.Items.Contains("C4")) { stateC4.BringToFront(); }
            if (MainForm.m1r.EndList2.Items.Contains("C5")) { stateC5.BringToFront(); }
            if (MainForm.m1r.EndList2.Items.Contains("D3")) { stateD3.BringToFront(); }
            if (MainForm.m1r.EndList2.Items.Contains("D4")) { stateD4.BringToFront(); }
            if (MainForm.m1r.EndList2.Items.Contains("D5")) { stateD5.BringToFront(); }
        }
        //예매완료 check 해제
        public void NotNotBook()
        {
            stateA1.SendToBack();
            stateA2.SendToBack();
            stateA3.SendToBack();
            stateA4.SendToBack();
            stateB1.SendToBack();
            stateB2.SendToBack();
            stateB3.SendToBack();
            stateB4.SendToBack();
            stateB5.SendToBack();
            stateC1.SendToBack();
            stateC2.SendToBack();
            stateC3.SendToBack();
            stateC4.SendToBack();
            stateC5.SendToBack();
            stateD3.SendToBack();
            stateD4.SendToBack();
            stateD5.SendToBack();
        }

        public void A1_label() //A1에 텍스트있으면 예약번호를 0으로 바꾸고 티켓넘버생성 (uc8에서 작동)
        {
            //MainForm.cpl.ticket_num(); //부킹넘버 생성하기
            con.Open();
            string sql = "update seatInfo set booked=0,ticket_num='"+ MainForm.cpl.BookingNum +"' where date='" + DateText
                + "' and time='" + TimeText + "' and seat_num='" + label1.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            //cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
        }
        public void A2_label() //A2에 텍스트있으면 예약번호를 0으로 바꿔라
        {
            con.Open();
            string sql = "update seatInfo set booked=0,ticket_num='" + MainForm.cpl.BookingNum + "' where date='" + DateText
                + "' and time='" + TimeText + "' and seat_num='" + label2.Text + "'"; 
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
        }
        public void A3_label()
        {
            con.Open();
            string sql = "update seatInfo set booked=0,ticket_num='" + MainForm.cpl.BookingNum + "' where date='" + DateText
                + "' and time='" + TimeText + "' and seat_num='" + label3.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
        }
        public void A4_label()
        {
            con.Open();
            string sql = "update seatInfo set booked=0,ticket_num='" + MainForm.cpl.BookingNum + "' where date='" + DateText
                + "' and time='" + TimeText + "' and seat_num='" + label4.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
        }
        public void B1_label()
        {
            con.Open();
            string sql = "update seatInfo set booked=0,ticket_num='" + MainForm.cpl.BookingNum + "' where date='" + DateText
                + "' and time='" + TimeText + "' and seat_num='" + label5.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
        }
        public void B2_label()
        {
            con.Open();
            string sql = "update seatInfo set booked=0,ticket_num='" + MainForm.cpl.BookingNum + "' where date='" + DateText
                + "' and time='" + TimeText + "' and seat_num='" + label6.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
        }
        public void B3_label()
        {
            con.Open();
            string sql = "update seatInfo set booked=0,ticket_num='" + MainForm.cpl.BookingNum + "' where date='" + DateText
                + "' and time='" + TimeText + "' and seat_num='" + label7.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
        }
        public void B4_label()
        {
            con.Open();
            string sql = "update seatInfo set booked=0,ticket_num='" + MainForm.cpl.BookingNum + "' where date='" + DateText
                + "' and time='" + TimeText + "' and seat_num='" + label8.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
        }
        public void B5_label()
        {
            con.Open();
            string sql = "update seatInfo set booked=0,ticket_num='" + MainForm.cpl.BookingNum + "' where date='" + DateText
                + "' and time='" + TimeText + "' and seat_num='" + label9.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
        }
        public void C1_label()
        {
            con.Open();
            string sql = "update seatInfo set booked=0,ticket_num='" + MainForm.cpl.BookingNum + "' where date='" + DateText
                + "' and time='" + TimeText + "' and seat_num='" + label10.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
        }
        public void C2_label()
        {
            con.Open();
            string sql = "update seatInfo set booked=0,ticket_num='" + MainForm.cpl.BookingNum + "' where date='" + DateText
                + "' and time='" + TimeText + "' and seat_num='" + label11.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
        }
        public void C3_label()
        {
            con.Open();
            string sql = "update seatInfo set booked=0,ticket_num='" + MainForm.cpl.BookingNum + "' where date='" + DateText
                + "' and time='" + TimeText + "' and seat_num='" + label12.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
        }
        public void C4_label()
        {
            con.Open();
            string sql = "update seatInfo set booked=0,ticket_num='" + MainForm.cpl.BookingNum + "' where date='" + DateText
                + "' and time='" + TimeText + "' and seat_num='" + label13.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
        }
        public void C5_label()
        {
            con.Open();
            string sql = "update seatInfo set booked=0,ticket_num='" + MainForm.cpl.BookingNum + "' where date='" + DateText
                + "' and time='" + TimeText + "' and seat_num='" + label14.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
        }
        public void D3_label()
        {
            con.Open();
            string sql = "update seatInfo set booked=0,ticket_num='" + MainForm.cpl.BookingNum + "' where date='" + DateText
                + "' and time='" + TimeText + "' and seat_num='" + label15.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
        }
        public void D4_label()
        {
            con.Open();
            string sql = "update seatInfo set booked=0,ticket_num='" + MainForm.cpl.BookingNum + "' where date='" + DateText
                + "' and time='" + TimeText + "' and seat_num='" + label16.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
        }
        public void D5_label()
        {
            con.Open();
            string sql = "update seatInfo set booked=0,ticket_num='" + MainForm.cpl.BookingNum + "' where date='" + DateText
                + "' and time='" + TimeText + "' and seat_num='" + label17.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
        }



        //좌석 선택시 라벨에 좌석번호 한개씩만 표시★
        public void SeatNo_label() {

            if (A1.BackColor == Color.Purple) { label1.Text = "A1"; } else { label1.Text = ""; }
            if (A2.BackColor == Color.Purple) { label2.Text = "A2"; } else { label2.Text = ""; }
            if (A3.BackColor == Color.Purple) { label3.Text = "A3"; } else { label3.Text = ""; }
            if (A4.BackColor == Color.Purple) { label4.Text = "A4"; } else { label4.Text = ""; }
            if (B1.BackColor == Color.Purple) { label5.Text = "B1"; } else { label5.Text = ""; }
            if (B2.BackColor == Color.Purple) { label6.Text = "B2"; } else { label6.Text = ""; }
            if (B3.BackColor == Color.Purple) { label7.Text = "B3"; } else { label7.Text = ""; }
            if (B4.BackColor == Color.Purple) { label8.Text = "B4"; } else { label8.Text = ""; }
            if (B5.BackColor == Color.Purple) { label9.Text = "B5"; } else { label9.Text = ""; }
            if (C1.BackColor == Color.Purple) { label10.Text = "C1"; } else { label10.Text = ""; }
            if (C2.BackColor == Color.Purple) { label11.Text = "C2"; } else { label11.Text = ""; }
            if (C3.BackColor == Color.Purple) { label12.Text = "C3"; } else { label12.Text = ""; }
            if (C4.BackColor == Color.Purple) { label13.Text = "C4"; } else { label13.Text = ""; }
            if (C5.BackColor == Color.Purple) { label14.Text = "C5"; } else { label14.Text = ""; }
            if (D3.BackColor == Color.Purple) { label15.Text = "D3"; } else { label15.Text = ""; }
            if (D4.BackColor == Color.Purple) { label16.Text = "D4"; } else { label16.Text = ""; }
            if (D5.BackColor == Color.Purple) { label17.Text = "D5"; } else { label17.Text = ""; }


        }

        //라벨에 적힌 좌석번호 리셋하는 함수★
        public void reset_label()
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
        } 

        //좌석 선택 메소드(★수정본)
        public void seat_Click(object sender, EventArgs e)
        {
            Label L = (Label)sender;


            if (MainForm.person > 0) //인원수가 있을때
            {
                if ((L != null) && (L.BackColor != Color.Purple))
                {
                    L.BackColor = (L.BackColor == SystemColors.ControlDark) ? Color.Purple : SystemColors.ControlDark;
                    if ((L.BackColor == Color.Purple) && (selectedSeats.Text == ""))
                    {
                        selectedSeats.Text += L.Name;
                        MainForm.person--;
                        ticket++;
                    }
                    else if ((L.BackColor == Color.Purple) && (selectedSeats.Text != ""))
                    {
                        selectedSeats.Text += "," + L.Name;
                        MainForm.person--;
                        ticket++;
                    }
                }
                else
                {
                    L.BackColor = SystemColors.ControlDark;
                    selectedSeats.Text = selectedSeats.Text.Replace(L.Name, "");
                    MainForm.person++;
                    ticket--;
                }
            }

            else if ((MainForm.person == 0) && (L.BackColor == Color.Purple))
            {
                L.BackColor = SystemColors.ControlDark;
                selectedSeats.Text = selectedSeats.Text.Replace(L.Name, "");
                MainForm.person++;
                ticket--;
            }
            //정해진 인원만큼 클릭했으면
            else { MessageBox.Show("좌석선택이 완료되었습니다."); }


            if (selectedSeats.Text == "")
            {

            }
            else if (selectedSeats.Text[0] == ',')
            {
                selectedSeats.Text = selectedSeats.Text.Substring(1);
            }

            else if (selectedSeats.Text[(selectedSeats.Text.Length) - 1] == ',')
            {
                selectedSeats.Text = selectedSeats.Text.Substring(0, selectedSeats.Text.Length - 1);
            }

            else if (selectedSeats.Text.Contains(",,"))
            {
                selectedSeats.Text = selectedSeats.Text.Replace(",,", ",");
            }


            Console.WriteLine("선택좌석 : " + selectedSeats.Text);
            selectedSeats.Text = selectedSeats.Text;

            Console.WriteLine("인원 수 : " + MainForm.person);
            money = ticket * aPrice;
            if (MainForm.person == 0)
            {
                money += MainForm.youth * yDis;
            }
            sum.Text = money.ToString();
            SeatNo_label(); //★라벨에 좌석넘버 표기하는 메소드

        }

        public int money = 0;

        //선택 표시 초기화 메소드
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

        //합계 금액 좌석번호 선택 초기화
        public void ssReset()
        {
            sum.Text = "";
            selectedSeats.Text = "";
        }


        //결제하기로 이동
        public void pay_Click(object sender, EventArgs e) 
        {
            //좌석선택수가 모자라면 이동불가
            if (MainForm.person != 0){ MessageBox.Show("좌석을 선택해주세요"); }
            else
            {
                if (!MainForm.Instance.pnlContainer.Controls.ContainsKey("uc5_addDis"))
                {
                    MainForm.aD.Dock = DockStyle.Fill;
                    MainForm.Instance.pnlContainer.Controls.Add(MainForm.aD);
                }
                //booked = selectedSeats.Text;
                MainForm.Instance.pnlContainer.Controls["uc5_addDis"].BringToFront();
                MainForm.aD.Sum = sum.Text;    //금액 uc5_addDis로 넘기기- 금액 주고받는 오류수정
                MainForm.aD.Total = sum.Text;
                MainForm.selected = selectedSeats.Text; //선택좌석 이름 넘기기
                MainForm.aD.Booking = selectedSeats.Text; //선택좌석 이름 넘기기
                //MainForm.page += 1;
                
                //MainForm.st.EndList.Items.Clear(); //uc4의 리스트를 초기화★test
            }
        }


        // 선택 초기화 하고 뒤로 가기
        private void back_Click(object sender, EventArgs e)
        {
            MainForm.Instance.pnlContainer.Controls["uc3_roundPeople"].BringToFront();
            ssReset();
            MainForm.person += ticket;
            ticket = 0;
            seatUnchk(); //선택표시 초기화
            reset_label(); //라벨번호 초기화
            MainForm.m1r.EndList2.Items.Clear(); //★uc2 좌석 리스트도 초기화
            uc3_roundPeople.rpInstance.Info.Text = "";
            uc3_roundPeople.rpInstance.Info_Y.Text = "";
            MainForm.adult = 0;  //uc3 인원수 초기화
            MainForm.youth = 0;
            MainForm.person = 0;
            MainForm.st.ticket = 0;
            uc3_roundPeople.rpInstance.setForeBackImageBtn();   //인원 선택 표시 초기화
            uc3_roundPeople.rpInstance.setForeBackImageBtn2();
            MainForm.Instance.pnlbtmContainer.BringToFront(); //바텀패널 보이기
        }
    }
}
