using System;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", SortNumbers(null)));
        }

        public static int[] SortNumbers(int[] nums)
        {
            if (nums == null) {
                return new int[] {};
            }

            Array.Sort(nums);
            return nums;
        }
    }
}
