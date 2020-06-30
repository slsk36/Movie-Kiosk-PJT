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
            this.topAd = new System.Windows.Forms.Panel();
            this.bottomAd = new System.Windows.Forms.Panel();
            this.homeMenu = new System.Windows.Forms.Panel();
            this.nowTime = new System.Windows.Forms.Label();
            this.branch = new System.Windows.Forms.Label();
            this.today = new System.Windows.Forms.Label();
            this.buyTicket = new System.Windows.Forms.Label();
            this.bookedPrint = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.homeMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // topAd
            // 
            this.topAd.Dock = System.Windows.Forms.DockStyle.Top;
            this.topAd.Location = new System.Drawing.Point(0, 0);
            this.topAd.Name = "topAd";
            this.topAd.Size = new System.Drawing.Size(384, 200);
            this.topAd.TabIndex = 0;
            // 
            // bottomAd
            // 
            this.bottomAd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomAd.Location = new System.Drawing.Point(0, 481);
            this.bottomAd.Name = "bottomAd";
            this.bottomAd.Size = new System.Drawing.Size(384, 200);
            this.bottomAd.TabIndex = 1;
            // 
            // homeMenu
            // 
            this.homeMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeMenu.BackgroundImage")));
            this.homeMenu.Controls.Add(this.nowTime);
            this.homeMenu.Controls.Add(this.branch);
            this.homeMenu.Controls.Add(this.today);
            this.homeMenu.Controls.Add(this.buyTicket);
            this.homeMenu.Controls.Add(this.bookedPrint);
            this.homeMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeMenu.Location = new System.Drawing.Point(0, 200);
            this.homeMenu.Name = "homeMenu";
            this.homeMenu.Size = new System.Drawing.Size(384, 281);
            this.homeMenu.TabIndex = 2;
            // 
            // nowTime
            // 
            this.nowTime.AutoSize = true;
            this.nowTime.BackColor = System.Drawing.Color.Transparent;
            this.nowTime.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nowTime.ForeColor = System.Drawing.SystemColors.Control;
            this.nowTime.Location = new System.Drawing.Point(109, 74);
            this.nowTime.Name = "nowTime";
            this.nowTime.Size = new System.Drawing.Size(75, 24);
            this.nowTime.TabIndex = 5;
            this.nowTime.Text = "17:56";
            // 
            // branch
            // 
            this.branch.AutoSize = true;
            this.branch.BackColor = System.Drawing.Color.Transparent;
            this.branch.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.branch.ForeColor = System.Drawing.SystemColors.Control;
            this.branch.Location = new System.Drawing.Point(258, 46);
            this.branch.Name = "branch";
            this.branch.Size = new System.Drawing.Size(38, 11);
            this.branch.TabIndex = 4;
            this.branch.Text = "안산점";
            // 
            // today
            // 
            this.today.AutoSize = true;
            this.today.BackColor = System.Drawing.Color.Transparent;
            this.today.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.today.ForeColor = System.Drawing.SystemColors.Control;
            this.today.Location = new System.Drawing.Point(92, 46);
            this.today.Name = "today";
            this.today.Size = new System.Drawing.Size(82, 11);
            this.today.TabIndex = 3;
            this.today.Text = "2020.06.24 (수)";
            // 
            // buyTicket
            // 
            this.buyTicket.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buyTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buyTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buyTicket.ForeColor = System.Drawing.Color.White;
            this.buyTicket.Image = ((System.Drawing.Image)(resources.GetObject("buyTicket.Image")));
            this.buyTicket.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buyTicket.Location = new System.Drawing.Point(206, 119);
            this.buyTicket.Name = "buyTicket";
            this.buyTicket.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.buyTicket.Size = new System.Drawing.Size(90, 100);
            this.buyTicket.TabIndex = 2;
            this.buyTicket.Text = "티켓 구매";
            this.buyTicket.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buyTicket.Click += new System.EventHandler(this.buyTicket_Click);
            // 
            // bookedPrint
            // 
            this.bookedPrint.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.bookedPrint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookedPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookedPrint.ForeColor = System.Drawing.Color.White;
            this.bookedPrint.Image = ((System.Drawing.Image)(resources.GetObject("bookedPrint.Image")));
            this.bookedPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bookedPrint.Location = new System.Drawing.Point(94, 119);
            this.bookedPrint.Name = "bookedPrint";
            this.bookedPrint.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.bookedPrint.Size = new System.Drawing.Size(90, 100);
            this.bookedPrint.TabIndex = 1;
            this.bookedPrint.Text = "예매 티켓 출력";
            this.bookedPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            // uc0_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.homeMenu);
            this.Controls.Add(this.bottomAd);
            this.Controls.Add(this.topAd);
            this.Name = "uc0_Home";
            this.Size = new System.Drawing.Size(384, 681);
            this.homeMenu.ResumeLayout(false);
            this.homeMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topAd;
        private System.Windows.Forms.Panel bottomAd;
        private System.Windows.Forms.Panel homeMenu;
        private System.Windows.Forms.Label bookedPrint;
        private System.Windows.Forms.Label buyTicket;
        private System.Windows.Forms.Label branch;
        private System.Windows.Forms.Label today;
        private System.Windows.Forms.Label nowTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
