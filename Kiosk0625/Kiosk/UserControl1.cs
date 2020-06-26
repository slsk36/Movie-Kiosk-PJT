using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
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



        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!Main.Instance.pnlContainer.Controls.ContainsKey("UserControl2"))
            {
                Main.uc2.Dock = DockStyle.Fill;
                Main.Instance.pnlContainer.Controls.Add(Main.uc2);
            }
            Main.Instance.pnlContainer.Controls["UserControl2"].BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e) //뒤로가기 버튼
        {
            this.SendToBack();
            Main.Instance.PictureBoxShow();
        }

       
    }
}
