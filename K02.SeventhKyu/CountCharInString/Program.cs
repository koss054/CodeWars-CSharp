using System;
using System.Collections.Generic;

namespace CountCharInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Count("abba"));
        }

        public static Dictionary<char, int> Count(string str)
        {
            var dict = new Dictionary<char, int>();

            if (str == string.Empty) {
                return dict;
            }

            for (int i = 0; i < str.Length; i++) {
                if (!dict.ContainsKey(str[i])) {
                    dict[str[i]] = 0;
                }

                dict[str[i]]++;
            }

            return dict;
        }
    }
}
