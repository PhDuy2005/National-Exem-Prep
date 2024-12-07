namespace Ứng_dụng_mô_phỏng_trả_lời_trắc_nghiệm
{
    partial class fShortAnswerQuestion
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
            this.pn_questionStructure = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.pn_QuestionNum = new System.Windows.Forms.Panel();
            this.lb_QuestionNum = new System.Windows.Forms.Label();
            this.tpn_questionView = new System.Windows.Forms.TableLayoutPanel();
            this.lb_questionContent = new System.Windows.Forms.Label();
            this.pn_questionStructure.SuspendLayout();
            this.pn_QuestionNum.SuspendLayout();
            this.tpn_questionView.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_questionStructure
            // 
            this.pn_questionStructure.Controls.Add(this.btn_clear);
            this.pn_questionStructure.Controls.Add(this.btn_submit);
            this.pn_questionStructure.Controls.Add(this.pn_QuestionNum);
            this.pn_questionStructure.Controls.Add(this.tpn_questionView);
            this.pn_questionStructure.Location = new System.Drawing.Point(23, 12);
            this.pn_questionStructure.Name = "pn_questionStructure";
            this.pn_questionStructure.Size = new System.Drawing.Size(894, 423);
            this.pn_questionStructure.TabIndex = 3;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_clear.Location = new System.Drawing.Point(685, 368);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(200, 52);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "Xóa đáp án";
            this.btn_clear.UseVisualStyleBackColor = false;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_submit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_submit.Location = new System.Drawing.Point(685, 0);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(200, 52);
            this.btn_submit.TabIndex = 8;
            this.btn_submit.Text = "Lưu đáp án";
            this.btn_submit.UseVisualStyleBackColor = false;
            // 
            // pn_QuestionNum
            // 
            this.pn_QuestionNum.Controls.Add(this.lb_QuestionNum);
            this.pn_QuestionNum.Location = new System.Drawing.Point(4, 3);
            this.pn_QuestionNum.Name = "pn_QuestionNum";
            this.pn_QuestionNum.Size = new System.Drawing.Size(263, 57);
            this.pn_QuestionNum.TabIndex = 0;
            // 
            // lb_QuestionNum
            // 
            this.lb_QuestionNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_QuestionNum.AutoSize = true;
            this.lb_QuestionNum.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lb_QuestionNum.ForeColor = System.Drawing.Color.Red;
            this.lb_QuestionNum.Location = new System.Drawing.Point(35, 12);
            this.lb_QuestionNum.Name = "lb_QuestionNum";
            this.lb_QuestionNum.Size = new System.Drawing.Size(207, 35);
            this.lb_QuestionNum.TabIndex = 2;
            this.lb_QuestionNum.Text = "Phần III - Câu xx";
            this.lb_QuestionNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpn_questionView
            // 
            this.tpn_questionView.ColumnCount = 1;
            this.tpn_questionView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpn_questionView.Controls.Add(this.lb_questionContent, 0, 0);
            this.tpn_questionView.Location = new System.Drawing.Point(3, 80);
            this.tpn_questionView.Name = "tpn_questionView";
            this.tpn_questionView.RowCount = 1;
            this.tpn_questionView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tpn_questionView.Size = new System.Drawing.Size(684, 343);
            this.tpn_questionView.TabIndex = 0;
            // 
            // lb_questionContent
            // 
            this.lb_questionContent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lb_questionContent.Location = new System.Drawing.Point(3, 0);
            this.lb_questionContent.Name = "lb_questionContent";
            this.lb_questionContent.Size = new System.Drawing.Size(678, 288);
            this.lb_questionContent.TabIndex = 0;
            this.lb_questionContent.Text = "Nội dung câu hỏi";
            this.lb_questionContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fShortAnswerQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 591);
            this.Controls.Add(this.pn_questionStructure);
            this.Name = "fShortAnswerQuestion";
            this.Text = "fShortAnswerQuestion";
            this.pn_questionStructure.ResumeLayout(false);
            this.pn_QuestionNum.ResumeLayout(false);
            this.pn_QuestionNum.PerformLayout();
            this.tpn_questionView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_questionStructure;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Panel pn_QuestionNum;
        private System.Windows.Forms.Label lb_QuestionNum;
        private System.Windows.Forms.TableLayoutPanel tpn_questionView;
        private System.Windows.Forms.Label lb_questionContent;
    }
}