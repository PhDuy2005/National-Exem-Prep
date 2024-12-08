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
    public partial class fFinish : Form
    {
        BindingSource BindingSource = new BindingSource();
        ExamInformation eInfo;
        float scoreP1, scoreP2, scoreP3;
        public fFinish(BindingSource bindingSource, ExamInformation eInfo)
        {
            InitializeComponent();
            this.BindingSource = bindingSource;
            this.eInfo = eInfo;
            CalculateScore();
            ShowScore();
        }

        void CalculateScore()
        {
            scoreP1 = 0;
            scoreP2 = 0;
            scoreP3 = 0;

            float temp;

            foreach (cQuestion question in this.BindingSource)
            {
                temp = question.getScore();
                if (question is cMultipleChoieQuestion)
                {
                    scoreP1 += temp;
                }
                else if (question is cMultiplyTrueFalseQuestion)
                {
                    scoreP2 += temp;
                }
                else if (question is cShortAnswerQuestion)
                {
                    scoreP3 += temp;
                }
            }
        }
        void ShowScore()
        {
            lb_part1.Text = "Phần I: Trắc nghiệm: " + scoreP1.ToString();
            lb_part2.Text = "Phần II: Đúng - Sai: " + scoreP2.ToString();
            lb_part3.Text = "Phần III: Trả lời ngắn: " + scoreP3.ToString();
            string finalScore = "Tổng điểm: " + (scoreP1 + scoreP2 + scoreP3).ToString();
            lb_finalScore.Text = finalScore;

            if (eInfo.ExamType == "Đề chuẩn THPTQG")
            {
                lb_part1.Visible = true;
                lb_part2.Visible = true;
                lb_part3.Visible = true;
                return;
            }
            
            if (eInfo.ExamType == "TN 1 trong 4 đáp án")
            {
                lb_part1.Visible = true;
                lb_part2.Visible = false;
                lb_part3.Visible = false;
                return;
            }

            if (eInfo.ExamType == "TN đúng/sai")
            {
                lb_part1.Visible = false;
                lb_part2.Visible = true;
                lb_part3.Visible = false;
                return;
            }

            if (eInfo.ExamType == "TN trả lời ngắn")
            {
                lb_part1.Visible = false;
                lb_part2.Visible = false;
                lb_part3.Visible = true;
                return;
            }
        }
    }
}
