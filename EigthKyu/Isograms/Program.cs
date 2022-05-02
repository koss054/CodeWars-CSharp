using System;
using System.Collections.Generic;

namespace Isograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsIsogram("Dermatoglyphics"));
            Console.WriteLine(IsIsogram("aba"));
            Console.WriteLine(IsIsogram("moOse"));
        }

        public static bool IsIsogram(string str)
        {
            List<char> chars = new List<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (!Char.IsLetter(str[i])) {
                    return false;
                }

                if (chars.Contains(Char.ToLower(str[i]))) {
                    return false;
                }

                chars.Add(Char.ToLower(str[i]));
            }

            return true;
        }
    }
}

// An isogram is a word that has no repeating letters, consecutive or non-consecutive. 
// Implement a function that determines whether a string that contains only letters is an isogram. 
// Assume the empty string is an isogram. Ignore letter case.
