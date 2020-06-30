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
    //참조 : 요일, 시간

    public partial class uc0_Home : UserControl
    {
        public uc0_Home()
        {
            InitializeComponent();
        }

        private void buyTicket_Click(object sender, EventArgs e)
        {
            MainForm.hm.SendToBack();         // 홈 화면 숨기기
            

            MainForm.mchoice.Show();    // 영화 선택 화면 표시
            MainForm.Instance.pnlContainer.Controls.Add(MainForm.mchoice);     
            MainForm.mchoice.BringToFront();

            MainForm.page += 1;
        }
    }
}
