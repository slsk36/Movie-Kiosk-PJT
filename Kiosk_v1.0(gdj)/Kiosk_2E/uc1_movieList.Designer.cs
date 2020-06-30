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
            this.choiceByMovie = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.movie1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.moive4 = new System.Windows.Forms.Button();
            this.movie3 = new System.Windows.Forms.Button();
            this.movie2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.selectTab = new System.Windows.Forms.TabControl();
            this.label5 = new System.Windows.Forms.Label();
            this.choiceByMovie.SuspendLayout();
            this.selectTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // choiceByTime
            // 
            this.choiceByTime.Location = new System.Drawing.Point(4, 34);
            this.choiceByTime.Name = "choiceByTime";
            this.choiceByTime.Padding = new System.Windows.Forms.Padding(3);
            this.choiceByTime.Size = new System.Drawing.Size(376, 583);
            this.choiceByTime.TabIndex = 1;
            this.choiceByTime.Text = "시간대별 선택";
            this.choiceByTime.UseVisualStyleBackColor = true;
            // 
            // choiceByMovie
            // 
            this.choiceByMovie.Controls.Add(this.label5);
            this.choiceByMovie.Controls.Add(this.dateTimePicker1);
            this.choiceByMovie.Controls.Add(this.movie1);
            this.choiceByMovie.Controls.Add(this.label4);
            this.choiceByMovie.Controls.Add(this.label2);
            this.choiceByMovie.Controls.Add(this.label1);
            this.choiceByMovie.Controls.Add(this.moive4);
            this.choiceByMovie.Controls.Add(this.movie3);
            this.choiceByMovie.Controls.Add(this.movie2);
            this.choiceByMovie.Controls.Add(this.label3);
            this.choiceByMovie.Location = new System.Drawing.Point(4, 34);
            this.choiceByMovie.Name = "choiceByMovie";
            this.choiceByMovie.Padding = new System.Windows.Forms.Padding(3);
            this.choiceByMovie.Size = new System.Drawing.Size(376, 583);
            this.choiceByMovie.TabIndex = 0;
            this.choiceByMovie.Text = "영화별 선택";
            this.choiceByMovie.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(178, 17);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(173, 25);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // movie1
            // 
            this.movie1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("movie1.BackgroundImage")));
            this.movie1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.movie1.FlatAppearance.BorderSize = 0;
            this.movie1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.movie1.Location = new System.Drawing.Point(29, 60);
            this.movie1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.movie1.Name = "movie1";
            this.movie1.Size = new System.Drawing.Size(147, 215);
            this.movie1.TabIndex = 19;
            this.movie1.UseVisualStyleBackColor = true;
            this.movie1.Click += new System.EventHandler(this.movie1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(201, 537);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 14);
            this.label4.TabIndex = 18;
            this.label4.Text = "프리즌 이스케이프 | 106분";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 537);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "반도 | 116분";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 14);
            this.label1.TabIndex = 16;
            this.label1.Text = "#살아있다 | 98분";
            // 
            // moive4
            // 
            this.moive4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("moive4.BackgroundImage")));
            this.moive4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.moive4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.moive4.Location = new System.Drawing.Point(204, 318);
            this.moive4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.moive4.Name = "moive4";
            this.moive4.Size = new System.Drawing.Size(147, 215);
            this.moive4.TabIndex = 15;
            this.moive4.UseVisualStyleBackColor = true;
            // 
            // movie3
            // 
            this.movie3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("movie3.BackgroundImage")));
            this.movie3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.movie3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.movie3.Location = new System.Drawing.Point(29, 318);
            this.movie3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.movie3.Name = "movie3";
            this.movie3.Size = new System.Drawing.Size(147, 215);
            this.movie3.TabIndex = 14;
            this.movie3.UseVisualStyleBackColor = true;
            // 
            // movie2
            // 
            this.movie2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("movie2.BackgroundImage")));
            this.movie2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.movie2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.movie2.Location = new System.Drawing.Point(204, 60);
            this.movie2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.movie2.Name = "movie2";
            this.movie2.Size = new System.Drawing.Size(147, 215);
            this.movie2.TabIndex = 13;
            this.movie2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "토르 | 112분";
            // 
            // selectTab
            // 
            this.selectTab.Controls.Add(this.choiceByMovie);
            this.selectTab.Controls.Add(this.choiceByTime);
            this.selectTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectTab.ItemSize = new System.Drawing.Size(190, 30);
            this.selectTab.Location = new System.Drawing.Point(0, 0);
            this.selectTab.Name = "selectTab";
            this.selectTab.SelectedIndex = 0;
            this.selectTab.Size = new System.Drawing.Size(384, 621);
            this.selectTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.selectTab.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(28, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "영화예매";
            // 
            // uc1_movieChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectTab);
            this.Name = "uc1_movieChoice";
            this.Size = new System.Drawing.Size(384, 621);
            this.choiceByMovie.ResumeLayout(false);
            this.choiceByMovie.PerformLayout();
            this.selectTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage choiceByTime;
        private System.Windows.Forms.TabPage choiceByMovie;
        private System.Windows.Forms.TabControl selectTab;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button movie1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button moive4;
        private System.Windows.Forms.Button movie3;
        private System.Windows.Forms.Button movie2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}
