using System;

namespace GetTheMiddleCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMiddle("test"));
            Console.WriteLine(GetMiddle("middle"));
            Console.WriteLine(GetMiddle("testing"));
            Console.WriteLine(GetMiddle("A"));
        }

        public static string GetMiddle(string s)
        {
            if (s.Length % 2 == 0) {
                return s.Substring((s.Length / 2) - 1, 2);
            }
            else {
                return s.Substring(s.Length / 2, 1);
            }
        }
    }
}

// You are going to be given a word. 
// Your job is to return the middle character of the word. 
// If the word's length is odd, return the middle character. 
// If the word's length is even, return the middle 2 characters.