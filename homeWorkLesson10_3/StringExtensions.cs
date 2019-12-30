namespace homeWorkLesson10_3
{
    static class StringExtensions
    {
        public static int CountOfSymbols(this string @string, int startIndex)
        {
            int count = 0;

            for (int i = 0; i < @string.Length; i++)
            {
                if (i >= startIndex)
                { 
                    count++;
                }
            }

            return count;
        }

        public static int CountOfWords(this string @string)
        {
            int count = 0;
            bool isSpace = false;

            for (int i = 0; i < @string.Length; i++)
            {
                if (@string[i] == ' ' && !isSpace)
                {
                    count++;
                }

                isSpace = @string[i] == ' ';
            }

            return count + 1;
        }
    }
}
