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
    public partial class uc6_payment : UserControl
    {
        public uc6_payment()
        {
            InitializeComponent();
        }

        private void creditCard_Click(object sender, EventArgs e)
        {
            MainForm.Instance.pnlContainer.Controls.Add(MainForm.cc);
            MainForm.Instance.pnlContainer.Controls["uc7_Card"].Location = new Point(0, 261);
            MainForm.Instance.pnlContainer.Controls["uc7_Card"].BringToFront();
            MainForm.page += 1;
        }

        private void kakaoPay_Click(object sender, EventArgs e)
        {
            MainForm.Instance.pnlContainer.Controls.Add(MainForm.kp);
            MainForm.Instance.pnlContainer.Controls["uc7_Kakao"].Location = new Point(0, 261);
            MainForm.Instance.pnlContainer.Controls["uc7_Kakao"].BringToFront();
            MainForm.page += 1;
        }
    }
}
