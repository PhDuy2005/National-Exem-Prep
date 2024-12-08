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
        private int TimeLimit;
        private int TimeRemaining;
        public QuestionSelection(BindingSource bindingSource)
        {
            InitializeComponent();
            this.bindingSource = bindingSource;
            dgv_questionSelection.DataSource = bindingSource;
            setTimer();
            //loadQuestion();
        }
        
        void setTimer()
        {
            TimeLimit = 90 * 60;
            TimeRemaining = TimeLimit;
            timerCountdown.Start();
        }

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

        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            if (TimeRemaining > 0)
            {
                TimeRemaining--;
                lb_clock.Text = TimeRemaining / 60 + ":" + TimeRemaining % 60;
            }
            else
            {
                timerCountdown.Stop();
                MessageBox.Show("Hết giờ làm bài!");
            }
        }
    }
}
