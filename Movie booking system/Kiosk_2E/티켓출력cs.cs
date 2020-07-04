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
    public partial class 티켓출력cs : UserControl
    {
        public 티켓출력cs()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, EventArgs e)
        {

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
    }
}
