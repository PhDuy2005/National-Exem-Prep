using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ứng_dụng_mô_phỏng_trả_lời_trắc_nghiệm
{
    public class ExamInformation
    {
        public string Subject { get; set; }
        public int Time {  get; set; }
        public int NumberOfQuestions { get; set; }
        public string ExamType { get; set; }
        public ExamInformation(string subject, int time, int numberOfQuestions, string examType)
        {
            Subject = subject;
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            ExamType = examType;
        }

        public virtual InformaticsTrack getITTrack() => InformaticsTrack.ITApplications;
    }
}
