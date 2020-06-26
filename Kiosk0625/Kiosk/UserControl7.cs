using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class UserControl7 : UserControl
    {
        public UserControl7()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //할인 수정
            Main.Instance.pnlContainer.Controls.Add(Main.uc5);
            Main.Instance.pnlContainer.Controls["UserControl5"].BringToFront();
        }
    }
}
