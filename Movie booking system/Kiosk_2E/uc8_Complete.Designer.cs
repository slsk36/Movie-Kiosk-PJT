namespace Kiosk_2E
{
    partial class uc8_Complete
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
            this.bookingNum = new System.Windows.Forms.Label();
            this.doneGoHome = new System.Windows.Forms.Button();
            this.doneImage = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.doneTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.doneImage)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookingNum
            // 
            this.bookingNum.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bookingNum.Location = new System.Drawing.Point(191, 123);
            this.bookingNum.Name = "bookingNum";
            this.bookingNum.Size = new System.Drawing.Size(161, 68);
            this.bookingNum.TabIndex = 19;
            this.bookingNum.Text = "bookingNum";
            this.bookingNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // doneGoHome
            // 
            this.doneGoHome.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.doneGoHome.Location = new System.Drawing.Point(132, 532);
            this.doneGoHome.Name = "doneGoHome";
            this.doneGoHome.Size = new System.Drawing.Size(132, 61);
            this.doneGoHome.TabIndex = 21;
            this.doneGoHome.Text = "처음으로";
            this.doneGoHome.UseVisualStyleBackColor = true;
            this.doneGoHome.Click += new System.EventHandler(this.doneGoHome_Click);
            // 
            // doneImage
            // 
            this.doneImage.BackgroundImage = global::Kiosk_2E.Properties.Resources.complete;
            this.doneImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.doneImage.Location = new System.Drawing.Point(29, 214);
            this.doneImage.Name = "doneImage";
            this.doneImage.Size = new System.Drawing.Size(323, 179);
            this.doneImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.doneImage.TabIndex = 20;
            this.doneImage.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panelTop.BackgroundImage = global::Kiosk_2E.Properties.Resources.homeMenu_BG;
            this.panelTop.Controls.Add(this.doneTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.ForeColor = System.Drawing.Color.Black;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(384, 53);
            this.panelTop.TabIndex = 18;
            // 
            // doneTitle
            // 
            this.doneTitle.AutoSize = true;
            this.doneTitle.BackColor = System.Drawing.Color.Transparent;
            this.doneTitle.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.doneTitle.ForeColor = System.Drawing.Color.White;
            this.doneTitle.Location = new System.Drawing.Point(3, 9);
            this.doneTitle.Name = "doneTitle";
            this.doneTitle.Size = new System.Drawing.Size(119, 32);
            this.doneTitle.TabIndex = 0;
            this.doneTitle.Text = "예매 완료";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(25, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 68);
            this.label1.TabIndex = 22;
            this.label1.Text = "티켓번호";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.date.ForeColor = System.Drawing.Color.Red;
            this.date.Location = new System.Drawing.Point(24, 96);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(350, 27);
            this.date.TabIndex = 23;
            this.date.Text = "티켓번호 분실 시 환불불가";
            // 
            // uc8_Complete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doneGoHome);
            this.Controls.Add(this.doneImage);
            this.Controls.Add(this.bookingNum);
            this.Controls.Add(this.panelTop);
            this.Name = "uc8_Complete";
            this.Size = new System.Drawing.Size(384, 681);
            ((System.ComponentModel.ISupportInitialize)(this.doneImage)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox doneImage;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label doneTitle;
        private System.Windows.Forms.Button doneGoHome;
        private System.Windows.Forms.Label bookingNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label date;
    }
}
