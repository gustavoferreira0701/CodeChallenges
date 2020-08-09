using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenges.Domain.Logic
{
    public class Counter
    {
        public int VowelCounter(string text)
        {
            var total = 0;

            var validVowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < validVowels.Length; j++)
                {
                    if (validVowels[j] == text[i]) total++;
                }
            }

            return total;
        }
    }
}

