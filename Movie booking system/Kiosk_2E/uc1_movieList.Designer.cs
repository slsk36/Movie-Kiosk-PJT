namespace Kiosk_2E
{
    partial class uc1_movieList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc1_movieList));
            this.choiceByTime = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.choiceByMovie = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.title3 = new System.Windows.Forms.Label();
            this.title2 = new System.Windows.Forms.Label();
            this.title1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.movie1 = new System.Windows.Forms.Button();
            this.movie4 = new System.Windows.Forms.Button();
            this.movie3 = new System.Windows.Forms.Button();
            this.movie2 = new System.Windows.Forms.Button();
            this.selectTab = new System.Windows.Forms.TabControl();
            this.choiceByTime.SuspendLayout();
            this.choiceByMovie.SuspendLayout();
            this.selectTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // choiceByTime
            // 
            this.choiceByTime.Controls.Add(this.dateTimePicker1);
            this.choiceByTime.Location = new System.Drawing.Point(4, 34);
            this.choiceByTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.choiceByTime.Name = "choiceByTime";
            this.choiceByTime.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.choiceByTime.Size = new System.Drawing.Size(431, 751);
            this.choiceByTime.TabIndex = 1;
            this.choiceByTime.Text = "시간대별 선택";
            this.choiceByTime.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(96, 355);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 29);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // choiceByMovie
            // 
            this.choiceByMovie.Controls.Add(this.label4);
            this.choiceByMovie.Controls.Add(this.title3);
            this.choiceByMovie.Controls.Add(this.title2);
            this.choiceByMovie.Controls.Add(this.title1);
            this.choiceByMovie.Controls.Add(this.label5);
            this.choiceByMovie.Controls.Add(this.movie1);
            this.choiceByMovie.Controls.Add(this.movie4);
            this.choiceByMovie.Controls.Add(this.movie3);
            this.choiceByMovie.Controls.Add(this.movie2);
            this.choiceByMovie.Location = new System.Drawing.Point(4, 34);
            this.choiceByMovie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.choiceByMovie.Name = "choiceByMovie";
            this.choiceByMovie.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.choiceByMovie.Size = new System.Drawing.Size(431, 751);
            this.choiceByMovie.TabIndex = 0;
            this.choiceByMovie.Text = "영화별 선택";
            this.choiceByMovie.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(224, 678);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "프리즌 이스케이프";
            // 
            // title3
            // 
            this.title3.AutoSize = true;
            this.title3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title3.Location = new System.Drawing.Point(23, 678);
            this.title3.Name = "title3";
            this.title3.Size = new System.Drawing.Size(40, 23);
            this.title3.TabIndex = 28;
            this.title3.Text = "반도";
            // 
            // title2
            // 
            this.title2.AutoSize = true;
            this.title2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title2.Location = new System.Drawing.Point(223, 355);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(157, 23);
            this.title2.TabIndex = 27;
            this.title2.Text = "온워드 단 하루의 기적";
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title1.Location = new System.Drawing.Point(23, 355);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(89, 23);
            this.title1.TabIndex = 26;
            this.title1.Text = "위대한 쇼맨";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 37);
            this.label5.TabIndex = 21;
            this.label5.Text = "영화예매";
            // 
            // movie1
            // 
            this.movie1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("movie1.BackgroundImage")));
            this.movie1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.movie1.FlatAppearance.BorderSize = 0;
            this.movie1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.movie1.Location = new System.Drawing.Point(26, 75);
            this.movie1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.movie1.Name = "movie1";
            this.movie1.Size = new System.Drawing.Size(177, 275);
            this.movie1.TabIndex = 19;
            this.movie1.UseVisualStyleBackColor = true;
            this.movie1.Click += new System.EventHandler(this.movie1_Click);
            // 
            // movie4
            // 
            this.movie4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("movie4.BackgroundImage")));
            this.movie4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.movie4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.movie4.Location = new System.Drawing.Point(226, 398);
            this.movie4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.movie4.Name = "movie4";
            this.movie4.Size = new System.Drawing.Size(177, 275);
            this.movie4.TabIndex = 15;
            this.movie4.UseVisualStyleBackColor = true;
            this.movie4.Click += new System.EventHandler(this.moive4_Click);
            // 
            // movie3
            // 
            this.movie3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("movie3.BackgroundImage")));
            this.movie3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.movie3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.movie3.Location = new System.Drawing.Point(26, 398);
            this.movie3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.movie3.Name = "movie3";
            this.movie3.Size = new System.Drawing.Size(177, 275);
            this.movie3.TabIndex = 14;
            this.movie3.UseVisualStyleBackColor = true;
            this.movie3.Click += new System.EventHandler(this.movie3_Click);
            // 
            // movie2
            // 
            this.movie2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("movie2.BackgroundImage")));
            this.movie2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.movie2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.movie2.Location = new System.Drawing.Point(226, 75);
            this.movie2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.movie2.Name = "movie2";
            this.movie2.Size = new System.Drawing.Size(177, 275);
            this.movie2.TabIndex = 13;
            this.movie2.UseVisualStyleBackColor = true;
            this.movie2.Click += new System.EventHandler(this.movie2_Click);
            // 
            // selectTab
            // 
            this.selectTab.Controls.Add(this.choiceByMovie);
            this.selectTab.Controls.Add(this.choiceByTime);
            this.selectTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectTab.ItemSize = new System.Drawing.Size(190, 30);
            this.selectTab.Location = new System.Drawing.Point(0, 0);
            this.selectTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selectTab.Name = "selectTab";
            this.selectTab.SelectedIndex = 0;
            this.selectTab.Size = new System.Drawing.Size(439, 789);
            this.selectTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.selectTab.TabIndex = 0;
            // 
            // uc1_movieList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectTab);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uc1_movieList";
            this.Size = new System.Drawing.Size(439, 789);
            this.choiceByTime.ResumeLayout(false);
            this.choiceByMovie.ResumeLayout(false);
            this.choiceByMovie.PerformLayout();
            this.selectTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage choiceByTime;
        private System.Windows.Forms.TabPage choiceByMovie;
        private System.Windows.Forms.TabControl selectTab;
        private System.Windows.Forms.Button movie1;
        private System.Windows.Forms.Button movie4;
        private System.Windows.Forms.Button movie3;
        private System.Windows.Forms.Button movie2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label title3;
        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.Label title1;
    }
}
