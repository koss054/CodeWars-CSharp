using System;
using System.Collections.Generic;

namespace MexicanWave
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", wave("hello")));
            Console.WriteLine(string.Join(", ", wave("Two words")));
            Console.WriteLine(string.Join(", ", wave(" gap ")));
        }

        public static List<string> wave(string str)
        {
            List<string> result = new List<string>();
            str = str.ToLower();

            for (int i = 0; i < str.Length; i++) {
                if (String.IsNullOrWhiteSpace(str[i].ToString())) {
                    continue;
                }

                char[] chars = str.ToCharArray();
                chars[i] = Char.ToUpper(str[i]);

                string wordToAdd = new string(chars);
                result.Add(wordToAdd.ToString());
            }

            return result;
        }
    }
}
