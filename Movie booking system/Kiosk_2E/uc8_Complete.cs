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
    public partial class uc8_Complete : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=munggu.iptime.org,25000;Initial Catalog=KinoDB;Persist Security Info=True;User ID=sa;Password=8765432!");

        public string BookingNum { get { return bookingNum.Text; } set { bookingNum.Text = value; } }

        public uc8_Complete()
        {
            InitializeComponent();
        }

        //예약완료에 한해 티켓넘버 랜덤 생성(배열 아니므로 의미없음 중복제거 실패)
        public void ticket_num(int length, int min, int max) {

            Random rand = new Random();
            //int num = rand.Next(1000, 10000);

            int[] num = new int[length];
            bool isSame;
            for (int i = 0; i < length; ++i)
            {
                while (true)
                {
                    num[i] = rand.Next(min, max);
                    isSame = false;

                    for (int j = 0; j < i; ++j)
                    {
                        if (num[j] == num[i])
                        {
                            isSame = true;
                            break;
                        }
                    }
                    if (!isSame) break;
                }
            }
            //return num;
            BookingNum = string.Concat(num);
        }

        //uc4 라벨에 적힌대로 예약완료상태로 바꿔라
        public void booked_end()
        { 
            MainForm.st.A1_label(); 
            MainForm.st.A2_label();
            MainForm.st.A3_label();
            MainForm.st.A4_label();
            MainForm.st.B1_label();
            MainForm.st.B2_label();
            MainForm.st.B3_label();
            MainForm.st.B4_label();
            MainForm.st.B5_label();
            MainForm.st.C1_label();
            MainForm.st.C2_label();
            MainForm.st.C3_label();
            MainForm.st.C4_label();
            MainForm.st.C5_label();
            MainForm.st.D3_label();
            MainForm.st.D4_label();
            MainForm.st.D5_label();
            MainForm.st.reset_label(); //좌석번호 라벨텍스트 모두 리셋★
        }

        //처음으로
        private void doneGoHome_Click(object sender, EventArgs e)
        {
            booked_end();//uc4 라벨에 적힌대로 예약완료상태로 바꿔라
            MainForm.cancle.NotMath();  //티켓넘버조회해서 리스트박스에 넣기
            MainForm.Instance.pnlContainer.Controls.Add(MainForm.hm);
            MainForm.Instance.pnlContainer.Controls["uc0_Home"].BringToFront();
            this.SendToBack();
            uc3_roundPeople.rpInstance.Info.Text = ""; //성인 수 텍스트박스 초기화
            uc3_roundPeople.rpInstance.Info_Y.Text = ""; //학생 수 텍스트박스 초기화

            MainForm.adult = 0;  //인원수 초기화
            MainForm.youth = 0;
            MainForm.person = 0;
            MainForm.st.ticket = 0;
            MainForm.aD.Dis = "";
            MainForm.aD.Total = "";
            MainForm.selected = "";

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
            MainForm.st.seatUnchk();
            MainForm.st.ssReset();
            MainForm.st.reset_label();//라벨에 적힌 좌석번호 리셋

            MainForm.st.EndList.Items.Clear(); //uc4의 리스트를 초기화★
            MainForm.m1r.EndList2.Items.Clear(); //uc2의 리스트도 초기화★

        }

        
    }
}
