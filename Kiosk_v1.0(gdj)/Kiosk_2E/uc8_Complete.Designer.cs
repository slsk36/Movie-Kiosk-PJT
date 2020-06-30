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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc8_Complete));
            this.doneImage = new System.Windows.Forms.PictureBox();
            this.doneText = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.doneTitle = new System.Windows.Forms.Label();
            this.doneGoHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.doneImage)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // doneImage
            // 
            this.doneImage.Image = ((System.Drawing.Image)(resources.GetObject("doneImage.Image")));
            this.doneImage.Location = new System.Drawing.Point(88, 241);
            this.doneImage.Name = "doneImage";
            this.doneImage.Size = new System.Drawing.Size(206, 132);
            this.doneImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.doneImage.TabIndex = 20;
            this.doneImage.TabStop = false;
            // 
            // doneText
            // 
            this.doneText.AutoSize = true;
            this.doneText.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.doneText.Location = new System.Drawing.Point(84, 142);
            this.doneText.Name = "doneText";
            this.doneText.Size = new System.Drawing.Size(210, 48);
            this.doneText.TabIndex = 19;
            this.doneText.Text = "예매가 성공적으로\r\n완료되었습니다.";
            this.doneText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.SlateBlue;
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
            this.doneTitle.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.doneTitle.ForeColor = System.Drawing.Color.White;
            this.doneTitle.Location = new System.Drawing.Point(14, 17);
            this.doneTitle.Name = "doneTitle";
            this.doneTitle.Size = new System.Drawing.Size(106, 21);
            this.doneTitle.TabIndex = 0;
            this.doneTitle.Text = "예매 완료";
            // 
            // doneGoHome
            // 
            this.doneGoHome.Location = new System.Drawing.Point(130, 504);
            this.doneGoHome.Name = "doneGoHome";
            this.doneGoHome.Size = new System.Drawing.Size(132, 61);
            this.doneGoHome.TabIndex = 21;
            this.doneGoHome.Text = "처음으로";
            this.doneGoHome.UseVisualStyleBackColor = true;
            this.doneGoHome.Click += new System.EventHandler(this.doneGoHome_Click);
            // 
            // uc8_Complete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.doneGoHome);
            this.Controls.Add(this.doneImage);
            this.Controls.Add(this.doneText);
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
        private System.Windows.Forms.Label doneText;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label doneTitle;
        private System.Windows.Forms.Button doneGoHome;
    }
}
