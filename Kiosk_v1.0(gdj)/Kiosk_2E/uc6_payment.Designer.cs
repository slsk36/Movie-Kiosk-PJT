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
            this.kakaoPay = new System.Windows.Forms.Button();
            this.creditCard = new System.Windows.Forms.Button();
            this.disList = new System.Windows.Forms.Label();
            this.disDetail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kakaoPay
            // 
            this.kakaoPay.BackColor = System.Drawing.Color.SlateBlue;
            this.kakaoPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kakaoPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kakaoPay.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.kakaoPay.ForeColor = System.Drawing.Color.White;
            this.kakaoPay.Location = new System.Drawing.Point(227, 99);
            this.kakaoPay.Name = "kakaoPay";
            this.kakaoPay.Size = new System.Drawing.Size(106, 170);
            this.kakaoPay.TabIndex = 8;
            this.kakaoPay.Text = "카카오 페이";
            this.kakaoPay.UseVisualStyleBackColor = false;
            this.kakaoPay.Click += new System.EventHandler(this.kakaoPay_Click);
            // 
            // creditCard
            // 
            this.creditCard.BackColor = System.Drawing.Color.SlateBlue;
            this.creditCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creditCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditCard.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.creditCard.ForeColor = System.Drawing.Color.White;
            this.creditCard.Location = new System.Drawing.Point(59, 99);
            this.creditCard.Name = "creditCard";
            this.creditCard.Size = new System.Drawing.Size(106, 170);
            this.creditCard.TabIndex = 7;
            this.creditCard.Text = "신용 카드";
            this.creditCard.UseVisualStyleBackColor = false;
            this.creditCard.Click += new System.EventHandler(this.creditCard_Click);
            // 
            // disList
            // 
            this.disList.AutoSize = true;
            this.disList.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.disList.Location = new System.Drawing.Point(57, 23);
            this.disList.Name = "disList";
            this.disList.Size = new System.Drawing.Size(77, 12);
            this.disList.TabIndex = 9;
            this.disList.Text = "할인 내역 : ";
            // 
            // disDetail
            // 
            this.disDetail.BackColor = System.Drawing.Color.White;
            this.disDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.disDetail.Location = new System.Drawing.Point(131, 18);
            this.disDetail.Name = "disDetail";
            this.disDetail.Size = new System.Drawing.Size(202, 23);
            this.disDetail.TabIndex = 10;
            this.disDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uc6_payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.disDetail);
            this.Controls.Add(this.disList);
            this.Controls.Add(this.kakaoPay);
            this.Controls.Add(this.creditCard);
            this.Name = "uc6_payment";
            this.Size = new System.Drawing.Size(384, 360);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button kakaoPay;
        private System.Windows.Forms.Button creditCard;
        private System.Windows.Forms.Label disList;
        public System.Windows.Forms.Label disDetail;
    }
}
