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


    public partial class uc3_roundPeople : UserControl
    {
        //public string DateText { get { return date.Text; } set { date.Text=value; } }
        //public string TimeText { get { return time.Text; } set { time.Text = value; } }
        //public string EndList_uc2 { get { return textBox1.Text; } set { textBox1.Text = value; } } //uc2의 텍스트박스를 초기화하기 위해 테스트


        public uc3_roundPeople()
        {
            InitializeComponent();
            MainForm.Instance.pnlbtmContainer.BringToFront(); //바텀 패널 앞으로 나오게하기
            
        }

        static uc3_roundPeople rp_obj;           // 객체명 선언(?)

        public static uc3_roundPeople rpInstance // 생성된 메인 객체(?)
        {
            get
            {
                if (rp_obj == null)
                {
                    rp_obj = new uc3_roundPeople();
                }
                return rp_obj;
            }
        }

        //선택 완료 버튼
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (MainForm.adult == 0 && MainForm.youth == 0) //성인 청소년 둘다 0명이면
            {
                MessageBox.Show("인원을 선택하세요");
            }
            else if ((MainForm.adult+MainForm.youth) > int.Parse(MainForm.m1r.LeftSeat))
            { //★person 값을 넣으면 인원이+1이 되는 오류발생

                MessageBox.Show("선택할 수 있는 인원을 초과하였습니다");
            }
            else
            {
                if (!MainForm.Instance.pnlContainer.Controls.ContainsKey("uc4_Seat"))
                {
                    MainForm.st.Dock = DockStyle.Fill;
                    MainForm.Instance.pnlContainer.Controls.Add(MainForm.st);
                }
                MainForm.Instance.pnlContainer.Controls["uc4_Seat"].BringToFront();
                //MainForm.st.reset_Click(sender, e);
                //MainForm.page += 1;
                //MainForm.selected = "";
                //MainForm.st.ticket = 0;
                MainForm.m1r.UC4();  //★uc2의 리스트 박스(예매완료된 좌석)를 uc4로 넘김// db연결 코드
                MainForm.st.NotBook();//★uc4 예매완료 좌석 선택불가 버튼


            }
        }

        //뒤로가기 및 홈버튼 사용시 접근을 위한 변수 선언
        public string InfoT { get; set; }
        public string InfoT_Y { get; set; }

        
        //성인 인원 수 선택 함수
        private void btnPs_Click(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            if (InfoT != "")
            {
                PictureBox btn2 = (PictureBox)sender;
                InfoT = btn2.Tag.ToString();
            }
            else { InfoT = btn.Tag.ToString(); }
            //버튼의 값 받아옴

            Info.Text = InfoT;  //출력창에 버튼의 tag값 text로 변경
            MainForm.adult = Convert.ToInt32(Info.Text); //adult값 정수로 변환
            MainForm.person = MainForm.adult + MainForm.youth;
        }


        //청소년 인원 수 선택 함수
        private void btnYt_Click(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            if (InfoT_Y != "")
            {
                PictureBox btn2 = (PictureBox)sender;
                InfoT_Y = btn2.Tag.ToString();
            }
            else { InfoT_Y = btn.Tag.ToString(); }
            //버튼의 값 받아옴
            Info_Y.Text = InfoT_Y;    //출력창에 버튼의 tag값 text로 변경
            MainForm.youth = Convert.ToInt32(Info_Y.Text);   //youth값 정수로 변환
            MainForm.person = MainForm.adult + MainForm.youth;
        }




        //흰색 버튼 모두 앞으로 나오는 함수
        public void setForeBackImageBtn()
        {
            rpInstance.a1.Image = Properties.Resources._1_unchk_26px;
            rpInstance.a2.Image = Properties.Resources._2_unchk_26px;
            rpInstance.a3.Image = Properties.Resources._3_unchk_26px;
            rpInstance.a4.Image = Properties.Resources._4_unchk_26px;
            rpInstance.a5.Image = Properties.Resources._5_unchk_26px;
            rpInstance.a6.Image = Properties.Resources._6_unchk_26px;
        }

        public void setForeBackImageBtn2()
        {
            rpInstance.y1.Image = Properties.Resources._1_unchk_26px;
            rpInstance.y2.Image = Properties.Resources._2_unchk_26px;
            rpInstance.y3.Image = Properties.Resources._3_unchk_26px;
            rpInstance.y4.Image = Properties.Resources._4_unchk_26px;
            rpInstance.y5.Image = Properties.Resources._5_unchk_26px;
            rpInstance.y6.Image = Properties.Resources._6_unchk_26px;
            
        }


        

        //클릭할 때마다 버튼 색 바뀌면서 인원수 전달 (성인)
        private void a1_Click(object sender, EventArgs e)
        {

            // 해제
            if (InfoT == "1")
            {
                setForeBackImageBtn();
                rpInstance.a1.Image = Properties.Resources._1_unchk_26px;
                btnPs_Click(sender, e);
                MainForm.adult = 0;
                Info.Text = "";
                InfoT = "0";

            }
            
            // 선택
            else
            {
                setForeBackImageBtn();
                rpInstance.a1.Image = Properties.Resources._1_chk_26px;
                btnPs_Click(sender, e);
            }
        }

        private void a2_Click(object sender, EventArgs e)
        {
            if (InfoT == "2")
            {
                setForeBackImageBtn();
                rpInstance.a2.Image = Properties.Resources._2_unchk_26px;
                btnPs_Click(sender, e);
                MainForm.adult = 0;
                Info.Text = "";
                InfoT = "0";
            }

            else
            {
                setForeBackImageBtn();
                rpInstance.a2.Image = Properties.Resources._2_chk_26px;
                btnPs_Click(sender, e);
            }
        }

        private void a3_Click(object sender, EventArgs e)
        {
            if (InfoT == "3")
            {
                setForeBackImageBtn();
                rpInstance.a3.Image = Properties.Resources._3_unchk_26px;
                btnPs_Click(sender, e);
                MainForm.adult = 0;
                Info.Text = "";
                InfoT = "0";
            }

            else
            {
                setForeBackImageBtn();
                rpInstance.a3.Image = Properties.Resources._3_chk_26px;
                btnPs_Click(sender, e);
            }
        }

        private void a4_Click(object sender, EventArgs e)
        {
            if (InfoT == "4")
            {
                setForeBackImageBtn();
                rpInstance.a4.Image = Properties.Resources._4_unchk_26px;
                btnPs_Click(sender, e);
                MainForm.adult = 0;
                Info.Text = "";
                InfoT = "0";
            }

            else
            {
                setForeBackImageBtn();
                rpInstance.a4.Image = Properties.Resources._4_chk_26px;
                btnPs_Click(sender, e);
            }
        }

        private void a5_Click(object sender, EventArgs e)
        {
            if (InfoT == "5")
            {
                setForeBackImageBtn();
                rpInstance.a5.Image = Properties.Resources._5_unchk_26px;
                btnPs_Click(sender, e);
                MainForm.adult = 0;
                Info.Text = "";
                InfoT = "0";
            }

            else
            {
                setForeBackImageBtn();
                rpInstance.a5.Image = Properties.Resources._5_chk_26px;
                btnPs_Click(sender, e);
            }
        }

        private void a6_Click(object sender, EventArgs e)
        {
            if (InfoT == "6")
            {
                setForeBackImageBtn();
                rpInstance.a6.Image = Properties.Resources._6_unchk_26px;
                btnPs_Click(sender, e);
                MainForm.adult = 0;
                Info.Text = "";
                InfoT = "0";
            }

            else
            {
                setForeBackImageBtn();
                rpInstance.a6.Image = Properties.Resources._6_chk_26px;
                btnPs_Click(sender, e);
            }
        }


        //클릭할때마다 검은버튼으로 이미지 전환 (청소년)
        private void y1_Click(object sender, EventArgs e)
        {
            if (InfoT_Y == "1")
            {
                setForeBackImageBtn2();
                rpInstance.y1.Image = Properties.Resources._1_unchk_26px;
                btnYt_Click(sender, e);
                MainForm.youth = 0;
                Info_Y.Text = "";
                InfoT_Y = "0";
            }
            else
            {
                setForeBackImageBtn2();
                rpInstance.y1.Image = Properties.Resources._1_chk_26px;
                btnYt_Click(sender, e);
            }
        }

        private void y2_Click(object sender, EventArgs e)
        {
            if (InfoT_Y == "2")
            {
                setForeBackImageBtn2();
                rpInstance.y2.Image = Properties.Resources._2_unchk_26px;
                btnYt_Click(sender, e);
                MainForm.youth = 0;
                Info_Y.Text = "";
                InfoT_Y = "0";
            }
            else
            {
                setForeBackImageBtn2();
                rpInstance.y2.Image = Properties.Resources._2_chk_26px;
                btnYt_Click(sender, e);
            }
        }

        private void y3_Click(object sender, EventArgs e)
        {
            if (InfoT_Y == "3")
            {
                setForeBackImageBtn2();
                rpInstance.y3.Image = Properties.Resources._3_unchk_26px;
                btnYt_Click(sender, e);
                MainForm.youth = 0;
                Info_Y.Text = "";
                InfoT_Y = "0";
            }
            else
            {
                setForeBackImageBtn2();
                rpInstance.y3.Image = Properties.Resources._3_chk_26px;
                btnYt_Click(sender, e);
            }
        }

        private void y4_Click(object sender, EventArgs e)
        {
            if (InfoT_Y == "4")
            {
                setForeBackImageBtn2();
                rpInstance.y4.Image = Properties.Resources._4_unchk_26px;
                btnYt_Click(sender, e);
                MainForm.youth = 0;
                Info_Y.Text = "";
                InfoT_Y = "0";
            }
            else
            {
                setForeBackImageBtn2();
                rpInstance.y4.Image = Properties.Resources._4_chk_26px;
                btnYt_Click(sender, e);
            }
        }

        private void y5_Click(object sender, EventArgs e)
        {
            if (InfoT_Y == "5")
            {
                setForeBackImageBtn2();
                rpInstance.y5.Image = Properties.Resources._5_unchk_26px;
                btnYt_Click(sender, e);
                MainForm.youth = 0;
                Info_Y.Text = "";
                InfoT_Y = "0";
            }
            else
            {
                setForeBackImageBtn2();
                rpInstance.y5.Image = Properties.Resources._5_chk_26px;
                btnYt_Click(sender, e);
            }
        }

        private void y6_Click(object sender, EventArgs e)
        {
            if (InfoT_Y == "6")
            {
                setForeBackImageBtn2();
                rpInstance.y6.Image = Properties.Resources._6_unchk_26px;
                btnYt_Click(sender, e);
                MainForm.youth = 0;
                Info_Y.Text = "";
                InfoT_Y = "0";
            }
            else
            {
                setForeBackImageBtn2();
                rpInstance.y6.Image = Properties.Resources._6_chk_26px;
                btnYt_Click(sender, e);
            }
        }
        //뒤로가기
        private void back_Click(object sender, EventArgs e)
        {
            MainForm.Instance.pnlContainer.Controls["uc2_movie1Round"].BringToFront();
            MainForm.adult = 0;  //uc3 초기화
            MainForm.youth = 0;  //uc3 초기화
            rpInstance.Info.Text = ""; //성인 수 텍스트박스 초기화
            rpInstance.Info_Y.Text = ""; //학생 수 텍스트박스 초기화
            rpInstance.setForeBackImageBtn();   //성인 인원 선택 표시 초기화
            rpInstance.setForeBackImageBtn2();  //학생 인원 선택 표시 초기화
            MainForm.m1r.Date = "상영일자"; //uc2 상영일자 초기화
            MainForm.m1r.Time = "시간선택"; //uc2 시간선택 초기화
            MainForm.m1r.LeftSeat = "";  //uc2 잔여좌석 글자 초기화
            //MainForm.st.reset_Click(sender, e); //uc4 모두 초기화★
            //MainForm.st.NotNotBook(); // uc4 예매완료좌석 초기화★
        }
    }
}
