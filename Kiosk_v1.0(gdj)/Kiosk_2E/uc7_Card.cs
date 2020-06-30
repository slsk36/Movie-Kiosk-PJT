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
    public partial class uc7_Card : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=munggu.iptime.org,11113;Initial Catalog=KinoDB;Persist Security Info=True;User ID=sa;Password=8765432!");

        public uc7_Card()
        {
            InitializeComponent();
        }

        private void paidCard_Click(object sender, EventArgs e)
        {
            con.Open();

            DataTable dt = new DataTable();
            //
            string sql = "update roundPlan set seat=seat-" + (MainForm.adult + MainForm.youth)
                + " where movie='" + MainForm.m1r.Title
                + "' and time='" + MainForm.m1r.Time
                + "' and date='" + MainForm.m1r.Date + "'";
            //string sql = "update roundPlan set seat=seat-1 where movie='토르' and time='10:00' and date='2020-07-10'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(dt); //이거쓰면 쿼리 두번실행됨!!!!!!!!!

            con.Close();

            MainForm.Instance.pnlContainer.Controls.Add(MainForm.cpl);
            MainForm.Instance.pnlContainer.Controls["uc8_Complete"].BringToFront();
            


        }
    }
}
