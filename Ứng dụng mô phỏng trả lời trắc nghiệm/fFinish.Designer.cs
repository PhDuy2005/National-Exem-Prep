namespace Ứng_dụng_mô_phỏng_trả_lời_trắc_nghiệm
{
    partial class fFinish
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
            this.lb_finalScore = new System.Windows.Forms.Label();
            this.lb_part3 = new System.Windows.Forms.Label();
            this.lb_part2 = new System.Windows.Forms.Label();
            this.lb_part1 = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.btn_exportFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_finalScore
            // 
            this.lb_finalScore.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lb_finalScore.Location = new System.Drawing.Point(-4, 319);
            this.lb_finalScore.Name = "lb_finalScore";
            this.lb_finalScore.Size = new System.Drawing.Size(806, 57);
            this.lb_finalScore.TabIndex = 12;
            this.lb_finalScore.Text = "Tổng điểm";
            this.lb_finalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_part3
            // 
            this.lb_part3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lb_part3.Location = new System.Drawing.Point(-2, 262);
            this.lb_part3.Name = "lb_part3";
            this.lb_part3.Size = new System.Drawing.Size(806, 57);
            this.lb_part3.TabIndex = 11;
            this.lb_part3.Text = "Phần III";
            this.lb_part3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_part2
            // 
            this.lb_part2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lb_part2.Location = new System.Drawing.Point(-4, 205);
            this.lb_part2.Name = "lb_part2";
            this.lb_part2.Size = new System.Drawing.Size(806, 57);
            this.lb_part2.TabIndex = 10;
            this.lb_part2.Text = "Phần II";
            this.lb_part2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_part1
            // 
            this.lb_part1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lb_part1.Location = new System.Drawing.Point(-2, 148);
            this.lb_part1.Name = "lb_part1";
            this.lb_part1.Size = new System.Drawing.Size(806, 57);
            this.lb_part1.TabIndex = 9;
            this.lb_part1.Text = "Phần I";
            this.lb_part1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_title
            // 
            this.lb_title.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lb_title.Location = new System.Drawing.Point(-4, 19);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(806, 129);
            this.lb_title.TabIndex = 8;
            this.lb_title.Text = "KẾT QUẢ KIỂM TRA";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_exportFile
            // 
            this.btn_exportFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_exportFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_exportFile.Location = new System.Drawing.Point(317, 379);
            this.btn_exportFile.Name = "btn_exportFile";
            this.btn_exportFile.Size = new System.Drawing.Size(172, 52);
            this.btn_exportFile.TabIndex = 13;
            this.btn_exportFile.Text = "Xuất báo cáo";
            this.btn_exportFile.UseVisualStyleBackColor = false;
            this.btn_exportFile.Click += new System.EventHandler(this.btn_exportFile_Click);
            // 
            // fFinish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exportFile);
            this.Controls.Add(this.lb_finalScore);
            this.Controls.Add(this.lb_part3);
            this.Controls.Add(this.lb_part2);
            this.Controls.Add(this.lb_part1);
            this.Controls.Add(this.lb_title);
            this.Name = "fFinish";
            this.Text = "fFinish";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_finalScore;
        private System.Windows.Forms.Label lb_part3;
        private System.Windows.Forms.Label lb_part2;
        private System.Windows.Forms.Label lb_part1;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Button btn_exportFile;
    }
}