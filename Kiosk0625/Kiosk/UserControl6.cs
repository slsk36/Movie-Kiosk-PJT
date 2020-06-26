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
    public partial class UserControl6 : UserControl
    {
        public UserControl6()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Main.Instance.pnlContainer.Controls["UserControl5"].BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // KT 할인
            double A = 0.2;
            Main.uc5.Dis = (int.Parse(Main.uc5.Sum) * A).ToString();
            // SUM이 string 으로 선언되어 Parse 로 형변환
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // SKT 할인
            double A = 0.15;
            Main.uc5.Dis = (int.Parse(Main.uc5.Sum) * A).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // LG 할인
            double A = 0.1;
            Main.uc5.Dis = (int.Parse(Main.uc5.Sum) * A).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 할인 완료 후 uc5 이동 
            Main.uc5.Total = (int.Parse(Main.uc5.Sum) - double.Parse(Main.uc5.Dis)).ToString();
            Main.Instance.pnlContainer.Controls["UserControl5"].BringToFront();
        }
    }
}
