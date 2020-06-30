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
                uc2_movie1Round m1 = new uc2_movie1Round();
                m1.Dock = DockStyle.Fill;
                MainForm.Instance.pnlContainer.Controls.Add(m1);
            }
            MainForm.Instance.pnlContainer.Controls["uc2_movie1Round"].BringToFront();
            MainForm.page += 1;
        }
    }
}
