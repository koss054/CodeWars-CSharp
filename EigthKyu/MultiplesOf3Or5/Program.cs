﻿using System;

namespace MultiplesOf3Or5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution(10));
        }

        public static int Solution(int value) {
            int sum = 0;

            for (int i = 0; i < value; i++) {
                if (i % 3 == 0 || i % 5 == 0) {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
