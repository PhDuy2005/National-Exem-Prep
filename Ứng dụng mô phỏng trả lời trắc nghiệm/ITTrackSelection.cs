using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ứng_dụng_mô_phỏng_trả_lời_trắc_nghiệm
{
    public partial class ITTrackSelection : Form
    {
        BindingSource bindingSrc;
        cExamInformation_IT eInfo;
        public ITTrackSelection(BindingSource bindingSource, ExamInformation eInfo)
        {
            InitializeComponent();
            this.bindingSrc = bindingSource;
            this.eInfo = eInfo as cExamInformation_IT;
        }

        private void btn_ComputerScience_Click(object sender, EventArgs e)
        {
            eInfo.track = InformaticsTrack.ComputerScience;
            MessageBox.Show("Với định hướng Khoa học Máy tính, ở phần II, thí sinh vui lòng trả lời câu 1-2-3-4");
            foreach (var item in bindingSrc)
            {
                cQuestion q = item as cQuestion;
                if (q is cShortAnswerQuestion)
                {
                    cShortAnswerQuestion saq = q as cShortAnswerQuestion;
                    if (saq.QuestionID == 5 || saq.QuestionID == 6)
                    {
                        saq.Note = "Không thuộc phần thi này";
                        bindingSrc.ResetBindings(false);
                        //How can I update data in bindingSrc?
                    }
                }
            }
            QuestionSelection f = new QuestionSelection(bindingSrc, eInfo);
            f.Show();
            this.Hide();
        }

        private void btn_ITApplication_Click(object sender, EventArgs e)
        {
            eInfo.track = InformaticsTrack.ITApplications;
            MessageBox.Show("Với định hướng Tin học Ứng dụng, ở phần II, thí sinh vui lòng trả lời câu 1-2-5-6");
            foreach (var item in bindingSrc)
            {
                cQuestion q = item as cQuestion;
                if (q is cShortAnswerQuestion)
                {
                    cShortAnswerQuestion saq = q as cShortAnswerQuestion;
                    if (saq.QuestionID == 4 || saq.QuestionID == 3)
                    {
                        saq.Note = "Không thuộc phần thi này";
                        bindingSrc.ResetBindings(false);
                    }
                }
            }
            QuestionSelection f = new QuestionSelection(bindingSrc, eInfo);
            f.Show();
            this.Hide();
        }
    }
}
