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
    public partial class 환불 : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=munggu.iptime.org,25000;Initial Catalog=KinoDB;Persist Security Info=True;User ID=sa;Password=8765432!");
        
        //public int Result = 0;
        public bool isNewNum = true;
        public bool isStartNum = true;
        //public Operators Opt = Operators.Add;
        public ListBox RandomTicket { get { return listBox1; }set {listBox1=value; } }

        public 환불()
        {
            InitializeComponent();
            listBox1.Visible = false; //리스트 박스는 티켓넘버가 담겨있으므로 안보이게
            textBox1.Text = "";//초기화
        }


        private void doneGoHome_Click(object sender, EventArgs e) //처음으로
        {
            MainForm.Instance.pnlContainer.Controls.Add(MainForm.hm);
            MainForm.Instance.pnlContainer.Controls["uc0_Home"].BringToFront();
            this.SendToBack();
            MainForm.st.EndList.Items.Clear(); //uc4의 리스트를 초기화★
            MainForm.m1r.EndList2.Items.Clear(); //uc2의 리스트도 초기화★
            textBox1.Text = "";//초기화
        }

        private void num_click(object sender, EventArgs e) //숫자버튼 클릭하면
        {
            Button numButton = (Button)sender;
            SetNum(numButton.Text);
        }

        public void SetNum(String number) //자판입력함수
        {
            if (isNewNum)
            {
                if (isStartNum)
                {
                    textBox1.Text = number;
                }
                else
                {
                    textBox1.Text += number;
                }

                textBox1.Text = number;
                isNewNum = false;
                isStartNum = false;
            }
            else
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = number;
                }
                else
                {
                    textBox1.Text = textBox1.Text + number;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e) //초기화
        {
            textBox1.Text = "";
        }

        public void NotMath() { //티켓넘버조회해서 리스트박스에 넣기

            listBox1.Items.Clear();
            con.Open();
            string sql = "select distinct ticket_num from seatInfo where ticket_num is not null;";
            //seatinfo 테이블의 티켓넘버가 null이 아닌 티켓넘버를 조회해서 리스트 박스에 넣기
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow row in dt.Rows)
            {
                listBox1.Items.Add(row["ticket_num"].ToString());
            }
        
            con.Close();
        }

        public string a;
        public string b;
        public string c;

        public void seatDateTime()
        {
            MainForm.m1r.payback();
            con.Open();
            string sql = "select seat_num,date,time from seatInfo where ticket_num='" + textBox1.Text + "'";
            //입력한 숫자와 일치하는 자리번호와 날짜와 시간을 조회해라
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            string result = "";

            foreach (DataRow row in dt.Rows)
            {
                foreach (var input_items in row["seat_num"].ToString())
                {
                    result += string.Format("{0}", input_items);
                }
                a = result;
                b = row["date"].ToString();
                c = row["time"].ToString();
            }
            con.Close();
        }

        //입력버튼
        private void input_Click(object sender, EventArgs e) //입력버튼
        {
            seatDateTime();
            if (listBox1.Items.Contains(textBox1.Text))
            {
                MainForm.m1r.payback();
                con.Open();
                string sql = "update seatInfo set booked=1,ticket_num=null where ticket_num='" + textBox1.Text + "'";
                //seatinfo 테이블의 티켓넘버와 일치하는 예약을 취소하고 티켓넘버를 null로 바꿔라
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                textBox1.Text = "";
                MessageBox.Show($"{b} {c}시 좌석: {a} 환불완료 되었습니다.");
            }
            else { MessageBox.Show("티켓넘버가 잘못되었습니다"); }
               
            }
        }
    }

