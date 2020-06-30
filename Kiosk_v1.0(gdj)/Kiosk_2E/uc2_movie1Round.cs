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
        SqlConnection con = new SqlConnection("Data Source=munggu.iptime.org,11113;Initial Catalog=KinoDB;Persist Security Info=True;User ID=sa;Password=8765432!");

        public uc2_movie1Round()
        {
            InitializeComponent();
            fillCombobox();
            fillPbMovie();
            
        }

        // ★uc1과 이미지 및 텍스트 연결★
        public Image Movieposter { get { return pbMovie.Image; } set { pbMovie.Image = value; } } //포스터
        public string Title { get { return movieTitle.Text; } set { movieTitle.Text = value; } } //영화제목
        public string Date { get { return cbDate.Text; } set { cbDate.Text = value; } } //날짜
        public string Time { get { return cbRound.Text; } set { cbRound.Text = value; } } //시간
                                                                                          //----------------------------------------------
        //그림 가져오기
        public void fillPbMovie()
        {
            


        }
        //날짜 콤보박스 채우기
        public void fillCombobox()
        {
            cbDate.Items.Clear();
            cbRound.Items.Clear();
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
            cbRound.Items.Clear();
            con.Open();
            string sql = "select distinct time from roundPlan where date='" + Date + "' and movie='" + Title + "'";
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


        //시간 클릭하면 해당영화의 날짜에 시간에 해당하는 예매가능한 좌석수 표시
        private void cbRound_SelectedIndexChanged(object sender, EventArgs e)
        {

            con.Open();
            string sql = "select seat from roundPlan where date='" + Date
                + "' and movie='" + Title + "' and time='" + Time + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                leftStNm.Text = row["seat"].ToString();
            }
            con.Close();
        }


        //좌석 선택 페이지로 이동
        private void goSelectSeat_Click(object sender, EventArgs e)
        {
            if (cbDate.Text == "관람일자" || cbRound.Text == "시간선택")
            {
                MessageBox.Show("날짜와 시간을 선택하세요");
            }
            else if (leftStNm.Text == "0")
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
                MainForm.page += 1;
            }
        }
    }
}
