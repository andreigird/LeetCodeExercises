using System.Collections;
using System.Collections.Specialized;
using System.Globalization;

// 1. Two Sum
//Given an array of integers nums and an integer target,
//return indices of the two numbers such that they add up to target.
//
//You may assume that each input would have exactly one solution,
//and you may not use the same element twice.
//
//You can return the answer in any order.


class Program
{
    public int[] TwoSum(int[] nums, int target)
    {

        Dictionary<int, int> d = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (d.ContainsKey(target - nums[i]) && i != d[target - nums[i]]) return new int[] { i, d[target - nums[i]] };

            d[nums[i]] = i;

        }
        return new int[] {};

    }
    static void Main(string[] args)
    {
        int[] nums = [3,3];
        var target = 6;

        var result = new Program().TwoSum(nums, target);

        foreach (int x in result)
        {
            Console.WriteLine(x);
        }
    }
}