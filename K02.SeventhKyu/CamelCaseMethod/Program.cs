using System;

namespace CamelCaseMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CamelCase("hello world"));
            Console.WriteLine(CamelCase("camel case word"));
        }

        public static string CamelCase(string str)
        {
            string[] words = str.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string result = string.Empty;

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                char firstLetter = Char.ToUpper(currentWord[0]);
                result += firstLetter.ToString() + currentWord.Substring(1);
            }

            return result;
        }
    }


}
