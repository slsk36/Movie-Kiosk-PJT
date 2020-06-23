using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk
{
    

    public partial class Main : Form
    {
        static Main _obj;

        public static Main Instance
        {
            get
            {
                if(_obj == null)
                {
                    _obj = new Main();
                }
                return _obj;
            }
        }

        public Panel pnlContainer
        {
            get { return panel3; }
            set { panel3 = value;  }
        }

        

        public Main()
        {
            InitializeComponent();
        }

        

        private void ticket_page1_Click(object sender, EventArgs e)
        {

            _obj = this;

            UserControl1 uc = new UserControl1();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Add(uc);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
