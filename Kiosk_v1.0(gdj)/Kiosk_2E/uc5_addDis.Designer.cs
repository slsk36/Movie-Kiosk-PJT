namespace Kiosk_2E
{
    partial class uc5_addDis
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc5_addDis));
            this.payForIt = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.dis = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mageboxMem = new System.Windows.Forms.Button();
            this.vipCoupon = new System.Windows.Forms.Button();
            this.telecomDis = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // payForIt
            // 
            this.payForIt.AllowDrop = true;
            this.payForIt.AutoEllipsis = true;
            this.payForIt.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.payForIt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.payForIt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payForIt.ForeColor = System.Drawing.Color.White;
            this.payForIt.Location = new System.Drawing.Point(78, 512);
            this.payForIt.Name = "payForIt";
            this.payForIt.Size = new System.Drawing.Size(218, 52);
            this.payForIt.TabIndex = 92;
            this.payForIt.Text = "최종 결제로 이동";
            this.payForIt.UseCompatibleTextRendering = true;
            this.payForIt.UseVisualStyleBackColor = false;
            this.payForIt.Click += new System.EventHandler(this.payForIt_Click);
            // 
            // sum
            // 
            this.sum.AutoSize = true;
            this.sum.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sum.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sum.Location = new System.Drawing.Point(37, 218);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(16, 16);
            this.sum.TabIndex = 88;
            this.sum.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(86, 218);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 16);
            this.label18.TabIndex = 87;
            this.label18.Text = "원";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(198, 218);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 16);
            this.label17.TabIndex = 86;
            this.label17.Text = "원";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(327, 218);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 16);
            this.label16.TabIndex = 85;
            this.label16.Text = "원";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.total.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.total.Location = new System.Drawing.Point(269, 218);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(16, 16);
            this.total.TabIndex = 84;
            this.total.Text = "0";
            // 
            // dis
            // 
            this.dis.AutoSize = true;
            this.dis.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dis.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dis.Location = new System.Drawing.Point(143, 218);
            this.dis.Name = "dis";
            this.dis.Size = new System.Drawing.Size(16, 16);
            this.dis.TabIndex = 83;
            this.dis.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(234, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 24);
            this.label12.TabIndex = 82;
            this.label12.Text = "=";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(114, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 24);
            this.label11.TabIndex = 81;
            this.label11.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(268, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 80;
            this.label10.Text = "결제금액";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(151, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 79;
            this.label9.Text = "할인금액";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 78;
            this.label8.Text = "원금액";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 12);
            this.label5.TabIndex = 76;
            this.label5.Text = "예매 진행중입니다.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label4.Location = new System.Drawing.Point(24, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 12);
            this.label4.TabIndex = 75;
            this.label4.Text = "영화 이름 / 시간 / 몇 관  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("함초롬바탕 확장", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 32);
            this.label2.TabIndex = 74;
            this.label2.Text = "추가 할인 선택";
            // 
            // mageboxMem
            // 
            this.mageboxMem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mageboxMem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.mageboxMem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mageboxMem.BackgroundImage")));
            this.mageboxMem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mageboxMem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mageboxMem.FlatAppearance.BorderSize = 0;
            this.mageboxMem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.mageboxMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mageboxMem.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mageboxMem.ForeColor = System.Drawing.Color.White;
            this.mageboxMem.Location = new System.Drawing.Point(259, 291);
            this.mageboxMem.Name = "mageboxMem";
            this.mageboxMem.Size = new System.Drawing.Size(91, 97);
            this.mageboxMem.TabIndex = 91;
            this.mageboxMem.Text = "마게박스\r\n멤버십 할인";
            this.mageboxMem.UseVisualStyleBackColor = false;
            // 
            // vipCoupon
            // 
            this.vipCoupon.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.vipCoupon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vipCoupon.BackgroundImage")));
            this.vipCoupon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.vipCoupon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vipCoupon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.vipCoupon.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.vipCoupon.ForeColor = System.Drawing.Color.White;
            this.vipCoupon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.vipCoupon.Location = new System.Drawing.Point(146, 291);
            this.vipCoupon.Name = "vipCoupon";
            this.vipCoupon.Size = new System.Drawing.Size(91, 97);
            this.vipCoupon.TabIndex = 90;
            this.vipCoupon.Text = "마게박스 VIP 쿠폰";
            this.vipCoupon.UseVisualStyleBackColor = false;
            // 
            // telecomDis
            // 
            this.telecomDis.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.telecomDis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("telecomDis.BackgroundImage")));
            this.telecomDis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.telecomDis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.telecomDis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.telecomDis.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.telecomDis.ForeColor = System.Drawing.Color.White;
            this.telecomDis.Location = new System.Drawing.Point(31, 291);
            this.telecomDis.Name = "telecomDis";
            this.telecomDis.Size = new System.Drawing.Size(91, 97);
            this.telecomDis.TabIndex = 89;
            this.telecomDis.Text = "통신사 할인";
            this.telecomDis.UseVisualStyleBackColor = false;
            this.telecomDis.Click += new System.EventHandler(this.telecomDis_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(251, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // uc5_addDis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.payForIt);
            this.Controls.Add(this.mageboxMem);
            this.Controls.Add(this.vipCoupon);
            this.Controls.Add(this.telecomDis);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.total);
            this.Controls.Add(this.dis);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "uc5_addDis";
            this.Size = new System.Drawing.Size(384, 621);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button payForIt;
        private System.Windows.Forms.Button mageboxMem;
        private System.Windows.Forms.Button vipCoupon;
        private System.Windows.Forms.Button telecomDis;
        public System.Windows.Forms.Label sum;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label dis;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}
