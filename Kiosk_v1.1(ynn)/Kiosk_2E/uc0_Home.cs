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

    public partial class uc0_Home : UserControl
    {
        public uc0_Home()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer2.Interval = 1000;
            timer1.Start();
            timer2.Start();
            
        }

        private void buyTicket_Click(object sender, EventArgs e)
        {
            MainForm.hm.SendToBack();         // 홈 화면 숨기기
            

            MainForm.mchoice.Show();    // 영화 선택 화면 표시
            MainForm.Instance.pnlContainer.Controls.Add(MainForm.mchoice);     
            MainForm.mchoice.BringToFront();

            MainForm.page += 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nowTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            today.Text = DateTime.Now.ToLongDateString();
        }
    }
}
