using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ứng_dụng_mô_phỏng_trả_lời_trắc_nghiệm
{
    internal class cQuestion
    {
        public int QuestionType { get; private set; }
        public string QuestionContent { get; private set; }
        public string StudentAnswer { get; set; }
        public string Note { get; private set; }
        protected string correctAnswer;
        protected float scrore;
        public virtual float getScore() => 0;
        public void setScore() { }
    }
}
