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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc2_movie1Round));
            this.selectedMovie = new System.Windows.Forms.Label();
            this.movieTitle = new System.Windows.Forms.Label();
            this.runningTime = new System.Windows.Forms.Label();
            this.vLine = new System.Windows.Forms.Label();
            this.cbRound = new System.Windows.Forms.ComboBox();
            this.cbDate = new System.Windows.Forms.ComboBox();
            this.leftSeat = new System.Windows.Forms.Label();
            this.leftStNm = new System.Windows.Forms.Label();
            this.goSelectSeat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pbMovie = new System.Windows.Forms.PictureBox();
            this.rating = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rating)).BeginInit();
            this.SuspendLayout();
            // 
            // selectedMovie
            // 
            this.selectedMovie.AutoSize = true;
            this.selectedMovie.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedMovie.Location = new System.Drawing.Point(47, 75);
            this.selectedMovie.Name = "selectedMovie";
            this.selectedMovie.Size = new System.Drawing.Size(170, 19);
            this.selectedMovie.TabIndex = 15;
            this.selectedMovie.Text = "선택하신 영화입니다.";
            // 
            // movieTitle
            // 
            this.movieTitle.AutoSize = true;
            this.movieTitle.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.movieTitle.Location = new System.Drawing.Point(82, 502);
            this.movieTitle.Name = "movieTitle";
            this.movieTitle.Size = new System.Drawing.Size(58, 24);
            this.movieTitle.TabIndex = 12;
            this.movieTitle.Text = "토르";
            // 
            // runningTime
            // 
            this.runningTime.AutoSize = true;
            this.runningTime.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.runningTime.Location = new System.Drawing.Point(247, 508);
            this.runningTime.Name = "runningTime";
            this.runningTime.Size = new System.Drawing.Size(32, 16);
            this.runningTime.TabIndex = 17;
            this.runningTime.Text = "112";
            // 
            // vLine
            // 
            this.vLine.AutoSize = true;
            this.vLine.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.vLine.Location = new System.Drawing.Point(227, 505);
            this.vLine.Name = "vLine";
            this.vLine.Size = new System.Drawing.Size(21, 21);
            this.vLine.TabIndex = 19;
            this.vLine.Text = "|";
            // 
            // cbRound
            // 
            this.cbRound.FormattingEnabled = true;
            this.cbRound.Location = new System.Drawing.Point(51, 567);
            this.cbRound.Name = "cbRound";
            this.cbRound.Size = new System.Drawing.Size(178, 20);
            this.cbRound.TabIndex = 22;
            this.cbRound.Text = "시간선택";
            this.cbRound.SelectedIndexChanged += new System.EventHandler(this.cbRound_SelectedIndexChanged);
            // 
            // cbDate
            // 
            this.cbDate.FormattingEnabled = true;
            this.cbDate.Location = new System.Drawing.Point(51, 538);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(178, 20);
            this.cbDate.TabIndex = 21;
            this.cbDate.Text = "관람일자";
            this.cbDate.SelectedIndexChanged += new System.EventHandler(this.cbDate_SelectedIndexChanged);
            // 
            // leftSeat
            // 
            this.leftSeat.AutoSize = true;
            this.leftSeat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftSeat.Location = new System.Drawing.Point(49, 593);
            this.leftSeat.Name = "leftSeat";
            this.leftSeat.Size = new System.Drawing.Size(110, 21);
            this.leftSeat.TabIndex = 20;
            this.leftSeat.Text = "잔여 좌석 수 : ";
            // 
            // leftStNm
            // 
            this.leftStNm.BackColor = System.Drawing.Color.White;
            this.leftStNm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leftStNm.Location = new System.Drawing.Point(160, 592);
            this.leftStNm.Name = "leftStNm";
            this.leftStNm.Size = new System.Drawing.Size(69, 23);
            this.leftStNm.TabIndex = 23;
            this.leftStNm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goSelectSeat
            // 
            this.goSelectSeat.Location = new System.Drawing.Point(235, 538);
            this.goSelectSeat.Name = "goSelectSeat";
            this.goSelectSeat.Size = new System.Drawing.Size(78, 76);
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
            this.button1.Location = new System.Drawing.Point(282, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 55);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbMovie
            // 
            this.pbMovie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMovie.Location = new System.Drawing.Point(51, 118);
            this.pbMovie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbMovie.Name = "pbMovie";
            this.pbMovie.Size = new System.Drawing.Size(262, 367);
            this.pbMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMovie.TabIndex = 25;
            this.pbMovie.TabStop = false;
            // 
            // rating
            // 
            this.rating.Image = ((System.Drawing.Image)(resources.GetObject("rating.Image")));
            this.rating.Location = new System.Drawing.Point(51, 502);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(36, 25);
            this.rating.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rating.TabIndex = 16;
            this.rating.TabStop = false;
            // 
            // uc2_movie1Round
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbMovie);
            this.Controls.Add(this.goSelectSeat);
            this.Controls.Add(this.leftStNm);
            this.Controls.Add(this.cbRound);
            this.Controls.Add(this.cbDate);
            this.Controls.Add(this.leftSeat);
            this.Controls.Add(this.vLine);
            this.Controls.Add(this.runningTime);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.selectedMovie);
            this.Controls.Add(this.movieTitle);
            this.Name = "uc2_movie1Round";
            this.Size = new System.Drawing.Size(384, 681);
            ((System.ComponentModel.ISupportInitialize)(this.pbMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox rating;
        private System.Windows.Forms.Label selectedMovie;
        private System.Windows.Forms.Label movieTitle;
        private System.Windows.Forms.Label runningTime;
        private System.Windows.Forms.Label vLine;
        private System.Windows.Forms.ComboBox cbRound;
        private System.Windows.Forms.ComboBox cbDate;
        private System.Windows.Forms.Label leftSeat;
        private System.Windows.Forms.Label leftStNm;
        private System.Windows.Forms.Button goSelectSeat;
        private System.Windows.Forms.PictureBox pbMovie;
        private System.Windows.Forms.Button button1;
    }
}
