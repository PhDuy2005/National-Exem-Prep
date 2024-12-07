using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ứng_dụng_mô_phỏng_trả_lời_trắc_nghiệm
{
    public class cQuestion
    {

        public string Part { get; protected set; }
        public int QuestionID { get; protected set; }
        protected string QuestionContent { get; set; }
        protected string StudentAnswer { get; set; } = "";
        public string AnswerState { get; set; } = "";
        public string Note { get; protected set; }
        protected string correctAnswer;
        protected float scrore;
        public virtual float getScore() => 0;
        public void setScore() { }
        public cQuestion() { }
        public string GetQuestionContent() => QuestionContent;
        public void SetStudentAnswer(string answer) => StudentAnswer = answer;
        public string GetStudentAnswer() => StudentAnswer;
    }
}
