namespace Kiosk_2E
{
    partial class uc6_payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc6_payment));
            this.kakaoPay = new System.Windows.Forms.Button();
            this.creditCard = new System.Windows.Forms.Button();
            this.disList = new System.Windows.Forms.Label();
            this.disDetail = new System.Windows.Forms.Label();
            this.cancelCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kakaoPay
            // 
            this.kakaoPay.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.kakaoPay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kakaoPay.BackgroundImage")));
            this.kakaoPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kakaoPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kakaoPay.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
            this.kakaoPay.ForeColor = System.Drawing.Color.White;
            this.kakaoPay.Location = new System.Drawing.Point(232, 125);
            this.kakaoPay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kakaoPay.Name = "kakaoPay";
            this.kakaoPay.Size = new System.Drawing.Size(149, 123);
            this.kakaoPay.TabIndex = 8;
            this.kakaoPay.Text = "카카오 페이";
            this.kakaoPay.UseVisualStyleBackColor = false;
            this.kakaoPay.Click += new System.EventHandler(this.kakaoPay_Click);
            // 
            // creditCard
            // 
            this.creditCard.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.creditCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("creditCard.BackgroundImage")));
            this.creditCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creditCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditCard.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.creditCard.ForeColor = System.Drawing.Color.White;
            this.creditCard.Location = new System.Drawing.Point(58, 125);
            this.creditCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.creditCard.Name = "creditCard";
            this.creditCard.Size = new System.Drawing.Size(149, 123);
            this.creditCard.TabIndex = 7;
            this.creditCard.Text = "신용 카드";
            this.creditCard.UseVisualStyleBackColor = false;
            this.creditCard.Click += new System.EventHandler(this.creditCard_Click);
            // 
            // disList
            // 
            this.disList.AutoSize = true;
            this.disList.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.disList.Location = new System.Drawing.Point(65, 29);
            this.disList.Name = "disList";
            this.disList.Size = new System.Drawing.Size(95, 15);
            this.disList.TabIndex = 9;
            this.disList.Text = "할인 내역 : ";
            // 
            // disDetail
            // 
            this.disDetail.BackColor = System.Drawing.Color.White;
            this.disDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.disDetail.Location = new System.Drawing.Point(150, 22);
            this.disDetail.Name = "disDetail";
            this.disDetail.Size = new System.Drawing.Size(231, 29);
            this.disDetail.TabIndex = 10;
            this.disDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancelCard
            // 
            this.cancelCard.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cancelCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelCard.BackgroundImage")));
            this.cancelCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelCard.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cancelCard.ForeColor = System.Drawing.Color.White;
            this.cancelCard.Location = new System.Drawing.Point(141, 287);
            this.cancelCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelCard.Name = "cancelCard";
            this.cancelCard.Size = new System.Drawing.Size(149, 76);
            this.cancelCard.TabIndex = 13;
            this.cancelCard.Text = "취 소";
            this.cancelCard.UseVisualStyleBackColor = false;
            this.cancelCard.Click += new System.EventHandler(this.cancelCard_Click);
            // 
            // uc6_payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancelCard);
            this.Controls.Add(this.disDetail);
            this.Controls.Add(this.disList);
            this.Controls.Add(this.kakaoPay);
            this.Controls.Add(this.creditCard);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uc6_payment";
            this.Size = new System.Drawing.Size(439, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button kakaoPay;
        private System.Windows.Forms.Button creditCard;
        private System.Windows.Forms.Label disList;
        public System.Windows.Forms.Label disDetail;
        private System.Windows.Forms.Button cancelCard;
    }
}
