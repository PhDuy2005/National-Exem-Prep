using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ứng_dụng_mô_phỏng_trả_lời_trắc_nghiệm
{
    enum InformaticsTrack
    {
        ComputerScience = 1, // Khoa học Máy tính
        ITApplications = 2   // Tin học Ứng dụng
    }
    internal class cExamInformation_IT : ExamInformation
    {
        InformaticsTrack track { get; set; }
        public cExamInformation_IT(string subject, int time, int numberOfQuestions, string examType)
            : base(subject, time, numberOfQuestions, examType)
        {

        }
    }
}
