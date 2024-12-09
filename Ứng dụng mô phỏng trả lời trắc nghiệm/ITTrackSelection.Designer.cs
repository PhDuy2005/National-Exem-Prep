namespace Ứng_dụng_mô_phỏng_trả_lời_trắc_nghiệm
{
    partial class ITTrackSelection
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
            this.btn_ITApplication = new System.Windows.Forms.Button();
            this.btn_ComputerScience = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lb_title.Location = new System.Drawing.Point(-4, 0);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(806, 129);
            this.lb_title.TabIndex = 1;
            this.lb_title.Text = "CHỌN ĐỊNH HƯỚNG LÀM BÀI";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ITApplication
            // 
            this.btn_ITApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_ITApplication.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_ITApplication.Location = new System.Drawing.Point(128, 215);
            this.btn_ITApplication.Name = "btn_ITApplication";
            this.btn_ITApplication.Size = new System.Drawing.Size(232, 52);
            this.btn_ITApplication.TabIndex = 8;
            this.btn_ITApplication.Text = "Tin học ứng dụng";
            this.btn_ITApplication.UseVisualStyleBackColor = false;
            // 
            // btn_ComputerScience
            // 
            this.btn_ComputerScience.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_ComputerScience.Enabled = false;
            this.btn_ComputerScience.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_ComputerScience.Location = new System.Drawing.Point(441, 215);
            this.btn_ComputerScience.Name = "btn_ComputerScience";
            this.btn_ComputerScience.Size = new System.Drawing.Size(232, 52);
            this.btn_ComputerScience.TabIndex = 7;
            this.btn_ComputerScience.Text = "Khoa học máy tính";
            this.btn_ComputerScience.UseVisualStyleBackColor = false;
            // 
            // ITTrackSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ITApplication);
            this.Controls.Add(this.btn_ComputerScience);
            this.Controls.Add(this.lb_title);
            this.Name = "ITTrackSelection";
            this.Text = "ITTrackSelection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Button btn_ITApplication;
        private System.Windows.Forms.Button btn_ComputerScience;
    }
}