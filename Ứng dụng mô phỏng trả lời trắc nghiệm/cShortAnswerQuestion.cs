using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ứng_dụng_mô_phỏng_trả_lời_trắc_nghiệm
{
    public class cShortAnswerQuestion : cQuestion
    {
        public Dictionary<int, string> currentAnswer = new Dictionary<int, string>();
        public override float getScore()
        {
            if (StudentAnswer == correctAnswer)
            {
                return maxScore;
            }
            return 0;
        }
        public cShortAnswerQuestion(string Part, int QuestionID, string questionContent,
            string note, string correctAnswer, float score)
        {
            this.Part = Part;
            this.QuestionID = QuestionID;
            this.QuestionContent = questionContent;
            this.Note = note;
            this.correctAnswer = correctAnswer;
            this.maxScore = score;
            for (int i = 1; i <= 4; i++)
            {
                currentAnswer[i] = ""; // Gán giá trị ban đầu là chuỗi rỗng
            }
        }
    }
}
