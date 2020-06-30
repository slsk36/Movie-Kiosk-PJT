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
    public partial class uc8_Complete : UserControl
    {
        public uc8_Complete()
        {
            InitializeComponent();
        }

        private void doneGoHome_Click(object sender, EventArgs e)
        {
            MainForm.goHome_Click(sender, e);
        }
    }
}
