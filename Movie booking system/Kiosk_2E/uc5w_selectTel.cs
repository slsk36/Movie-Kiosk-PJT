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
    public partial class uc5w_selectTel : UserControl
    {
        public uc5w_selectTel()
        {
            InitializeComponent();
        }

        public string Telecom;  // 통신사
        public double A { get; set; }   // 통신사 할인률

        private void KT_Click(object sender, EventArgs e)
        {
            // KT 할인
            A = 0.2;
            MainForm.aD.Dis = (int.Parse(MainForm.aD.Sum) * A).ToString();
            // SUM이 string 으로 선언되어 Parse 로 형변환
        }

        private void SKT_Click(object sender, EventArgs e)
        {
            // SKT 할인
            A = 0.15;
            MainForm.aD.Dis = (int.Parse(MainForm.aD.Sum) * A).ToString();
        }

        private void LG_Click(object sender, EventArgs e)
        {
            // LG 할인
            A = 0.1;
            MainForm.aD.Dis = (int.Parse(MainForm.aD.Sum) * A).ToString();
        }
        // 적용 취소
        private void cancel_Click(object sender, EventArgs e)
        {
            MainForm.aD.Dis = "";
            MainForm.aD.Total = MainForm.st.sum.Text;
            MainForm.Instance.pnlContainer.Controls["uc5_addDis"].BringToFront();
            MainForm.Instance.pnlContainer.Controls["uc5w_selectTel"].SendToBack();
        }
        // 할인 완료 후 창 닫기 
        private void confirm_Click(object sender, EventArgs e)
        {
           
            MainForm.aD.Total = (int.Parse(MainForm.aD.Sum) - double.Parse(MainForm.aD.Dis)).ToString();
            MainForm.Instance.pnlContainer.Controls["uc5_addDis"].BringToFront();
            MainForm.Instance.pnlContainer.Controls["uc5w_selectTel"].SendToBack();
            Telecom = A.ToString();

        }

        
    }
}
