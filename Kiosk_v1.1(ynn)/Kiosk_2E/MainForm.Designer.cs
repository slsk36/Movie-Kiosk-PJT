namespace Kiosk_2E
{
    partial class MainForm
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.goHome = new System.Windows.Forms.Label();
            this.goBack = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.bottomPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(384, 681);
            this.mainPanel.TabIndex = 0;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.Purple;
            this.bottomPanel.Controls.Add(this.goHome);
            this.bottomPanel.Controls.Add(this.goBack);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 621);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(384, 60);
            this.bottomPanel.TabIndex = 0;
            // 
            // goHome
            // 
            this.goHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goHome.ForeColor = System.Drawing.Color.White;
            this.goHome.Image = ((System.Drawing.Image)(resources.GetObject("goHome.Image")));
            this.goHome.Location = new System.Drawing.Point(324, 0);
            this.goHome.Name = "goHome";
            this.goHome.Size = new System.Drawing.Size(60, 60);
            this.goHome.TabIndex = 1;
            this.goHome.Click += new System.EventHandler(MainForm.goHome_Click);
            // 
            // goBack
            // 
            this.goBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goBack.ForeColor = System.Drawing.Color.White;
            this.goBack.Image = ((System.Drawing.Image)(resources.GetObject("goBack.Image")));
            this.goBack.Location = new System.Drawing.Point(-2, 0);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(60, 60);
            this.goBack.TabIndex = 0;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 681);
            this.Controls.Add(this.mainPanel);
            this.Name = "MainForm";
            this.Text = "MAGEBOX v1.0";
            this.mainPanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Label goHome;
        private System.Windows.Forms.Label goBack;
    }
}

