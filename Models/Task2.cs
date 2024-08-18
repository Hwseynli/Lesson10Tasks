namespace Lesson10Tasks.Models
{
    static class Task2
    {
        public static void Task2Main(string input)
        {
            string result = SwapCase(input);
            Console.WriteLine(result); // Nəticə: hOw MaNY mUCh
        }

        static string SwapCase(string str)
        {
            char[] charArray = str.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (char.IsUpper(charArray[i]))
                {
                    charArray[i] = char.ToLower(charArray[i]);
                }
                else if (char.IsLower(charArray[i]))
                {
                    charArray[i] = char.ToUpper(charArray[i]);
                }
            }
            return new string(charArray);
        }
    }
}