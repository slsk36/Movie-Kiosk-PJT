namespace Kiosk_2E
{
    partial class 티켓출력cs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(티켓출력cs));
            this.panelTop = new System.Windows.Forms.Panel();
            this.doneTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.doneGoHome = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTop.Controls.Add(this.doneTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.ForeColor = System.Drawing.Color.Black;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(439, 66);
            this.panelTop.TabIndex = 20;
            // 
            // doneTitle
            // 
            this.doneTitle.AutoSize = true;
            this.doneTitle.BackColor = System.Drawing.Color.Transparent;
            this.doneTitle.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.doneTitle.ForeColor = System.Drawing.Color.White;
            this.doneTitle.Location = new System.Drawing.Point(3, 11);
            this.doneTitle.Name = "doneTitle";
            this.doneTitle.Size = new System.Drawing.Size(220, 41);
            this.doneTitle.TabIndex = 0;
            this.doneTitle.Text = "예매 티켓 출력";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.doneGoHome);
            this.panel2.Controls.Add(this.enter);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.del);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.input);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 785);
            this.panel2.TabIndex = 21;
            // 
            // doneGoHome
            // 
            this.doneGoHome.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.doneGoHome.Location = new System.Drawing.Point(147, 607);
            this.doneGoHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.doneGoHome.Name = "doneGoHome";
            this.doneGoHome.Size = new System.Drawing.Size(151, 76);
            this.doneGoHome.TabIndex = 30;
            this.doneGoHome.Text = "처음으로";
            this.doneGoHome.UseVisualStyleBackColor = true;
            this.doneGoHome.Click += new System.EventHandler(this.doneGoHome_Click);
            // 
            // enter
            // 
            this.enter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enter.BackgroundImage")));
            this.enter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enter.CausesValidation = false;
            this.enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enter.FlatAppearance.BorderSize = 0;
            this.enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enter.Location = new System.Drawing.Point(272, 446);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(76, 78);
            this.enter.TabIndex = 29;
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // button11
            // 
            this.button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button11.BackgroundImage")));
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button11.CausesValidation = false;
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(172, 441);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(92, 88);
            this.button11.TabIndex = 28;
            this.button11.Tag = "0";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.num_click);
            // 
            // del
            // 
            this.del.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("del.BackgroundImage")));
            this.del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.del.CausesValidation = false;
            this.del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.del.FlatAppearance.BorderSize = 0;
            this.del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del.Location = new System.Drawing.Point(88, 447);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(76, 78);
            this.del.TabIndex = 27;
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.CausesValidation = false;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(265, 362);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(92, 88);
            this.button7.TabIndex = 26;
            this.button7.Tag = "9";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.num_click);
            // 
            // button8
            // 
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.CausesValidation = false;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(172, 362);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(92, 88);
            this.button8.TabIndex = 25;
            this.button8.Tag = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.num_click);
            // 
            // button9
            // 
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.CausesValidation = false;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(80, 362);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(92, 88);
            this.button9.TabIndex = 24;
            this.button9.Tag = "7";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.num_click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.CausesValidation = false;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(265, 284);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 88);
            this.button4.TabIndex = 23;
            this.button4.Tag = "6";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.num_click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.CausesValidation = false;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(172, 284);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 88);
            this.button5.TabIndex = 22;
            this.button5.Tag = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.num_click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.CausesValidation = false;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(80, 284);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 88);
            this.button6.TabIndex = 21;
            this.button6.Tag = "4";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.num_click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.CausesValidation = false;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(265, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 88);
            this.button3.TabIndex = 20;
            this.button3.Tag = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.num_click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.CausesValidation = false;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(172, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 88);
            this.button2.TabIndex = 19;
            this.button2.Tag = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.num_click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.CausesValidation = false;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.button1.Location = new System.Drawing.Point(80, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 88);
            this.button1.TabIndex = 18;
            this.button1.Tag = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.num_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(76, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "예매 번호 7자리를 입력해 주세요";
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.Color.White;
            this.input.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.input.Location = new System.Drawing.Point(64, 71);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(339, 46);
            this.input.TabIndex = 4;
            this.input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 티켓출력cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTop);
            this.Name = "티켓출력cs";
            this.Size = new System.Drawing.Size(439, 851);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label doneTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button doneGoHome;
    }
}
