using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ứng_dụng_mô_phỏng_trả_lời_trắc_nghiệm
{
    public class cMultipleChoieQuestion : cQuestion
    {
        private List<string> Options = new List<string> { };
        override public float getScore()
        {
            if (StudentAnswer == correctAnswer)
            {
                return scrore;
            }
            return 0;
        }
        public cMultipleChoieQuestion(string Part, int QuestionID, string questionContent,
            string note, string correctAnswer, float score, List<string> options) {
            this.Part = Part;
            this.QuestionID = QuestionID;
            this.QuestionContent = questionContent;
            this.Note = note;
            this.correctAnswer = correctAnswer;
            this.scrore = score;
            this.Options = options;
        }
    }
}
