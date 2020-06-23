using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Kiosk
{
    public partial class UserControl5 : UserControl
    {
        public static string seat;

        public UserControl5()
        {
            InitializeComponent();
            
        }
        private void pictureBox2_Click_1(object sender, EventArgs e)
            //control4이동
        {
            Main.Instance.pnlContainer.Controls["UserControl4"].BringToFront();
        }

        private void buttn2_Click(object sender, EventArgs e)
            //control6 이동
        {
            UserControl6 uc6 = new UserControl6();
            Main.Instance.pnlContainer.Controls.Add(uc6);
            Main.Instance.pnlContainer.Controls["UserControl6"].BringToFront();
        }


    }
}
