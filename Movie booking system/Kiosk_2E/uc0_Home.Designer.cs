namespace Kiosk_2E
{
    partial class uc0_Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc0_Home));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.homeMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.today = new System.Windows.Forms.Label();
            this.buyTicket = new System.Windows.Forms.Label();
            this.bookedPrint = new System.Windows.Forms.Label();
            this.nowTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.homeMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // homeMenu
            // 
            this.homeMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeMenu.Controls.Add(this.button1);
            this.homeMenu.Controls.Add(this.today);
            this.homeMenu.Controls.Add(this.buyTicket);
            this.homeMenu.Controls.Add(this.bookedPrint);
            this.homeMenu.Controls.Add(this.nowTime);
            this.homeMenu.Controls.Add(this.pictureBox1);
            this.homeMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeMenu.Location = new System.Drawing.Point(0, 0);
            this.homeMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.homeMenu.Name = "homeMenu";
            this.homeMenu.Size = new System.Drawing.Size(439, 851);
            this.homeMenu.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Kiosk_2E.Properties.Resources.homeMenu_BG;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(41, 593);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(349, 78);
            this.button1.TabIndex = 7;
            this.button1.Text = "취소 및 환불";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // today
            // 
            this.today.AutoSize = true;
            this.today.BackColor = System.Drawing.Color.Transparent;
            this.today.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.today.ForeColor = System.Drawing.Color.White;
            this.today.Location = new System.Drawing.Point(42, 240);
            this.today.Name = "today";
            this.today.Size = new System.Drawing.Size(268, 46);
            this.today.TabIndex = 3;
            this.today.Text = "2020.06.24 (수)";
            // 
            // buyTicket
            // 
            this.buyTicket.BackColor = System.Drawing.Color.Transparent;
            this.buyTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buyTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buyTicket.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buyTicket.ForeColor = System.Drawing.Color.White;
            this.buyTicket.Image = ((System.Drawing.Image)(resources.GetObject("buyTicket.Image")));
            this.buyTicket.Location = new System.Drawing.Point(219, 414);
            this.buyTicket.Name = "buyTicket";
            this.buyTicket.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.buyTicket.Size = new System.Drawing.Size(171, 176);
            this.buyTicket.TabIndex = 2;
            this.buyTicket.Text = "티켓 구매";
            this.buyTicket.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buyTicket.Click += new System.EventHandler(this.buyTicket_Click);
            // 
            // bookedPrint
            // 
            this.bookedPrint.BackColor = System.Drawing.Color.Transparent;
            this.bookedPrint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookedPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookedPrint.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bookedPrint.ForeColor = System.Drawing.Color.White;
            this.bookedPrint.Image = ((System.Drawing.Image)(resources.GetObject("bookedPrint.Image")));
            this.bookedPrint.Location = new System.Drawing.Point(41, 414);
            this.bookedPrint.Name = "bookedPrint";
            this.bookedPrint.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.bookedPrint.Size = new System.Drawing.Size(171, 176);
            this.bookedPrint.TabIndex = 1;
            this.bookedPrint.Text = "예매티켓출력";
            this.bookedPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bookedPrint.Click += new System.EventHandler(this.bookedPrint_Click);
            // 
            // nowTime
            // 
            this.nowTime.AutoSize = true;
            this.nowTime.BackColor = System.Drawing.Color.Transparent;
            this.nowTime.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nowTime.ForeColor = System.Drawing.SystemColors.Control;
            this.nowTime.Location = new System.Drawing.Point(38, 305);
            this.nowTime.Name = "nowTime";
            this.nowTime.Size = new System.Drawing.Size(191, 81);
            this.nowTime.TabIndex = 5;
            this.nowTime.Text = "17:56";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(439, 851);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // uc0_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.homeMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uc0_Home";
            this.Size = new System.Drawing.Size(439, 851);
            this.homeMenu.ResumeLayout(false);
            this.homeMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel homeMenu;
        private System.Windows.Forms.Label bookedPrint;
        private System.Windows.Forms.Label buyTicket;
        private System.Windows.Forms.Label today;
        private System.Windows.Forms.Label nowTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}
