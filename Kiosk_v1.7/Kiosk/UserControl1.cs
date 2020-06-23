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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!Main.Instance.pnlContainer.Controls.ContainsKey("UserControl2"))
            {
                UserControl2 un = new UserControl2();
                un.Dock = DockStyle.Fill;
                Main.Instance.pnlContainer.Controls.Add(un);
            }
            Main.Instance.pnlContainer.Controls["UserControl2"].BringToFront();
        }
    }
}
