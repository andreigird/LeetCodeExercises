using System.ComponentModel;
using System.ComponentModel.Design;
using System.Globalization;
using System.Reflection.Metadata;

//80. Remove Duplicates from Sorted Array II
//
//Given an integer array nums sorted in non-decreasing order,
//remove some duplicates in-place such that each unique element appears at most twice.
//The relative order of the elements should be kept the same.
//
//Since it is impossible to change the length of the array in some languages,
//you must instead have the result be placed in the first part of the array nums.
//More formally, if there are k elements after removing the duplicates,
//then the first k elements of nums should hold the final result.
//It does not matter what you leave beyond the first k elements.
//
//Return k after placing the final result in the first k slots of nums.
//
//Do not allocate extra space for another array.
//You must do this by modifying the input array in-place with O(1) extra memory.
//
//Example 1:
//
//Input: nums = [1, 1, 1, 2, 2, 3]
//Output: 5, nums = [1, 1, 2, 2, 3, _]
//Explanation: Your function should return k = 5, with the first five elements of nums being 1, 1, 2, 2 and 3 respectively.
//It does not matter what you leave beyond the returned k (hence they are underscores).
//Example 2:
//
//Input: nums = [0, 0, 1, 1, 1, 1, 2, 3, 3]
//Output: 7, nums = [0, 0, 1, 1, 2, 3, 3, _, _]
//Explanation: Your function should return k = 7, with the first seven elements of nums being 0, 0, 1, 1, 2, 3 and 3 respectively.
//It does not matter what you leave beyond the returned k (hence they are underscores).


class Program
{
    public int RemoveDuplicates(int[] nums)
    {

        int OutOfScope = nums[nums.Length - 1] + 1;

        var k = 1;
        var duplicateCount = 0;
        var currentValue = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] != currentValue)
            {
                duplicateCount = 0;
                k++;
                currentValue = nums[i];
            }
            else if (nums[i] == currentValue && duplicateCount < 1)
            {
                duplicateCount++;
                k++;
                currentValue = nums[i];

            }
            else if (duplicateCount >= 1)
            {
                currentValue = nums[i];
                nums[i] = OutOfScope;
            }
            else
            {
                k++;
                duplicateCount = 0;
                currentValue = nums[i];

            }

        }

        Array.Sort(nums);

        return k;
    }
    static void Main(string[] args)
    {
        int[] nums = [0, 0, 1, 1, 1, 1, 2, 3, 3];

        var k = new Program().RemoveDuplicates(nums);

        Console.WriteLine(k);

        foreach (var number in nums)
        {
            Console.Write(number + ", ");
        }
    }
}