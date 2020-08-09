using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenges.Domain.Logic
{
    public class MathOperations
    {
        public long FindNextPerfectSquare(ulong number)
        {
            var result = Math.Sqrt(number);

            if (!IsInteger(result)) return -1;

            double pow;

            do
            {
                result++;
                pow = Math.Pow(result, 2);
            } while (!IsInteger(pow));

            return Convert.ToInt64(pow);
        }

        private bool IsInteger(double value) => value % 1 == 0;
    }
}
