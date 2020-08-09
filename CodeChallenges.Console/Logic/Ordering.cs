namespace CodeChallenges.Domain.Logic
{
    public class Ordering
    {
        public int OrderByDescending(uint number)
        {
            var strNumberArray = number.ToString().ToCharArray();
            var resultText = string.Empty;

            for (int i = 0; i < strNumberArray.Length; i++)
            {
                var position = 0;
                var value = 0;

                for (int j = 0; j < strNumberArray.Length; j++)
                {
                    if (int.TryParse(strNumberArray[j].ToString(), out int currentValue) && currentValue > value)
                    {
                        position = j;
                        value = currentValue;
                    }
                }

                resultText = $"{resultText}{value}";
                strNumberArray[position] = char.MinValue;
            }

            return int.Parse(resultText);
        }
    }

}
