﻿using System;
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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }


        private void label2_Click(object sender, EventArgs e)
        {
            if (!Main.Instance.pnlContainer.Controls.ContainsKey("UserControl3"))
            {
                Main.uc3.Dock = DockStyle.Fill;
                Main.Instance.pnlContainer.Controls.Add(Main.uc3);
            }
            Main.Instance.pnlContainer.Controls["UserControl3"].BringToFront();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Main.Instance.pnlContainer.Controls["UserControl1"].BringToFront();
        }
        // 뒤로가기
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Main.Instance.pnlContainer.Controls["UserControl1"].BringToFront();
        }
    }
    
}