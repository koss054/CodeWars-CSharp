using System;

namespace FindNextSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindNextSquare(121));
            Console.WriteLine(FindNextSquare(625));
            Console.WriteLine(FindNextSquare(114));
        }

        public static long FindNextSquare(long num)
        {
            double squaredNumber = Math.Sqrt(num);

            if (squaredNumber % 1 != 0) {
                return -1;
            }

            squaredNumber++;
            return (long)Math.Pow(squaredNumber, 2);
        }
    }
}

// You might know some pretty large perfect squares. But what about the NEXT one?
// Complete the findNextSquare method that finds the next integral perfect square after the one passed as a parameter. 
// Recall that an integral perfect square is an integer n such that sqrt(n) is also an integer.
// If the parameter is itself not a perfect square then -1 should be returned. 
// You may assume the parameter is non-negative.