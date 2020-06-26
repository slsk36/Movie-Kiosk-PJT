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
    public partial class UserControl3 : UserControl
    {
        System.ComponentModel.ComponentResourceManager resources 
            = new System.ComponentModel.ComponentResourceManager(typeof(UserControl3));
        //숫자 이미지 리소스 가져오기 위해 선언

        public UserControl3()
        {
            InitializeComponent();
        }

        //선택 완료 버튼
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Main.uc4.adult  == 0 && Main.uc4.youth == 0 ) //성인 청소년 둘다 0명이면
            {
                MessageBox.Show("인원을 선택하세요");
            }
            else
            {
                if (!Main.Instance.pnlContainer.Controls.ContainsKey("UserControl4"))
                {
                    Main.uc4.Dock = DockStyle.Fill;
                    Main.Instance.pnlContainer.Controls.Add(Main.uc4);
                }
                Main.Instance.pnlContainer.Controls["UserControl4"].BringToFront();
                
            }
        }

        // 성인 인원 수 선택 함수
        private void btnPs_Click(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;      //버튼의 값 받아옴
            Info.Text = btn.Tag.ToString();   //출력창에 버튼의 tag값 text로 변경
            Main.uc4.adult = Convert.ToInt32(Info.Text); //adult값 정수로 변환
            UserControl4.person = Main.uc4.adult + Main.uc4.youth;    
        }


        //청소년 인원 수 선택 함수
        private void btnYt_Click(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;       //버튼의 값 받아옴
            Info_Y.Text = btn.Tag.ToString();   //출력창에 버튼의 tag값 text로 변경
            Main.uc4.youth = Convert.ToInt32(Info_Y.Text);   //adult값 정수로 변환
            UserControl4.person = Main.uc4.adult + Main.uc4.youth;
        }

        //흰색 버튼 모두 앞으로 나오는 함수
        public void setForeBackImageBtn() 
        {
            pictureBox1.Image = Properties.Resources._1st_26px;
            pictureBox2.Image = Properties.Resources.circled_2_26px;
            pictureBox3.Image = Properties.Resources.circled_3_26px;
            pictureBox4.Image = Properties.Resources.circled_4_26px;
            pictureBox5.Image = Properties.Resources.circled_5_26px;
            pictureBox6.Image = Properties.Resources.circled_6_26px;
        }

        public void setForeBackImageBtn2()
        {
            pictureBox16.Image = Properties.Resources._1st_26px;
            pictureBox15.Image = Properties.Resources.circled_2_26px;
            pictureBox14.Image = Properties.Resources.circled_3_26px;
            pictureBox13.Image = Properties.Resources.circled_4_26px;
            pictureBox12.Image = Properties.Resources.circled_5_26px;
            pictureBox11.Image = Properties.Resources.circled_6_26px;
        }


        //클릭할때마다 검은버튼으로 이미지 전환(성인)
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            setForeBackImageBtn();
            pictureBox1.Image = Properties.Resources.level_1_26px;
            btnPs_Click(sender,e);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            setForeBackImageBtn();
            pictureBox2.Image = Properties.Resources.circled_2_c_26px;
            btnPs_Click(sender, e);

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            setForeBackImageBtn();
            pictureBox3.Image = Properties.Resources.circled_3_c_26px;
            btnPs_Click(sender, e);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            setForeBackImageBtn();
            pictureBox4.Image = Properties.Resources.circled_4_c_26px;
            btnPs_Click(sender, e);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            setForeBackImageBtn();
            pictureBox5.Image = Properties.Resources.circled_5_c_26px;
            btnPs_Click(sender, e);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            setForeBackImageBtn();
            pictureBox6.Image = Properties.Resources.circled_6_c_26px;
            btnPs_Click(sender, e);
        }



        //청소년
        private void pictureBox16_Click(object sender, EventArgs e)
        {
            setForeBackImageBtn2();
            pictureBox16.Image = Properties.Resources.level_1_26px;
            btnYt_Click(sender, e);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            setForeBackImageBtn2();
            pictureBox15.Image = Properties.Resources.circled_2_c_26px;
            btnYt_Click(sender, e);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            setForeBackImageBtn2();
            pictureBox14.Image = Properties.Resources.circled_3_c_26px;
            btnYt_Click(sender, e);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            setForeBackImageBtn2();
            pictureBox13.Image = Properties.Resources.circled_4_c_26px;
            btnYt_Click(sender, e);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            setForeBackImageBtn2();
            pictureBox12.Image = Properties.Resources.circled_5_c_26px;
            btnYt_Click(sender, e);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            setForeBackImageBtn2();
            pictureBox11.Image = Properties.Resources.circled_6_c_26px;
            btnYt_Click(sender, e);
        }


        // X버튼 기능 : 뒤로가기
        private void pictureBox17_Click(object sender, EventArgs e)
        {
            Main.Instance.pnlContainer.Controls["UserControl2"].BringToFront();
            Info.Text = "";
            Info_Y.Text = "";
            Main.uc4.adult = 0;  //인원수 초기화
            Main.uc4.youth = 0;
            setForeBackImageBtn();
            setForeBackImageBtn2();
        }

        // 초기화 함수
        


    }
}
