namespace Kiosk_2E
{
    partial class uc5w_selectTel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc5w_selectTel));
            this.selTelWin = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.LG = new System.Windows.Forms.Button();
            this.SKT = new System.Windows.Forms.Button();
            this.KT = new System.Windows.Forms.Button();
            this.buttn2 = new System.Windows.Forms.Button();
            this.mageboxMem = new System.Windows.Forms.Button();
            this.vipCoupon = new System.Windows.Forms.Button();
            this.telecomDis = new System.Windows.Forms.Button();
            this.selTelWin.SuspendLayout();
            this.SuspendLayout();
            // 
            // selTelWin
            // 
            this.selTelWin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selTelWin.Controls.Add(this.label1);
            this.selTelWin.Controls.Add(this.cancel);
            this.selTelWin.Controls.Add(this.confirm);
            this.selTelWin.Controls.Add(this.LG);
            this.selTelWin.Controls.Add(this.SKT);
            this.selTelWin.Controls.Add(this.KT);
            this.selTelWin.Location = new System.Drawing.Point(49, 55);
            this.selTelWin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selTelWin.Name = "selTelWin";
            this.selTelWin.Size = new System.Drawing.Size(337, 303);
            this.selTelWin.TabIndex = 116;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(85, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 30);
            this.label1.TabIndex = 87;
            this.label1.Text = "통신사 선택";
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Brown;
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(171, 225);
            this.cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(150, 49);
            this.cancel.TabIndex = 86;
            this.cancel.Text = "적용 취소";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.DarkBlue;
            this.confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.confirm.ForeColor = System.Drawing.Color.White;
            this.confirm.Location = new System.Drawing.Point(21, 225);
            this.confirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(144, 49);
            this.confirm.TabIndex = 85;
            this.confirm.Text = "적용 완료";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // LG
            // 
            this.LG.BackColor = System.Drawing.Color.Transparent;
            this.LG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LG.BackgroundImage")));
            this.LG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LG.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LG.ForeColor = System.Drawing.Color.White;
            this.LG.Location = new System.Drawing.Point(227, 94);
            this.LG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LG.Name = "LG";
            this.LG.Size = new System.Drawing.Size(94, 94);
            this.LG.TabIndex = 84;
            this.LG.Text = "L G\r\n(10%)";
            this.LG.UseVisualStyleBackColor = false;
            this.LG.Click += new System.EventHandler(this.LG_Click);
            // 
            // SKT
            // 
            this.SKT.BackColor = System.Drawing.Color.Transparent;
            this.SKT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SKT.BackgroundImage")));
            this.SKT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SKT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SKT.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SKT.ForeColor = System.Drawing.Color.White;
            this.SKT.Location = new System.Drawing.Point(122, 94);
            this.SKT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SKT.Name = "SKT";
            this.SKT.Size = new System.Drawing.Size(94, 94);
            this.SKT.TabIndex = 83;
            this.SKT.Text = "SKT\r\n(15%)";
            this.SKT.UseVisualStyleBackColor = false;
            this.SKT.Click += new System.EventHandler(this.SKT_Click);
            // 
            // KT
            // 
            this.KT.BackColor = System.Drawing.Color.Transparent;
            this.KT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("KT.BackgroundImage")));
            this.KT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KT.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.KT.ForeColor = System.Drawing.Color.White;
            this.KT.Location = new System.Drawing.Point(16, 94);
            this.KT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.KT.Name = "KT";
            this.KT.Size = new System.Drawing.Size(94, 94);
            this.KT.TabIndex = 82;
            this.KT.Text = "K T\r\n(20%)";
            this.KT.UseVisualStyleBackColor = false;
            this.KT.Click += new System.EventHandler(this.KT_Click);
            // 
            // buttn2
            // 
            this.buttn2.AllowDrop = true;
            this.buttn2.AutoEllipsis = true;
            this.buttn2.BackColor = System.Drawing.Color.Transparent;
            this.buttn2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttn2.BackgroundImage")));
            this.buttn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttn2.Enabled = false;
            this.buttn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttn2.ForeColor = System.Drawing.Color.White;
            this.buttn2.Location = new System.Drawing.Point(93, 314);
            this.buttn2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttn2.Name = "buttn2";
            this.buttn2.Size = new System.Drawing.Size(249, 65);
            this.buttn2.TabIndex = 115;
            this.buttn2.Text = "최종 결제로 이동";
            this.buttn2.UseCompatibleTextRendering = true;
            this.buttn2.UseVisualStyleBackColor = false;
            // 
            // mageboxMem
            // 
            this.mageboxMem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mageboxMem.BackColor = System.Drawing.Color.Transparent;
            this.mageboxMem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mageboxMem.BackgroundImage")));
            this.mageboxMem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mageboxMem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mageboxMem.Enabled = false;
            this.mageboxMem.FlatAppearance.BorderSize = 0;
            this.mageboxMem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.mageboxMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mageboxMem.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mageboxMem.ForeColor = System.Drawing.Color.White;
            this.mageboxMem.Location = new System.Drawing.Point(296, 38);
            this.mageboxMem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mageboxMem.Name = "mageboxMem";
            this.mageboxMem.Size = new System.Drawing.Size(104, 121);
            this.mageboxMem.TabIndex = 114;
            this.mageboxMem.Text = "메가박스\r\n멤버십 할인";
            this.mageboxMem.UseVisualStyleBackColor = false;
            // 
            // vipCoupon
            // 
            this.vipCoupon.BackColor = System.Drawing.Color.Transparent;
            this.vipCoupon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vipCoupon.BackgroundImage")));
            this.vipCoupon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.vipCoupon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vipCoupon.Enabled = false;
            this.vipCoupon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.vipCoupon.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.vipCoupon.ForeColor = System.Drawing.Color.White;
            this.vipCoupon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.vipCoupon.Location = new System.Drawing.Point(167, 38);
            this.vipCoupon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vipCoupon.Name = "vipCoupon";
            this.vipCoupon.Size = new System.Drawing.Size(104, 121);
            this.vipCoupon.TabIndex = 113;
            this.vipCoupon.Text = "마게박스 VIP 쿠폰";
            this.vipCoupon.UseVisualStyleBackColor = false;
            // 
            // telecomDis
            // 
            this.telecomDis.BackColor = System.Drawing.Color.Transparent;
            this.telecomDis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("telecomDis.BackgroundImage")));
            this.telecomDis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.telecomDis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.telecomDis.Enabled = false;
            this.telecomDis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.telecomDis.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.telecomDis.ForeColor = System.Drawing.Color.White;
            this.telecomDis.Location = new System.Drawing.Point(35, 38);
            this.telecomDis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.telecomDis.Name = "telecomDis";
            this.telecomDis.Size = new System.Drawing.Size(104, 121);
            this.telecomDis.TabIndex = 112;
            this.telecomDis.Text = "통신사 할인";
            this.telecomDis.UseVisualStyleBackColor = false;
            // 
            // uc5w_selectTel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.selTelWin);
            this.Controls.Add(this.buttn2);
            this.Controls.Add(this.mageboxMem);
            this.Controls.Add(this.vipCoupon);
            this.Controls.Add(this.telecomDis);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uc5w_selectTel";
            this.Size = new System.Drawing.Size(439, 465);
            this.selTelWin.ResumeLayout(false);
            this.selTelWin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttn2;
        private System.Windows.Forms.Button mageboxMem;
        private System.Windows.Forms.Button vipCoupon;
        private System.Windows.Forms.Button telecomDis;
        private System.Windows.Forms.Panel selTelWin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button LG;
        private System.Windows.Forms.Button SKT;
        private System.Windows.Forms.Button KT;
    }
}
