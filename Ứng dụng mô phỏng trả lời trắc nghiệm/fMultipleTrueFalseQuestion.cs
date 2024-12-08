using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ứng_dụng_mô_phỏng_trả_lời_trắc_nghiệm
{
    public partial class fMultipleTrueFalseQuestion : Form
    {
        cMultiplyTrueFalseQuestion question;
        //BindingSource bindingSource = new BindingSource();
        // Delegate định nghĩa kiểu phương thức cho event
        public delegate void DataSubmittedHandler(cMultiplyTrueFalseQuestion data);

        // Event sử dụng delegate
        public event DataSubmittedHandler OnDataSubmitted;
        public fMultipleTrueFalseQuestion(cMultiplyTrueFalseQuestion question)
        {
            InitializeComponent();
            this.question = question;
            ShowQuestion();
        }

        void ShowQuestion()
        {
            lb_QuestionNum.Text = "Phần I - Câu " + question.QuestionID.ToString();
            lb_questionContent.Text = question.GetQuestionContent();
            //lbQuestionContent.Text = question.QuestionContent;
            //lbQuestionID.Text = question.QuestionID.ToString();

            lbOption1.Text = question.Options[0];
            lbOption2.Text = question.Options[1];
            lbOption3.Text = question.Options[2];
            lbOption4.Text = question.Options[3];

            ckbOptionFalse1.Checked = false;
            ckbOptionFalse2.Checked = false;
            ckbOptionFalse3.Checked = false;
            ckbOptionFalse4.Checked = false;
            ckbOptionTrue1.Checked = false;
            ckbOptionTrue2.Checked = false;
            ckbOptionTrue3.Checked = false;
            ckbOptionTrue4.Checked = false;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ckbOptionFalse1.Checked = false;
            ckbOptionFalse2.Checked = false;
            ckbOptionFalse3.Checked = false;
            ckbOptionFalse4.Checked = false;
            ckbOptionTrue1.Checked = false;
            ckbOptionTrue2.Checked = false;
            ckbOptionTrue3.Checked = false;
            ckbOptionTrue4.Checked = false;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            //string firstAnswer = question.GetStudentAnswer();
            string answer = "";
            int countBlank = 0;
            if (ckbOptionTrue1.Checked && ckbOptionFalse1.Checked)
            {
                answer += "M";
            }
            else if (ckbOptionFalse1.Checked)
            {
                answer += "S";
            }
            else if (ckbOptionTrue1.Checked)
            {
                answer += "D";
            }
            else
            {
                answer += " ";
                countBlank++;
            }

            if (ckbOptionTrue2.Checked && ckbOptionFalse2.Checked)
            {
                answer += "M";
            }
            else if (ckbOptionFalse2.Checked)
            {
                answer += "S";
            }
            else if (ckbOptionTrue2.Checked)
            {
                answer += "D";
            }
            else
            {
                answer += " ";
                countBlank++;
            }

            if (ckbOptionTrue3.Checked && ckbOptionFalse3.Checked)
            {
                answer += "M";
            }
            else if (ckbOptionFalse3.Checked)
            {
                answer += "S";
            }
            else if (ckbOptionTrue3.Checked)
            {
                answer += "D";
            }
            else
            {
                answer += " ";
                countBlank++;
            }

            if (ckbOptionTrue4.Checked && ckbOptionFalse4.Checked)
            {
                answer += "M";
            }
            else if (ckbOptionFalse4.Checked)
            {
                answer += "S";
            }
            else if (ckbOptionTrue4.Checked)
            {
                answer += "D";
            }
            else
            {
                answer += " ";
                countBlank++;
            }

            question.SetStudentAnswer(answer);
            if (countBlank == 0)
            {
                question.AnswerState = "Đã trả lời";
            }
            else if (countBlank == 4)
            {
                question.AnswerState = "";
            }
            else
            {
                question.AnswerState = "Chưa trả lời hết";
            }

            OnDataSubmitted?.Invoke(question);
            this.DialogResult = DialogResult.OK;
        }
    }
}
