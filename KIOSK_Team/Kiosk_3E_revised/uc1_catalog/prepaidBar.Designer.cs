﻿namespace KIOSK_v1.uc1_catalog
{
    partial class prepaidBar
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
            this.barDateOrTime = new System.Windows.Forms.Label();
            this.barRating = new System.Windows.Forms.PictureBox();
            this.barLine = new System.Windows.Forms.Label();
            this.barMin = new System.Windows.Forms.Label();
            this.barRuntime = new System.Windows.Forms.Label();
            this.barTitle = new System.Windows.Forms.Label();
            this.barPoster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.barRating)).BeginInit();
            this.SuspendLayout();
            // 
            // barDateOrTime
            // 
            this.barDateOrTime.AutoSize = true;
            this.barDateOrTime.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.barDateOrTime.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.barDateOrTime.Location = new System.Drawing.Point(70, 12);
            this.barDateOrTime.Name = "barDateOrTime";
            this.barDateOrTime.Size = new System.Drawing.Size(120, 42);
            this.barDateOrTime.TabIndex = 77;
            this.barDateOrTime.Text = "0000-00-00\r\nor 00:00";
            this.barDateOrTime.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // barRating
            // 
            this.barRating.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.barRating.Location = new System.Drawing.Point(73, 67);
            this.barRating.Name = "barRating";
            this.barRating.Size = new System.Drawing.Size(15, 15);
            this.barRating.TabIndex = 76;
            this.barRating.TabStop = false;
            // 
            // barLine
            // 
            this.barLine.AutoSize = true;
            this.barLine.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.barLine.Location = new System.Drawing.Point(92, 69);
            this.barLine.Name = "barLine";
            this.barLine.Size = new System.Drawing.Size(12, 12);
            this.barLine.TabIndex = 75;
            this.barLine.Text = "|";
            // 
            // barMin
            // 
            this.barMin.AutoSize = true;
            this.barMin.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.barMin.Location = new System.Drawing.Point(127, 69);
            this.barMin.Name = "barMin";
            this.barMin.Size = new System.Drawing.Size(17, 12);
            this.barMin.TabIndex = 74;
            this.barMin.Text = "분";
            // 
            // barRuntime
            // 
            this.barRuntime.AutoSize = true;
            this.barRuntime.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.barRuntime.Location = new System.Drawing.Point(103, 69);
            this.barRuntime.Name = "barRuntime";
            this.barRuntime.Size = new System.Drawing.Size(23, 12);
            this.barRuntime.TabIndex = 73;
            this.barRuntime.Text = "000";
            // 
            // barTitle
            // 
            this.barTitle.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.barTitle.Location = new System.Drawing.Point(225, 18);
            this.barTitle.Name = "barTitle";
            this.barTitle.Size = new System.Drawing.Size(116, 42);
            this.barTitle.TabIndex = 72;
            this.barTitle.Text = "제목";
            // 
            // barPoster
            // 
            this.barPoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.barPoster.Enabled = false;
            this.barPoster.FlatAppearance.BorderSize = 0;
            this.barPoster.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.barPoster.Location = new System.Drawing.Point(3, 2);
            this.barPoster.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barPoster.Name = "barPoster";
            this.barPoster.Size = new System.Drawing.Size(61, 85);
            this.barPoster.TabIndex = 71;
            this.barPoster.UseVisualStyleBackColor = true;
            // 
            // prepaidBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.barDateOrTime);
            this.Controls.Add(this.barRating);
            this.Controls.Add(this.barLine);
            this.Controls.Add(this.barMin);
            this.Controls.Add(this.barRuntime);
            this.Controls.Add(this.barTitle);
            this.Controls.Add(this.barPoster);
            this.Name = "prepaidBar";
            this.Size = new System.Drawing.Size(351, 91);
            this.Click += new System.EventHandler(this.ticket_Click);
            ((System.ComponentModel.ISupportInitialize)(this.barRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label barDateOrTime;
        private System.Windows.Forms.PictureBox barRating;
        private System.Windows.Forms.Label barLine;
        private System.Windows.Forms.Label barMin;
        private System.Windows.Forms.Label barRuntime;
        private System.Windows.Forms.Label barTitle;
        private System.Windows.Forms.Button barPoster;
    }
}
