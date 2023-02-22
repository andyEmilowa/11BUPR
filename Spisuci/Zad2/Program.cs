using System;
using System.Collections.Generic;
using System.Linq;

namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            string num =Console.ReadLine();
           int[]nums = num.Split().Select(int.Parse).ToArray();
            nums = nums.Where(n => n == 0).ToArray();
            if (nums.Length == 0)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                Array.Reverse(nums);
                Console.WriteLine(string.Join(" ", nums));
            }


        }
    }
}
