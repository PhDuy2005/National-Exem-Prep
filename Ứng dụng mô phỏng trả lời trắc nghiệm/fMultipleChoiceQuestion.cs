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
        }

        private void SubmitAnswerClick(object sender, EventArgs e)
        {

        }
    }
}
