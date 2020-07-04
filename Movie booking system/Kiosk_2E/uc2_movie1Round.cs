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
    public partial class uc2_movie1Round : UserControl
    {

        SqlConnection con = new SqlConnection("Data Source=munggu.iptime.org,25000;Initial Catalog=KinoDB;Persist Security Info=True;User ID=sa;Password=8765432!");


        // ★uc1과 이미지 및 텍스트 연결★
        public Image Movieposter { get { return pbMovie.Image; } set { pbMovie.Image = value; } } //포스터
        public string Title { get { return movieTitle.Text; } set { movieTitle.Text = value; } } //영화제목
        public string Date { get { return cbDate.Text; } set { cbDate.Text = value; } } //날짜
        public string Time { get { return cbRound.Text; } set { cbRound.Text = value; } } //시간
        public string LeftSeat { get { return leftStNm.Text; } set { leftStNm.Text = value; } } //남은 좌석수
        public ListBox EndList2 { get { return listBox1; } set { listBox1 = value; } } //★uc4의 리스트박스와 연동하기


        public uc2_movie1Round()
        {
            InitializeComponent();
            fillCombobox();
            listBox1.Visible = false; //테스트용 예매완료된 좌석리스트
            
        }

       

        //날짜 콤보박스 채우기
        public void fillCombobox()
        {
            //cbRound.Items.Clear();
            cbDate.Items.Clear();
            con.Open();
            string sql = "select distinct date from movieInfo";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                cbDate.Items.Add(row["date"].ToString());
            }
            con.Close();
        }

        //날짜를 클릭했을때 시간 선택
        private void cbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            leftStNm.Text = ""; //날짜를 클릭할 때마다 남은 좌석수를 비워줘서 오선택 방지
            cbRound.Items.Clear();
            con.Open();
            string sql = "select distinct time from roundPlan where date='" + Date
                + "' and movie='" + Title + "'";
            //MessageBox.Show("sql =" +sql); //★sql문 디버깅 하는 코드
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                cbRound.Items.Add(row["time"].ToString());
            }

            con.Close();
        }


        //시간 클릭하면 해당영화의 날짜에 시간에 해당하는 예매가능한 좌석수와 좌석리스트 표시
        private void cbRound_SelectedIndexChanged(object sender, EventArgs e)
        {
            leftStNm.Text = "";
            con.Open();
            //string sql = "select seat from roundPlan where date='" + Date
            //    + "' and movie='" + Title + "' and time='" + Time + "'";//예매가능한 좌석수
            string sql="select count(booked) as cnt from seatInfo where booked=1 and date='" + Date + "' and time='" + Time
                + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                //leftStNm.Text = row["seat"].ToString();
                leftStNm.Text = row["cnt"].ToString();
            }
            con.Close();
            UC4(); //좌석 리스트
            //personBack(); //남은 좌석 수 표시
        }


        //★환불 인원수 복원 환불페이지에서
        public void payback()
        {
            con.Open();
            DataTable dt = new DataTable();
            string sql = "update roundPlan set seat='" + leftStNm.Text + "' where movie='" + Title
                + "' and time='" + Time
                + "' and date='" + Date + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Close();
        }

        //★날짜와 시간에 해당하는 예매 완료된 좌석리스트 가져오기
        public void UC4()
        {
            listBox1.Items.Clear(); //선택이 바뀌면 초기화
            con.Open();
            string sql = "select seat_num from seatInfo where date='" + Date
                + "' and time='" + Time + "' and booked=0";   //예매완료(0)인 좌석의 번호를 가져와라
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                listBox1.Items.Add(row["seat_num"].ToString()); //예매완료된 좌석 리스트
            }
            con.Close();
        }


        //★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★
        //리스트박스의 아이템을 텍스트박스에 넣는 함수
        //private void button4_Click() {
        //    string result = "";
        //    foreach (var input_items in listBox1.Items) {
        //        result += string.Format("{0} ", input_items);
        //    }
        //    TextBox1.text = result; }
        //★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★




        //다음 좌석 선택 페이지로 이동
        private void goSelectSeat_Click(object sender, EventArgs e)
        {
            if (cbDate.Text == "관람일자" || cbRound.Text == "시간선택")
            {
                MessageBox.Show("날짜와 시간을 선택하세요");
            }
            else if (int.Parse(leftStNm.Text) <= 0) //★버그수정
            {
                MessageBox.Show("매진되었습니다");
            }
            else
            {
                if (!MainForm.Instance.pnlContainer.Controls.ContainsKey("uc3_roundPeople.rpInstance"))
                {
                    uc3_roundPeople rpInstance = new uc3_roundPeople();
                    rpInstance.Dock = DockStyle.Fill;
                    MainForm.Instance.pnlContainer.Controls.Add(uc3_roundPeople.rpInstance);
                }
                uc3_roundPeople.rpInstance.BringToFront();
                MainForm.Instance.pnlbtmContainer.BringToFront();
                MainForm.st.EndList = listBox1; //★uc4에다가 리스트박스 집어넣기
                MainForm.st.DateText = Date; //★uc4에 text 집어넣기
                MainForm.st.TimeText = Time;
                //MainForm.page += 1;
                UC4();//★날짜와 시간에 해당하는 예매 완료된 좌석번호 가져오기
               





            }
        }


        //뒤로가기
        private void button1_Click(object sender, EventArgs e)
        {
            MainForm.Instance.pnlContainer.Controls["uc1_movieList"].BringToFront();
            cbDate.Text = "상영일자";
            cbRound.Text = "시간선택";
            pbMovie.Image = null;
            leftStNm.Text = "";  //남은 좌석 글자 초기화
            Title = null;  //영화이름 초기화
            //MainForm.Instance.pnlbtmContainer.BringToFront(); //바텀 패널 앞으로 나오게하기
        }

        
    }
}
