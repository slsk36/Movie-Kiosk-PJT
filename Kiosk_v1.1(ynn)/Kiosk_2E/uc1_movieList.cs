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
    // 참조 : 전체 영화코드, 영화제목, 상영시간
    // 전달 : 선택 영화코드

    public partial class uc1_movieList : UserControl
    {
        public uc1_movieList()
        {
            InitializeComponent();
        }

        private void movie1_Click(object sender, EventArgs e)
        {
            if (!MainForm.Instance.pnlContainer.Controls.ContainsKey("uc2_movie1Round"))
            {
                MainForm.m1r.Dock = DockStyle.Fill;
                MainForm.Instance.pnlContainer.Controls.Add(MainForm.m1r);
            }
            MainForm.Instance.pnlContainer.Controls["uc2_movie1Round"].BringToFront();
            MainForm.m1r.Movieposter = movie1.BackgroundImage; //이미지 전달하기
            MainForm.m1r.Title = title1.Text;                 //영화명 전달하기
            MainForm.Instance.GoBack = null; //★메인 패널의 뒤로가기 이미지 숨기기★
            MainForm.page += 1;
        }

        private void movie2_Click(object sender, EventArgs e)
        {
            if (!MainForm.Instance.pnlContainer.Controls.ContainsKey("uc2_movie1Round"))
            {
                MainForm.m1r.Dock = DockStyle.Fill;
                MainForm.Instance.pnlContainer.Controls.Add(MainForm.m1r);
            }
            MainForm.Instance.pnlContainer.Controls["uc2_movie1Round"].BringToFront();
            MainForm.m1r.Movieposter = movie2.BackgroundImage; //이미지 전달하기
            MainForm.m1r.Title = title2.Text;                 //영화명 전달하기
            MainForm.Instance.GoBack = null; //★메인 패널의 뒤로가기 없앰★
            MainForm.page += 1;
        }

        private void movie3_Click(object sender, EventArgs e)
        {
            if (!MainForm.Instance.pnlContainer.Controls.ContainsKey("uc2_movie1Round"))
            {
                MainForm.m1r.Dock = DockStyle.Fill;
                MainForm.Instance.pnlContainer.Controls.Add(MainForm.m1r);
            }
            MainForm.Instance.pnlContainer.Controls["uc2_movie1Round"].BringToFront();
            MainForm.m1r.Movieposter = movie3.BackgroundImage; //이미지 전달하기
            MainForm.m1r.Title = title3.Text;                 //영화명 전달하기
            MainForm.Instance.GoBack = null; //★메인 패널의 뒤로가기 없앰★
            MainForm.page += 1;
        }

        private void moive4_Click(object sender, EventArgs e)
        {
            if (!MainForm.Instance.pnlContainer.Controls.ContainsKey("uc2_movie1Round"))
            {
                MainForm.m1r.Dock = DockStyle.Fill;
                MainForm.Instance.pnlContainer.Controls.Add(MainForm.m1r);
            }
            MainForm.Instance.pnlContainer.Controls["uc2_movie1Round"].BringToFront();
            MainForm.m1r.Movieposter = movie4.BackgroundImage; //이미지 전달하기
            MainForm.m1r.Title = label4.Text;                 //영화명 전달하기
            MainForm.Instance.GoBack = null; //★메인 패널의 뒤로가기 없앰★
            MainForm.page += 1;
        }
    }
}
