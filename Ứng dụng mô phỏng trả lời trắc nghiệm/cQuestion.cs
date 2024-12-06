using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ứng_dụng_mô_phỏng_trả_lời_trắc_nghiệm
{
    public class cQuestion
    {
        public string Part { get; protected set; }
        public int QuestionID { get; protected set; }
        protected string QuestionContent { get; set; }
        public string StudentAnswer { get; set; }
        public string Note { get; protected set; }
        protected string correctAnswer;
        protected float scrore;
        public virtual float getScore() => 0;
        public void setScore() { }
        public cQuestion() { }
    }
}
