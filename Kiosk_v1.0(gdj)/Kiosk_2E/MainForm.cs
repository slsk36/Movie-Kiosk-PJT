using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk_2E
{
    public partial class MainForm : Form
    {
        public static int page = 0; //뒤로 가기를 위한 페이지수
        public static int adult = 0; //성인수
        public static int youth = 0; //청소년 수
        public static int person = 0; //총 인원수
        public static string selected = "";    //선택좌석

        public static uc0_Home hm = new uc0_Home(); //홈 화면
        public static uc1_movieList mchoice = new uc1_movieList(); //영화 선택 화면
        public static uc2_movie1Round m1r = new uc2_movie1Round(); //회차 선택 화면
        public static uc3_roundPeople rp = new uc3_roundPeople(); //인원 선택 화면
        public static uc4_Seat st = new uc4_Seat(); //좌석 선택 화면
        public static uc5_addDis aD = new uc5_addDis(); //추가할인 화면
        public static uc5w_selectTel slt = new uc5w_selectTel(); //통신사 선택 화면
        public static uc6_payment pmt = new uc6_payment();  //결제수단 선택 화면
        public static uc7_Card cc = new uc7_Card(); //신용카드 삽입 요청 화면
        public static uc7_Kakao kp = new uc7_Kakao();   //카카오페이 QR코드 화면
        public static uc8_Complete cpl = new uc8_Complete();    //결제완료 화면


        private void WriteLog(string contents) //로그파일을 만들어서 수정내역 추적
        {
            string logContents = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}] {contents}";
            LogWrite.PrintLog(logContents);
        }

        public MainForm()
        {            
            InitializeComponent();
            _obj = this;
            _obj.mainPanel.Controls.Add(hm);     //홈 화면 표시
            hm.BringToFront();
        }

        static MainForm _obj;           // 객체명 선언(?)

        public static MainForm Instance // 생성된 메인 객체(?)
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new MainForm();
                }
                return _obj;
            }
        }

        public Panel pnlContainer  // mainPanel 접근값 부여
        {
            get { return mainPanel; }
            set { mainPanel = value; }
        }

        public Panel pnlbtmContainer  // bottomPanel 접근값 부여
        {
            get { return bottomPanel; }
            set { bottomPanel = value; }
        }


        private void goBack_Click(object sender, EventArgs e)   //뒤로가기
        {
            switch (page)
            {
                case 1:
                    hm.BringToFront();
                    page -= 1;
                    break;

                case 2:
                    MainForm.mchoice.BringToFront();
                    page -= 1;
                    break;

                case 3:
                    MainForm.Instance.pnlContainer.Controls["uc2_movie1Round"].BringToFront();
                    page -= 1;
                    break;

                case 4:
                    uc3_roundPeople.rpInstance.Info.Text = "";
                    uc3_roundPeople.rpInstance.Info_Y.Text = "";

                    adult = 0;  //인원수 초기화
                    youth = 0;
                    person = 0;
                    MainForm.st.ticket = 0;

                    uc3_roundPeople.rpInstance.setForeBackImageBtn();   //인원 선택 표시 초기화
                    uc3_roundPeople.rpInstance.setForeBackImageBtn2();

                    uc3_roundPeople.rpInstance.InfoT = "";
                    uc3_roundPeople.rpInstance.InfoT_Y = "";

                    uc3_roundPeople.rpInstance.BringToFront();
                    MainForm.Instance.pnlbtmContainer.BringToFront();
                    page -= 1;
                    break;

                case 5:
                    st.reset_Click(sender, e);
                    MainForm.st.ticket = 0;
                    MainForm.aD.Dis = "";
                    MainForm.aD.Total = "";
                    selected = "";
                    MainForm.Instance.pnlContainer.Controls["uc4_Seat"].BringToFront();
                    page -= 1;
                    break;

                case 6:
                    MainForm.Instance.pnlContainer.Controls["uc5_addDis"].BringToFront();
                    page -= 1;
                    MainForm.pmt.disDetail.Text = "";
                    MainForm.aD.Dis = "";
                    MainForm.aD.Total = MainForm.st.sum.Text;
                    break;

                case 7:
                    MainForm.Instance.pnlContainer.Controls["uc6_payment"].BringToFront();
                    page -= 1;
                    break;
            }
        }

        public static void goHome_Click(object sender, EventArgs e)   //홈 버튼
        {
            uc3_roundPeople.rpInstance.Info.Text = "";
            uc3_roundPeople.rpInstance.Info_Y.Text = "";

            adult = 0;  //인원수 초기화
            youth = 0;
            person = 0;
            MainForm.st.ticket = 0;
            MainForm.aD.Dis = "";
            MainForm.aD.Total = "";
            selected = "";

            uc3_roundPeople.rpInstance.setForeBackImageBtn();   //인원 선택 표시 초기화
            uc3_roundPeople.rpInstance.setForeBackImageBtn2();

            uc3_roundPeople.rpInstance.InfoT = "";
            uc3_roundPeople.rpInstance.InfoT_Y = "";
            MainForm.pmt.disDetail.Text = "";


            //좌석 선택 및 표시 초기화
            st.seatUnchk();
            st.ssReset();


            hm.BringToFront();
            page = 0;
        }


    }
}
