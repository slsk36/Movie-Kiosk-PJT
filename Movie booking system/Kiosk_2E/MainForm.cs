using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk_2E
{
    public partial class MainForm : Form
    {
        //public static int page = 0; //뒤로 가기를 위한 페이지수
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
        public static 환불 cancle = new 환불();    //결제완료 화면
        public static 티켓출력cs ticket = new 티켓출력cs();

        public MainForm()
        {
            InitializeComponent();
            _obj = this;
            _obj.mainPanel.Controls.Add(hm);     //홈 화면 표시
            hm.BringToFront();
            this.CenterToScreen();

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
        // mainPanel 접근값 부여
        public Panel pnlContainer { get { return mainPanel; }  set { mainPanel = value; } }
        // bottomPanel 접근값 부여
        public Panel pnlbtmContainer { get { return bottomPanel; } set { bottomPanel = value; } }
        
        
        //홈
        public void goHome_Click(object sender, EventArgs e)
        {
            MainForm.Instance.pnlContainer.Controls.Add(MainForm.hm);
            MainForm.Instance.pnlContainer.Controls["uc0_Home"].BringToFront();
            uc3_roundPeople.rpInstance.Info.Text = ""; //성인 수 텍스트박스 초기화
            uc3_roundPeople.rpInstance.Info_Y.Text = ""; //학생 수 텍스트박스 초기화

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

            //★uc2에서 선택한 정보 모두 초기화
            MainForm.m1r.Date = "상영일자"; //상영일자 초기화
            MainForm.m1r.Time = "시간선택"; //시간선택 초기화
            MainForm.m1r.Movieposter = null; //영화 포스터 초기화
            MainForm.m1r.Title = ""; //영화제목 초기화
            MainForm.m1r.LeftSeat = "";  //남은 좌석 글자 초기화

            //★uc4좌석 선택 및 표시 초기화
            st.seatUnchk();
            st.ssReset();
            st.reset_label();//라벨에 적힌 좌석번호 리셋
        }

        //나가기
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}