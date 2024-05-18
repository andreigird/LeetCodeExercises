// See https://aka.ms/new-console-template for more information

using System;
using System.Runtime.CompilerServices;

namespace _27_Remove_Element
{
    public class Program
    {
        public int RemoveElement(int[] nums, int val)
        {
            var count = 0;

            var i = 0;
            foreach (var number in nums)
            {
                if (number == val)
                {
                    nums[i] = 255;
                    i++;
                    count++;

                }
                else
                {
                    i++;
                }
            }
            Array.Sort(nums);

            var finalCount = nums.Length - count;

            return finalCount;
        }
        static void Main(string[] args)
        {
            int[] nums = [3, 2, 2, 3];
            var val = 3;

            Console.WriteLine("START of program:");
            foreach (var number in nums) { Console.Write(number + " "); }

            var result = new Program().RemoveElement(nums, val);

            Console.WriteLine("Result is: " + result);
            Console.WriteLine("End of program:");
            foreach (var number in nums) { Console.Write(number + " "); }

        }
    }
}