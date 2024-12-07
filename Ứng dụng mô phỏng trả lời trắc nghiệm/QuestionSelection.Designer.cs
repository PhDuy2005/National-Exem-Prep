namespace Ứng_dụng_mô_phỏng_trả_lời_trắc_nghiệm
{
    partial class QuestionSelection
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
            this.lb_TimeLeft = new System.Windows.Forms.Label();
            this.lb_clock = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_questionSelection = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dgv_questionSelection)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_TimeLeft
            // 
            this.lb_TimeLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_TimeLeft.AutoSize = true;
            this.lb_TimeLeft.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lb_TimeLeft.ForeColor = System.Drawing.Color.Red;
            this.lb_TimeLeft.Location = new System.Drawing.Point(9, 6);
            this.lb_TimeLeft.Name = "lb_TimeLeft";
            this.lb_TimeLeft.Size = new System.Drawing.Size(215, 35);
            this.lb_TimeLeft.TabIndex = 0;
            this.lb_TimeLeft.Text = "Thời gian còn lại:";
            this.lb_TimeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_clock
            // 
            this.lb_clock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_clock.AutoSize = true;
            this.lb_clock.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lb_clock.ForeColor = System.Drawing.Color.Red;
            this.lb_clock.Location = new System.Drawing.Point(250, 6);
            this.lb_clock.Name = "lb_clock";
            this.lb_clock.Size = new System.Drawing.Size(78, 35);
            this.lb_clock.TabIndex = 1;
            this.lb_clock.Text = "00:00";
            this.lb_clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_submit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_submit.Location = new System.Drawing.Point(662, 9);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(126, 52);
            this.btn_submit.TabIndex = 7;
            this.btn_submit.Text = "Nộp bài";
            this.btn_submit.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.34104F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.65896F));
            this.tableLayoutPanel1.Controls.Add(this.lb_TimeLeft, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_clock, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 14);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(346, 47);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // dgv_questionSelection
            // 
            dgv_questionSelection.AllowUserToAddRows = false;
            dgv_questionSelection.AllowUserToDeleteRows = false;
            dgv_questionSelection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_questionSelection.Location = new System.Drawing.Point(18, 86);
            dgv_questionSelection.Name = "dgv_questionSelection";
            dgv_questionSelection.RowHeadersWidth = 51;
            dgv_questionSelection.RowTemplate.Height = 24;
            dgv_questionSelection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv_questionSelection.Size = new System.Drawing.Size(770, 352);
            dgv_questionSelection.TabIndex = 8;
            dgv_questionSelection.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.QuestionDoubleClicked);
            // 
            // QuestionSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(dgv_questionSelection);
            this.Controls.Add(this.btn_submit);
            this.Name = "QuestionSelection";
            this.Text = "QuestionSelection";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(dgv_questionSelection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_TimeLeft;
        private System.Windows.Forms.Label lb_clock;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgv_questionSelection;
    }
}