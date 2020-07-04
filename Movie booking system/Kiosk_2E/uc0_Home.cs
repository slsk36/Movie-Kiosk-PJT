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
            timer1.Start();
            timer2.Start();
            timer1.Interval = 1000;
            timer2.Interval = 1000;
            // pictureBox에 대한 lable 투명화
            //branch.Parent = pictureBox1;
            today.Parent = pictureBox1;
            nowTime.Parent = pictureBox1;
            bookedPrint.Parent = pictureBox1;
            buyTicket.Parent = pictureBox1;
            button1.Parent = pictureBox1;
        }
        


        private void buyTicket_Click(object sender, EventArgs e)
        {
            MainForm.hm.SendToBack();         // 홈 화면 숨기기
            

            MainForm.mchoice.Show();    // 영화 선택 화면 표시
            MainForm.Instance.pnlContainer.Controls.Add(MainForm.mchoice);     
            MainForm.mchoice.BringToFront();

            //MainForm.page += 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nowTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            today.Text = DateTime.Now.ToLongDateString();
        }

        //환불페이지
        private void button1_Click(object sender, EventArgs e) 
        {
            MainForm.Instance.pnlContainer.Controls.Add(MainForm.cancle);
            MainForm.Instance.pnlContainer.Controls["환불"].BringToFront();
            MainForm.cancle.NotMath(); //환불 페이지 티켓넘버조회해서 리스트박스로 넘기기
        }
        //예매티켓 출력
        private void bookedPrint_Click(object sender, EventArgs e)
        {
            MainForm.Instance.pnlContainer.Controls.Add(MainForm.ticket);
            MainForm.Instance.pnlContainer.Controls["티켓출력cs"].BringToFront();
        }
    }
}
