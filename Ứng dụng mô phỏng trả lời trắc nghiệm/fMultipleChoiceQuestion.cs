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
    public partial class fMultipleChoiceQuestion : Form
    {
        cMultipleChoieQuestion question;
        //BindingSource bindingSource = new BindingSource();
        // Delegate định nghĩa kiểu phương thức cho event
        public delegate void DataSubmittedHandler(cMultipleChoieQuestion data);

        // Event sử dụng delegate
        public event DataSubmittedHandler OnDataSubmitted;

        public fMultipleChoiceQuestion(cMultipleChoieQuestion question)
        {
            InitializeComponent();
            this.question = question;
            ShowQuestion();
            //this.bindingSource = bindingSource;
        }
        void ShowQuestion()
        {
            lb_QuestionNum.Text = "Phần I - Câu " + question.QuestionID.ToString();
            lb_questionContent.Text = question.GetQuestionContent();
            //lbQuestionContent.Text = question.QuestionContent;
            //lbQuestionID.Text = question.QuestionID.ToString();
            rbtn_option1.Text = question.Options[0];
            rbtn_option2.Text = question.Options[1];
            rbtn_option3.Text = question.Options[2];
            rbtn_option4.Text = question.Options[3];

            rbtn_option1.Checked = false;
            rbtn_option2.Checked = false;
            rbtn_option3.Checked = false;
            rbtn_option4.Checked = false;
        }

        private void SubmitAnswerClick(object sender, EventArgs e)
        {
            string firstAnswer = question.GetStudentAnswer();
            string answer;
            if (rbtn_option1.Checked)
            {
                answer = "A";
            }
            else if (rbtn_option2.Checked)
            {
                answer = "B";
            }
            else if (rbtn_option3.Checked)
            {
                answer = "C";
            }
            else if (rbtn_option4.Checked)
            {
                answer = "D";
            }
            else
            {
                answer = "";
            }
            question.SetStudentAnswer(answer);
            question.AnswerState = answer;
            if (firstAnswer != answer)
            {
                OnDataSubmitted?.Invoke(question);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            rbtn_option1.Checked = false;
            rbtn_option2.Checked = false;
            rbtn_option3.Checked = false;
            rbtn_option4.Checked = false;
        }
    }
}
