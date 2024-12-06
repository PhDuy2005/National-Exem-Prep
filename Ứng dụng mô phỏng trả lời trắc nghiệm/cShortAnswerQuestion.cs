using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ứng_dụng_mô_phỏng_trả_lời_trắc_nghiệm
{
    internal class cShortAnswerQuestion : cQuestion
    {
        public override float getScore()
        {
            if (StudentAnswer == correctAnswer)
            {
                return scrore;
            }
            return 0;
        }
    }
}
