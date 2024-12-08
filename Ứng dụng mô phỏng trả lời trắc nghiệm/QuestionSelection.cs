using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace Ứng_dụng_mô_phỏng_trả_lời_trắc_nghiệm
{
    public partial class QuestionSelection : Form
    {
        private BindingSource bindingSource = new BindingSource();
        Binding binding = null;
        public QuestionSelection(BindingSource bindingSource)
        {
            InitializeComponent();
            this.bindingSource = bindingSource;
            dgv_questionSelection.DataSource = bindingSource;
            //loadQuestion();
        }
        List<cQuestion> questions = new List<cQuestion>();
        //private void loadQuestion()
        //{

        //    dgv_questionSelection.DataSource = bindingSource;
        //}

        private void QuestionDoubleClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var selectedQuestion = dgv_questionSelection.Rows[e.RowIndex].DataBoundItem as cQuestion;

            if (selectedQuestion == null) return;

            if (selectedQuestion is cMultipleChoieQuestion)
            {
                fMultipleChoiceQuestion f = new fMultipleChoiceQuestion(selectedQuestion as cMultipleChoieQuestion);
                f.OnDataSubmitted += MCQ_OnDataSubmitted;
                f.ShowDialog();
            }
            else if (selectedQuestion is cMultiplyTrueFalseQuestion)
            {
                fMultipleTrueFalseQuestion f = new fMultipleTrueFalseQuestion(selectedQuestion as cMultiplyTrueFalseQuestion);
                f.OnDataSubmitted += MTFQ_OnDataSubmitted;
                f.ShowDialog();
            }
            else if (selectedQuestion is cShortAnswerQuestion)
            {
                fShortAnswerQuestion f = new fShortAnswerQuestion(selectedQuestion as cShortAnswerQuestion);
                f.OnDataSubmitted += SAQ_OnDataSubmitted;
                f.ShowDialog();
            }
        }

        private void SAQ_OnDataSubmitted(cShortAnswerQuestion data)
        {
            var selectedQuestion = dgv_questionSelection.CurrentRow.DataBoundItem as cShortAnswerQuestion;
            if (selectedQuestion != null)
            {
                selectedQuestion = data;
                bindingSource.ResetBindings(false);
            }
        }

        private void MTFQ_OnDataSubmitted(cMultiplyTrueFalseQuestion data)
        {
            var selectedQuestion = dgv_questionSelection.CurrentRow.DataBoundItem as cMultiplyTrueFalseQuestion;
            if (selectedQuestion != null)
            {
                selectedQuestion = data;
                bindingSource.ResetBindings(false);
            }
        }

        private void MCQ_OnDataSubmitted(cMultipleChoieQuestion data)
        {
            var selectedQuestion = dgv_questionSelection.CurrentRow.DataBoundItem as cMultipleChoieQuestion;
            if (selectedQuestion != null)
            {
                selectedQuestion = data;
                bindingSource.ResetBindings(false);
            }
        }
    }
    public class QuestionList
    {
        public List<cQuestion> Questions { get; set; }
    }
}
