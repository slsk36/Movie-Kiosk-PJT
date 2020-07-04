namespace Kiosk_2E
{
    partial class uc2_movie1Round
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
            this.selectedMovie = new System.Windows.Forms.Label();
            this.movieTitle = new System.Windows.Forms.Label();
            this.cbRound = new System.Windows.Forms.ComboBox();
            this.cbDate = new System.Windows.Forms.ComboBox();
            this.leftSeat = new System.Windows.Forms.Label();
            this.leftStNm = new System.Windows.Forms.Label();
            this.goSelectSeat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pbMovie = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // selectedMovie
            // 
            this.selectedMovie.AutoSize = true;
            this.selectedMovie.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedMovie.Location = new System.Drawing.Point(57, 41);
            this.selectedMovie.Name = "selectedMovie";
            this.selectedMovie.Size = new System.Drawing.Size(157, 23);
            this.selectedMovie.TabIndex = 15;
            this.selectedMovie.Text = "선택하신 영화입니다.";
            // 
            // movieTitle
            // 
            this.movieTitle.AutoSize = true;
            this.movieTitle.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.movieTitle.Location = new System.Drawing.Point(53, 604);
            this.movieTitle.Name = "movieTitle";
            this.movieTitle.Size = new System.Drawing.Size(73, 30);
            this.movieTitle.TabIndex = 12;
            this.movieTitle.Text = "토르";
            // 
            // cbRound
            // 
            this.cbRound.FormattingEnabled = true;
            this.cbRound.Location = new System.Drawing.Point(57, 689);
            this.cbRound.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbRound.Name = "cbRound";
            this.cbRound.Size = new System.Drawing.Size(203, 23);
            this.cbRound.TabIndex = 22;
            this.cbRound.Text = "시간선택";
            this.cbRound.SelectedIndexChanged += new System.EventHandler(this.cbRound_SelectedIndexChanged);
            // 
            // cbDate
            // 
            this.cbDate.FormattingEnabled = true;
            this.cbDate.Location = new System.Drawing.Point(57, 653);
            this.cbDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(203, 23);
            this.cbDate.TabIndex = 21;
            this.cbDate.Text = "관람일자";
            this.cbDate.SelectedIndexChanged += new System.EventHandler(this.cbDate_SelectedIndexChanged);
            // 
            // leftSeat
            // 
            this.leftSeat.AutoSize = true;
            this.leftSeat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftSeat.Location = new System.Drawing.Point(54, 722);
            this.leftSeat.Name = "leftSeat";
            this.leftSeat.Size = new System.Drawing.Size(114, 23);
            this.leftSeat.TabIndex = 20;
            this.leftSeat.Text = "잔여 좌석 수 : ";
            // 
            // leftStNm
            // 
            this.leftStNm.BackColor = System.Drawing.Color.White;
            this.leftStNm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leftStNm.Location = new System.Drawing.Point(181, 721);
            this.leftStNm.Name = "leftStNm";
            this.leftStNm.Size = new System.Drawing.Size(79, 28);
            this.leftStNm.TabIndex = 23;
            this.leftStNm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goSelectSeat
            // 
            this.goSelectSeat.BackgroundImage = global::Kiosk_2E.Properties.Resources.homeMenu_BG;
            this.goSelectSeat.FlatAppearance.BorderSize = 0;
            this.goSelectSeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goSelectSeat.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.goSelectSeat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.goSelectSeat.Location = new System.Drawing.Point(302, 653);
            this.goSelectSeat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.goSelectSeat.Name = "goSelectSeat";
            this.goSelectSeat.Size = new System.Drawing.Size(89, 95);
            this.goSelectSeat.TabIndex = 24;
            this.goSelectSeat.Text = "좌석 선택";
            this.goSelectSeat.UseVisualStyleBackColor = true;
            this.goSelectSeat.Click += new System.EventHandler(this.goSelectSeat_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Kiosk_2E.Properties.Resources.undo_60px;
            this.button1.Location = new System.Drawing.Point(361, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 69);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbMovie
            // 
            this.pbMovie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMovie.Location = new System.Drawing.Point(62, 95);
            this.pbMovie.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pbMovie.Name = "pbMovie";
            this.pbMovie.Size = new System.Drawing.Size(299, 458);
            this.pbMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMovie.TabIndex = 25;
            this.pbMovie.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(0, 781);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(121, 94);
            this.listBox1.TabIndex = 27;
            // 
            // uc2_movie1Round
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbMovie);
            this.Controls.Add(this.goSelectSeat);
            this.Controls.Add(this.leftStNm);
            this.Controls.Add(this.cbRound);
            this.Controls.Add(this.cbDate);
            this.Controls.Add(this.leftSeat);
            this.Controls.Add(this.selectedMovie);
            this.Controls.Add(this.movieTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uc2_movie1Round";
            this.Size = new System.Drawing.Size(439, 851);
            ((System.ComponentModel.ISupportInitialize)(this.pbMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label selectedMovie;
        private System.Windows.Forms.Label movieTitle;
        private System.Windows.Forms.ComboBox cbRound;
        private System.Windows.Forms.ComboBox cbDate;
        private System.Windows.Forms.Label leftSeat;
        private System.Windows.Forms.Label leftStNm;
        private System.Windows.Forms.Button goSelectSeat;
        private System.Windows.Forms.PictureBox pbMovie;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
    }
}
