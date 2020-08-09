namespace CodeChallenges.Domain.Logic
{
    public class Searching
    {
        public int SearchLowerNumber(int[] entries)
        {
            if (entries.Length == 0) return 0;

            int lowest = entries[0];

            for (int i = 0; i < entries.Length; i++)
                if (entries[i] < lowest)
                    lowest = entries[i];

            return lowest;
        }

        public string FindMiddleCharacter(string text)
        {
            if (text.Length == 0) return string.Empty;

            var middle = text.Length / 2;

            return ((text.Length % 2) == 0) ? $"{text[middle - 1]}{text[middle]}" : $"{text[middle]}";
        }


    }
}
