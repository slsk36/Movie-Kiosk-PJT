namespace Kiosk_2E
{
    partial class uc7_Card
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc7_Card));
            this.insetCard_Eng = new System.Windows.Forms.Label();
            this.insertCard = new System.Windows.Forms.Label();
            this.cancelCard = new System.Windows.Forms.Button();
            this.paidCard = new System.Windows.Forms.Button();
            this.pbCard = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.cardTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // insetCard_Eng
            // 
            this.insetCard_Eng.AutoSize = true;
            this.insetCard_Eng.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.insetCard_Eng.Location = new System.Drawing.Point(176, 125);
            this.insetCard_Eng.Name = "insetCard_Eng";
            this.insetCard_Eng.Size = new System.Drawing.Size(107, 25);
            this.insetCard_Eng.TabIndex = 9;
            this.insetCard_Eng.Text = "Insert Card";
            // 
            // insertCard
            // 
            this.insertCard.AutoSize = true;
            this.insertCard.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.insertCard.Location = new System.Drawing.Point(97, 91);
            this.insertCard.Name = "insertCard";
            this.insertCard.Size = new System.Drawing.Size(285, 25);
            this.insertCard.TabIndex = 8;
            this.insertCard.Text = "카드를 그림과 같이 넣어주세요!";
            // 
            // cancelCard
            // 
            this.cancelCard.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cancelCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelCard.BackgroundImage")));
            this.cancelCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelCard.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cancelCard.ForeColor = System.Drawing.Color.White;
            this.cancelCard.Location = new System.Drawing.Point(245, 362);
            this.cancelCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelCard.Name = "cancelCard";
            this.cancelCard.Size = new System.Drawing.Size(154, 62);
            this.cancelCard.TabIndex = 12;
            this.cancelCard.Text = "취 소";
            this.cancelCard.UseVisualStyleBackColor = false;
            this.cancelCard.Click += new System.EventHandler(this.cancelCard_Click);
            // 
            // paidCard
            // 
            this.paidCard.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.paidCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paidCard.BackgroundImage")));
            this.paidCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paidCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paidCard.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.paidCard.ForeColor = System.Drawing.Color.White;
            this.paidCard.Location = new System.Drawing.Point(41, 362);
            this.paidCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.paidCard.Name = "paidCard";
            this.paidCard.Size = new System.Drawing.Size(154, 62);
            this.paidCard.TabIndex = 11;
            this.paidCard.Text = "결제 완료";
            this.paidCard.UseVisualStyleBackColor = false;
            this.paidCard.Click += new System.EventHandler(this.paidCard_Click);
            // 
            // pbCard
            // 
            this.pbCard.Image = ((System.Drawing.Image)(resources.GetObject("pbCard.Image")));
            this.pbCard.Location = new System.Drawing.Point(135, 164);
            this.pbCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbCard.Name = "pbCard";
            this.pbCard.Size = new System.Drawing.Size(176, 165);
            this.pbCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCard.TabIndex = 10;
            this.pbCard.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panelTop.BackgroundImage = global::Kiosk_2E.Properties.Resources.homeMenu_BG;
            this.panelTop.Controls.Add(this.cardTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.ForeColor = System.Drawing.Color.Black;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(439, 66);
            this.panelTop.TabIndex = 6;
            // 
            // cardTitle
            // 
            this.cardTitle.AutoSize = true;
            this.cardTitle.BackColor = System.Drawing.Color.Transparent;
            this.cardTitle.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cardTitle.ForeColor = System.Drawing.Color.White;
            this.cardTitle.Location = new System.Drawing.Point(3, 12);
            this.cardTitle.Name = "cardTitle";
            this.cardTitle.Size = new System.Drawing.Size(149, 41);
            this.cardTitle.TabIndex = 0;
            this.cardTitle.Text = "카드 삽입";
            // 
            // uc7_Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancelCard);
            this.Controls.Add(this.paidCard);
            this.Controls.Add(this.pbCard);
            this.Controls.Add(this.insetCard_Eng);
            this.Controls.Add(this.insertCard);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uc7_Card";
            this.Size = new System.Drawing.Size(439, 450);
            ((System.ComponentModel.ISupportInitialize)(this.pbCard)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelCard;
        private System.Windows.Forms.Button paidCard;
        private System.Windows.Forms.PictureBox pbCard;
        private System.Windows.Forms.Label insetCard_Eng;
        private System.Windows.Forms.Label insertCard;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label cardTitle;
    }
}
