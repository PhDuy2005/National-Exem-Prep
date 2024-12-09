using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ứng_dụng_mô_phỏng_trả_lời_trắc_nghiệm
{
    public class cMultiplyTrueFalseQuestion : cQuestion
    {
        public List<string> Options = new List<string> { };
        public override float getScore()
        {
            //char selection;
            int count = 0;
            for (int i = 0; i < StudentAnswer.Length; i++)
            {
                if (StudentAnswer[i] == correctAnswer[i])
                {
                    count++;
                }
            }
            switch (count)
            {
                case 1:
                    return 0.1f;
                case 2:
                    return 0.25f;
                case 3:
                    return 0.5f;
                case 4:
                    return 1;
                default:
                    return 0;
            }
        }
        public cMultiplyTrueFalseQuestion(string Part, int QuestionID, string questionContent,
            string note, string correctAnswer, float score, List<string> options)
        {
            this.Part = Part;
            this.QuestionID = QuestionID;
            this.QuestionContent = questionContent;
            this.Note = note;
            this.correctAnswer = correctAnswer;
            this.maxScore = score;
            this.Options = options;
        }
    }
}
