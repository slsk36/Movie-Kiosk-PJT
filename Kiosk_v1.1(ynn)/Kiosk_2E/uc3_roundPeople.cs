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
        //숫자 이미지 리소스 가져오기 위해 선언
        //System.ComponentModel.ComponentResourceManager resources
        //    = new System.ComponentModel.ComponentResourceManager(typeof(uc3_roundPeople));



        public uc3_roundPeople()
        {
            InitializeComponent();
            MainForm.Instance.GoBack = Properties.Resources.turn_back_50px; //★메인 패널의 뒤로가기 보여주기★
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
            else
            {
                if (!MainForm.Instance.pnlContainer.Controls.ContainsKey("uc4_Seat"))
                {
                    MainForm.st.Dock = DockStyle.Fill;
                    MainForm.Instance.pnlContainer.Controls.Add(MainForm.st);
                }
                MainForm.Instance.pnlContainer.Controls["uc4_Seat"].BringToFront();
                MainForm.st.reset_Click(sender, e);
                MainForm.page += 1;
                MainForm.selected = "";
                MainForm.st.ticket = 0;

                

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



        // 의리 단결 투지 용기

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

    }
}
