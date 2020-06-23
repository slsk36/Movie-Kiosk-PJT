using Kiosk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectMenuPage
{
    public partial class SubMenu2 : Form
    {
        public SubMenu2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectPs Person = new SelectPs();
            Person.Show();
        }

        private void SubMenu2_Load(object sender, EventArgs e)
        {

        }
    }
}
