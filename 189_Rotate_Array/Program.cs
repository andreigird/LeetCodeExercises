//189. Rotate Array
//
//Given an integer array nums,
//rotate the array to the right by k steps,
//where k is non-negative.
//Example 1:

//Input: nums = [1, 2, 3, 4, 5, 6, 7], k = 3
//Output: [5,6,7,1,2,3,4]
//Explanation:
//rotate 1 steps to the right: [7,1,2,3,4,5,6]
//rotate 2 steps to the right: [6,7,1,2,3,4,5]
//rotate 3 steps to the right: [5,6,7,1,2,3,4]
//Example 2:

//Input: nums = [-1, -100, 3, 99], k = 2
//Output: [3,99,-1,-100]
//Explanation:
//rotate 1 steps to the right: [99,-1,-100,3]
//rotate 2 steps to the right: [3,99,-1,-100]

using System;
using System.Xml;

namespace _189_Rotate_Array
{
    class Program
    {
        public void Rotate(int[] nums, int k)
        {           
            k = k % nums.Length; //for when k is larger than the length of the list;
            Array.Reverse(nums);
            Array.Reverse(nums, 0, k);
            Array.Reverse(nums, k, nums.Length-k);

        }
        private static void Main(string[] args)
        {
            int[] nums = [1, 2, 3, 4, 5, 6, 7];
            var k = 8;


            new Program().Rotate(nums, k);

            foreach (var x in nums)
            {
                Console.WriteLine(x);
            }
        }
    }
}