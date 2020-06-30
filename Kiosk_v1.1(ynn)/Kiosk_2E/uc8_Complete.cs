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
        //SqlConnection con = new SqlConnection("Data Source=munggu.iptime.org,11113;Initial Catalog=KinoDB;Persist Security Info=True;User ID=sa;Password=8765432!");

        public uc8_Complete()
        {
            InitializeComponent();
        }

        private void doneGoHome_Click(object sender, EventArgs e)
        {

            MainForm.goHome_Click(sender, e);
            this.SendToBack();


            //아래 데이터베이스 연결구문은 7페이지-1,2로 넘겼습니다★★★★★★★★★★★★★
            
            //con.Open();
            //DataTable dt = new DataTable();
            ////
            //string sql = "update roundPlan set seat=seat-" + MainForm.person
            //    + " where movie='" + MainForm.m1r.Title
            //    + "' and time='" + MainForm.m1r.Time
            //    + "' and date='" + MainForm.m1r.Date + "'";
            ////string sql = "update roundPlan set seat=seat-1 where movie='토르' and time='10:00' and date='2020-07-10'";
            //SqlCommand cmd = new SqlCommand(sql, con);
            //cmd.ExecuteNonQuery();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            ////da.Fill(dt); //이거쓰면 쿼리 두번실행됨!!!!!!!!!
            //con.Close();
            //if (!Main.Instance.pnlContainer.Controls.ContainsKey("UserControl1"))
            //{
            //    Main.uc1.Dock = DockStyle.Fill;
            //    Main.Instance.pnlContainer.Controls.Add(Main.uc1);
            //}
            //Main.Instance.pnlContainer.Controls["UserControl1"].BringToFront();


        }
    }
}
