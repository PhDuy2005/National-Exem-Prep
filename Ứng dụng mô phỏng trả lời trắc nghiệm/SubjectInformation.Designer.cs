namespace Ứng_dụng_mô_phỏng_trả_lời_trắc_nghiệm
{
    partial class SubjectInformation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_title = new System.Windows.Forms.Label();
            this.lb_subject = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.lb_numberOfQuestion = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.lb_examType = new System.Windows.Forms.Label();
            this.btn_loadQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lb_title.Location = new System.Drawing.Point(-1, -1);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(806, 129);
            this.lb_title.TabIndex = 0;
            this.lb_title.Text = "MÔ PHỎNG PHIẾU TRẢ LỜI TRẮC NGHIỆM THPTQG THEO CHƯƠNG TRÌNH GDPT 2018";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_subject
            // 
            this.lb_subject.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lb_subject.Location = new System.Drawing.Point(1, 128);
            this.lb_subject.Name = "lb_subject";
            this.lb_subject.Size = new System.Drawing.Size(806, 57);
            this.lb_subject.TabIndex = 1;
            this.lb_subject.Text = "Môn học:";
            this.lb_subject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_time
            // 
            this.lb_time.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lb_time.Location = new System.Drawing.Point(-1, 185);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(806, 57);
            this.lb_time.TabIndex = 2;
            this.lb_time.Text = "Thời gian:";
            this.lb_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_numberOfQuestion
            // 
            this.lb_numberOfQuestion.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lb_numberOfQuestion.Location = new System.Drawing.Point(1, 242);
            this.lb_numberOfQuestion.Name = "lb_numberOfQuestion";
            this.lb_numberOfQuestion.Size = new System.Drawing.Size(806, 57);
            this.lb_numberOfQuestion.TabIndex = 3;
            this.lb_numberOfQuestion.Text = "Số câu hỏi:";
            this.lb_numberOfQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_start.Enabled = false;
            this.btn_start.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_start.Location = new System.Drawing.Point(495, 359);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(126, 52);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Bắt đầu";
            this.btn_start.UseVisualStyleBackColor = false;
            // 
            // lb_examType
            // 
            this.lb_examType.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lb_examType.Location = new System.Drawing.Point(-1, 299);
            this.lb_examType.Name = "lb_examType";
            this.lb_examType.Size = new System.Drawing.Size(806, 57);
            this.lb_examType.TabIndex = 5;
            this.lb_examType.Text = "Dạng đề:";
            this.lb_examType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_loadQuestion
            // 
            this.btn_loadQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_loadQuestion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_loadQuestion.Location = new System.Drawing.Point(182, 359);
            this.btn_loadQuestion.Name = "btn_loadQuestion";
            this.btn_loadQuestion.Size = new System.Drawing.Size(126, 52);
            this.btn_loadQuestion.TabIndex = 6;
            this.btn_loadQuestion.Text = "Nạp đề";
            this.btn_loadQuestion.UseVisualStyleBackColor = false;
            // 
            // SubjectInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.btn_loadQuestion);
            this.Controls.Add(this.lb_examType);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lb_numberOfQuestion);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.lb_subject);
            this.Controls.Add(this.lb_title);
            this.Name = "SubjectInformation";
            this.Text = "SubjectInformation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_subject;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Label lb_numberOfQuestion;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lb_examType;
        private System.Windows.Forms.Button btn_loadQuestion;
    }
}