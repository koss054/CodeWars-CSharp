using System;
using System.Linq;

namespace VowelCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetVowelCount("abracadabra"));
        }

        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;

            vowelCount = str.Count(c => "aeiou".Contains(Char.ToLower(c)));

            return vowelCount;
        }
    }
}

// Return the number (count) of vowels in the given string.
// We will consider a, e, i, o, u as vowels for this Kata (but not y).
// The input string will only consist of lower case letters and/or spaces.
