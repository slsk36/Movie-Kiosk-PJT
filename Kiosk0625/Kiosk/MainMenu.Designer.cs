namespace Kiosk
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_del = new System.Windows.Forms.Button();
            this.ticket_page3 = new System.Windows.Forms.Button();
            this.ticket_page1 = new System.Windows.Forms.Button();
            this.ticket_page2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_del);
            this.panel1.Controls.Add(this.ticket_page3);
            this.panel1.Controls.Add(this.ticket_page1);
            this.panel1.Controls.Add(this.ticket_page2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 720);
            this.panel1.TabIndex = 5;
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_del.BackgroundImage = global::Kiosk.Properties.Resources.하늘5_1_01;
            this.btn_del.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_del.FlatAppearance.BorderSize = 0;
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.Image = global::Kiosk.Properties.Resources.delete_2_16;
            this.btn_del.Location = new System.Drawing.Point(0, 0);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(120, 50);
            this.btn_del.TabIndex = 1;
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // ticket_page3
            // 
            this.ticket_page3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ticket_page3.BackgroundImage = global::Kiosk.Properties.Resources.하늘5_1_03;
            this.ticket_page3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ticket_page3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.ticket_page3.ForeColor = System.Drawing.Color.White;
            this.ticket_page3.Image = global::Kiosk.Properties.Resources.photo_gallery_50px;
            this.ticket_page3.Location = new System.Drawing.Point(0, 497);
            this.ticket_page3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ticket_page3.Name = "ticket_page3";
            this.ticket_page3.Size = new System.Drawing.Size(120, 223);
            this.ticket_page3.TabIndex = 0;
            this.ticket_page3.Text = "포토카드";
            this.ticket_page3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ticket_page3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ticket_page3.UseVisualStyleBackColor = false;
            // 
            // ticket_page1
            // 
            this.ticket_page1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ticket_page1.BackgroundImage = global::Kiosk.Properties.Resources.하늘5_1_01;
            this.ticket_page1.FlatAppearance.BorderSize = 0;
            this.ticket_page1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.ticket_page1.ForeColor = System.Drawing.Color.White;
            this.ticket_page1.Image = global::Kiosk.Properties.Resources.two_tickets_64px;
            this.ticket_page1.Location = new System.Drawing.Point(0, 51);
            this.ticket_page1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ticket_page1.Name = "ticket_page1";
            this.ticket_page1.Size = new System.Drawing.Size(120, 223);
            this.ticket_page1.TabIndex = 0;
            this.ticket_page1.Text = "티켓 구매";
            this.ticket_page1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ticket_page1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ticket_page1.UseVisualStyleBackColor = false;
            this.ticket_page1.Click += new System.EventHandler(this.ticket_page1_Click);
            // 
            // ticket_page2
            // 
            this.ticket_page2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ticket_page2.BackgroundImage = global::Kiosk.Properties.Resources.하늘5_1_02;
            this.ticket_page2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticket_page2.ForeColor = System.Drawing.Color.White;
            this.ticket_page2.Image = global::Kiosk.Properties.Resources.feed_paper_50px;
            this.ticket_page2.Location = new System.Drawing.Point(0, 274);
            this.ticket_page2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ticket_page2.Name = "ticket_page2";
            this.ticket_page2.Size = new System.Drawing.Size(120, 223);
            this.ticket_page2.TabIndex = 0;
            this.ticket_page2.Text = "예매티켓출력";
            this.ticket_page2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ticket_page2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ticket_page2.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(120, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 720);
            this.panel3.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Kiosk.Properties.Resources.test2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 720);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(520, 720);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ticket_page3;
        private System.Windows.Forms.Button ticket_page2;
        private System.Windows.Forms.Button ticket_page1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

