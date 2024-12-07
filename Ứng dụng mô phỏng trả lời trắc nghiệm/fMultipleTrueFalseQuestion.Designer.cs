namespace Ứng_dụng_mô_phỏng_trả_lời_trắc_nghiệm
{
    partial class fMultipleTrueFalseQuestion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbOptionTrue1 = new System.Windows.Forms.CheckBox();
            this.ckbOptionFalse1 = new System.Windows.Forms.CheckBox();
            this.ckbOptionTrue2 = new System.Windows.Forms.CheckBox();
            this.ckbOptionFalse2 = new System.Windows.Forms.CheckBox();
            this.ckbOptionTrue3 = new System.Windows.Forms.CheckBox();
            this.ckbOptionFalse3 = new System.Windows.Forms.CheckBox();
            this.ckbOptionTrue4 = new System.Windows.Forms.CheckBox();
            this.ckbOptionFalse4 = new System.Windows.Forms.CheckBox();
            this.lbOption1 = new System.Windows.Forms.Label();
            this.lbOption2 = new System.Windows.Forms.Label();
            this.lbOption3 = new System.Windows.Forms.Label();
            this.lbOption4 = new System.Windows.Forms.Label();
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
            this.pn_questionStructure.TabIndex = 2;
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
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
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
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
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
            this.lb_QuestionNum.Size = new System.Drawing.Size(199, 35);
            this.lb_QuestionNum.TabIndex = 2;
            this.lb_QuestionNum.Text = "Phần II - Câu xx";
            this.lb_QuestionNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpn_questionView
            // 
            this.tpn_questionView.ColumnCount = 3;
            this.tpn_questionView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpn_questionView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tpn_questionView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tpn_questionView.Controls.Add(this.lbOption4, 0, 4);
            this.tpn_questionView.Controls.Add(this.lbOption3, 0, 3);
            this.tpn_questionView.Controls.Add(this.lbOption2, 0, 2);
            this.tpn_questionView.Controls.Add(this.ckbOptionFalse4, 2, 4);
            this.tpn_questionView.Controls.Add(this.ckbOptionTrue4, 1, 4);
            this.tpn_questionView.Controls.Add(this.ckbOptionFalse3, 2, 3);
            this.tpn_questionView.Controls.Add(this.ckbOptionTrue3, 1, 3);
            this.tpn_questionView.Controls.Add(this.ckbOptionFalse2, 2, 2);
            this.tpn_questionView.Controls.Add(this.ckbOptionTrue2, 1, 2);
            this.tpn_questionView.Controls.Add(this.ckbOptionFalse1, 2, 1);
            this.tpn_questionView.Controls.Add(this.lb_questionContent, 0, 0);
            this.tpn_questionView.Controls.Add(this.label1, 1, 0);
            this.tpn_questionView.Controls.Add(this.label2, 2, 0);
            this.tpn_questionView.Controls.Add(this.ckbOptionTrue1, 1, 1);
            this.tpn_questionView.Controls.Add(this.lbOption1, 0, 1);
            this.tpn_questionView.Location = new System.Drawing.Point(3, 80);
            this.tpn_questionView.Name = "tpn_questionView";
            this.tpn_questionView.RowCount = 5;
            this.tpn_questionView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tpn_questionView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tpn_questionView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tpn_questionView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tpn_questionView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tpn_questionView.Size = new System.Drawing.Size(882, 287);
            this.tpn_questionView.TabIndex = 0;
            // 
            // lb_questionContent
            // 
            this.lb_questionContent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_questionContent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lb_questionContent.Location = new System.Drawing.Point(3, 8);
            this.lb_questionContent.Name = "lb_questionContent";
            this.lb_questionContent.Size = new System.Drawing.Size(733, 97);
            this.lb_questionContent.TabIndex = 0;
            this.lb_questionContent.Text = "Nội dung câu hỏi";
            this.lb_questionContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(749, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Đúng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(826, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sai";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ckbOptionTrue1
            // 
            this.ckbOptionTrue1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbOptionTrue1.AutoSize = true;
            this.ckbOptionTrue1.Location = new System.Drawing.Point(767, 127);
            this.ckbOptionTrue1.Name = "ckbOptionTrue1";
            this.ckbOptionTrue1.Size = new System.Drawing.Size(18, 17);
            this.ckbOptionTrue1.TabIndex = 7;
            this.ckbOptionTrue1.UseVisualStyleBackColor = true;
            // 
            // ckbOptionFalse1
            // 
            this.ckbOptionFalse1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbOptionFalse1.AutoSize = true;
            this.ckbOptionFalse1.Location = new System.Drawing.Point(839, 127);
            this.ckbOptionFalse1.Name = "ckbOptionFalse1";
            this.ckbOptionFalse1.Size = new System.Drawing.Size(18, 17);
            this.ckbOptionFalse1.TabIndex = 8;
            this.ckbOptionFalse1.UseVisualStyleBackColor = true;
            // 
            // ckbOptionTrue2
            // 
            this.ckbOptionTrue2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbOptionTrue2.AutoSize = true;
            this.ckbOptionTrue2.Location = new System.Drawing.Point(767, 170);
            this.ckbOptionTrue2.Name = "ckbOptionTrue2";
            this.ckbOptionTrue2.Size = new System.Drawing.Size(18, 17);
            this.ckbOptionTrue2.TabIndex = 9;
            this.ckbOptionTrue2.UseVisualStyleBackColor = true;
            // 
            // ckbOptionFalse2
            // 
            this.ckbOptionFalse2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbOptionFalse2.AutoSize = true;
            this.ckbOptionFalse2.Location = new System.Drawing.Point(839, 170);
            this.ckbOptionFalse2.Name = "ckbOptionFalse2";
            this.ckbOptionFalse2.Size = new System.Drawing.Size(18, 17);
            this.ckbOptionFalse2.TabIndex = 10;
            this.ckbOptionFalse2.UseVisualStyleBackColor = true;
            // 
            // ckbOptionTrue3
            // 
            this.ckbOptionTrue3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbOptionTrue3.AutoSize = true;
            this.ckbOptionTrue3.Location = new System.Drawing.Point(767, 213);
            this.ckbOptionTrue3.Name = "ckbOptionTrue3";
            this.ckbOptionTrue3.Size = new System.Drawing.Size(18, 17);
            this.ckbOptionTrue3.TabIndex = 11;
            this.ckbOptionTrue3.UseVisualStyleBackColor = true;
            // 
            // ckbOptionFalse3
            // 
            this.ckbOptionFalse3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbOptionFalse3.AutoSize = true;
            this.ckbOptionFalse3.Location = new System.Drawing.Point(839, 213);
            this.ckbOptionFalse3.Name = "ckbOptionFalse3";
            this.ckbOptionFalse3.Size = new System.Drawing.Size(18, 17);
            this.ckbOptionFalse3.TabIndex = 12;
            this.ckbOptionFalse3.UseVisualStyleBackColor = true;
            // 
            // ckbOptionTrue4
            // 
            this.ckbOptionTrue4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbOptionTrue4.AutoSize = true;
            this.ckbOptionTrue4.Location = new System.Drawing.Point(767, 256);
            this.ckbOptionTrue4.Name = "ckbOptionTrue4";
            this.ckbOptionTrue4.Size = new System.Drawing.Size(18, 17);
            this.ckbOptionTrue4.TabIndex = 13;
            this.ckbOptionTrue4.UseVisualStyleBackColor = true;
            // 
            // ckbOptionFalse4
            // 
            this.ckbOptionFalse4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbOptionFalse4.AutoSize = true;
            this.ckbOptionFalse4.Location = new System.Drawing.Point(839, 256);
            this.ckbOptionFalse4.Name = "ckbOptionFalse4";
            this.ckbOptionFalse4.Size = new System.Drawing.Size(18, 17);
            this.ckbOptionFalse4.TabIndex = 14;
            this.ckbOptionFalse4.UseVisualStyleBackColor = true;
            // 
            // lbOption1
            // 
            this.lbOption1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbOption1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbOption1.Location = new System.Drawing.Point(3, 119);
            this.lbOption1.Name = "lbOption1";
            this.lbOption1.Size = new System.Drawing.Size(733, 33);
            this.lbOption1.TabIndex = 15;
            this.lbOption1.Text = "Option1";
            this.lbOption1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbOption2
            // 
            this.lbOption2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbOption2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbOption2.Location = new System.Drawing.Point(3, 162);
            this.lbOption2.Name = "lbOption2";
            this.lbOption2.Size = new System.Drawing.Size(733, 33);
            this.lbOption2.TabIndex = 16;
            this.lbOption2.Text = "Option2";
            this.lbOption2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbOption3
            // 
            this.lbOption3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbOption3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbOption3.Location = new System.Drawing.Point(3, 205);
            this.lbOption3.Name = "lbOption3";
            this.lbOption3.Size = new System.Drawing.Size(733, 33);
            this.lbOption3.TabIndex = 17;
            this.lbOption3.Text = "Option3";
            this.lbOption3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbOption4
            // 
            this.lbOption4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbOption4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbOption4.Location = new System.Drawing.Point(3, 248);
            this.lbOption4.Name = "lbOption4";
            this.lbOption4.Size = new System.Drawing.Size(733, 33);
            this.lbOption4.TabIndex = 18;
            this.lbOption4.Text = "Option4";
            this.lbOption4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fMultipleTrueFalseQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 591);
            this.Controls.Add(this.pn_questionStructure);
            this.Name = "fMultipleTrueFalseQuestion";
            this.Text = "fMultipleTrueFalseQuestion";
            this.pn_questionStructure.ResumeLayout(false);
            this.pn_QuestionNum.ResumeLayout(false);
            this.pn_QuestionNum.PerformLayout();
            this.tpn_questionView.ResumeLayout(false);
            this.tpn_questionView.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbOptionFalse4;
        private System.Windows.Forms.CheckBox ckbOptionTrue4;
        private System.Windows.Forms.CheckBox ckbOptionFalse3;
        private System.Windows.Forms.CheckBox ckbOptionTrue3;
        private System.Windows.Forms.CheckBox ckbOptionFalse2;
        private System.Windows.Forms.CheckBox ckbOptionTrue2;
        private System.Windows.Forms.CheckBox ckbOptionFalse1;
        private System.Windows.Forms.CheckBox ckbOptionTrue1;
        private System.Windows.Forms.Label lbOption4;
        private System.Windows.Forms.Label lbOption3;
        private System.Windows.Forms.Label lbOption2;
        private System.Windows.Forms.Label lbOption1;
    }
}