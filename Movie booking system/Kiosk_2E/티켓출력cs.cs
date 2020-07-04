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
    public partial class 티켓출력cs : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=munggu.iptime.org,25000;Initial Catalog=KinoDB;Persist Security Info=True;User ID=sa;Password=8765432!");

        public 티켓출력cs()
        {
            InitializeComponent();
            MainForm.cancle.NotMath();  //티켓넘버조회해서 리스트박스에 넣기
            }

        private void num_click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            SetNum(numButton.Tag.ToString());
        }

        public bool isNewNum = true;
        public bool isStartNum = true;

        public void SetNum(String number) //자판입력함수
        {
            if (isNewNum)
            {
                if (isStartNum)
                {
                    input.Text = number;
                }
                else
                {
                    input.Text += number;
                }

                input.Text = number;
                isNewNum = false;
                isStartNum = false;
            }
            else
            {
                if (input.Text == "0")
                {
                    input.Text = number;
                }
                else
                {
                    input.Text = input.Text + number;
                }
            }
        }

        //home
        private void doneGoHome_Click(object sender, EventArgs e)
        {
            MainForm.Instance.pnlContainer.Controls.Add(MainForm.hm);
            MainForm.Instance.pnlContainer.Controls["uc0_Home"].BringToFront();
            this.SendToBack();
            MainForm.st.EndList.Items.Clear(); //uc4의 리스트를 초기화★
            MainForm.m1r.EndList2.Items.Clear(); //uc2의 리스트도 초기화★
            input.Text = "";//초기화
        }

        string res = "";

        private void del_Click(object sender, EventArgs e)
        {
            if (input.Text.Length > 0)
            {
                input.Text = input.Text.ToString().Remove(input.Text.Length - 1);
                res = input.Text;
            }
        }


        private void enter_Click(object sender, EventArgs e)
        {
            if (MainForm.cancle.RandomTicket.Items.Contains(input.Text))
            {
                //con.Open();
                //string sql = "select seat_num from seatInfo where ticket_num='" + input.Text + "'";
                ////seatinfo 테이블의 티켓넘버와 일치하는 좌석이 있으면
                //SqlCommand cmd = new SqlCommand(sql, con);
                //cmd.ExecuteNonQuery();
                //DataTable dt = new DataTable();
                //SqlDataAdapter da = new SqlDataAdapter(cmd);
                //da.Fill(dt);
                //con.Close();
                MessageBox.Show("티켓이 정상 출력 되었습니다.");
                input.Text = "";
            }
            else { MessageBox.Show("티켓넘버를 다시 확인하세요"); }
        }

        
    }
}
