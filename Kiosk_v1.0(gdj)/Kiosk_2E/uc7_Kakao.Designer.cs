namespace Kiosk_2E
{
    partial class uc7_Kakao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc7_Kakao));
            this.cancelQR = new System.Windows.Forms.Button();
            this.paidQR = new System.Windows.Forms.Button();
            this.pbQR = new System.Windows.Forms.PictureBox();
            this.scanQR = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.QR_Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelQR
            // 
            this.cancelQR.BackColor = System.Drawing.Color.SlateBlue;
            this.cancelQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelQR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancelQR.Location = new System.Drawing.Point(220, 300);
            this.cancelQR.Name = "cancelQR";
            this.cancelQR.Size = new System.Drawing.Size(135, 50);
            this.cancelQR.TabIndex = 19;
            this.cancelQR.Text = "취 소";
            this.cancelQR.UseVisualStyleBackColor = false;
            // 
            // paidQR
            // 
            this.paidQR.BackColor = System.Drawing.Color.SlateBlue;
            this.paidQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paidQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paidQR.Location = new System.Drawing.Point(36, 300);
            this.paidQR.Name = "paidQR";
            this.paidQR.Size = new System.Drawing.Size(135, 50);
            this.paidQR.TabIndex = 18;
            this.paidQR.Text = "결제 완료";
            this.paidQR.UseVisualStyleBackColor = false;
            this.paidQR.Click += new System.EventHandler(this.paidQR_Click);
            // 
            // pbQR
            // 
            this.pbQR.Image = ((System.Drawing.Image)(resources.GetObject("pbQR.Image")));
            this.pbQR.Location = new System.Drawing.Point(115, 93);
            this.pbQR.Name = "pbQR";
            this.pbQR.Size = new System.Drawing.Size(154, 188);
            this.pbQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbQR.TabIndex = 17;
            this.pbQR.TabStop = false;
            // 
            // scanQR
            // 
            this.scanQR.AutoSize = true;
            this.scanQR.Location = new System.Drawing.Point(108, 65);
            this.scanQR.Name = "scanQR";
            this.scanQR.Size = new System.Drawing.Size(170, 12);
            this.scanQR.TabIndex = 15;
            this.scanQR.Text = "QR 코드 스캐너로 찍어주세요!";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.SlateBlue;
            this.panelTop.Controls.Add(this.QR_Title);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.ForeColor = System.Drawing.Color.Black;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(384, 53);
            this.panelTop.TabIndex = 13;
            // 
            // QR_Title
            // 
            this.QR_Title.AutoSize = true;
            this.QR_Title.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.QR_Title.ForeColor = System.Drawing.Color.White;
            this.QR_Title.Location = new System.Drawing.Point(14, 17);
            this.QR_Title.Name = "QR_Title";
            this.QR_Title.Size = new System.Drawing.Size(91, 21);
            this.QR_Title.TabIndex = 0;
            this.QR_Title.Text = "QR 코드";
            // 
            // uc7_Kakao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancelQR);
            this.Controls.Add(this.paidQR);
            this.Controls.Add(this.pbQR);
            this.Controls.Add(this.scanQR);
            this.Controls.Add(this.panelTop);
            this.Name = "uc7_Kakao";
            this.Size = new System.Drawing.Size(384, 360);
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelQR;
        private System.Windows.Forms.Button paidQR;
        private System.Windows.Forms.PictureBox pbQR;
        private System.Windows.Forms.Label scanQR;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label QR_Title;
    }
}
