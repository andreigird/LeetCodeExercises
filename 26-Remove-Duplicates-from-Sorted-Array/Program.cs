//Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once.
//The relative order of the elements should be kept the same. Then return the number of unique elements in nums.

//Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:

//Change the array nums such that the first k elements of nums contain the unique elements in the order they were present in nums initially.
//The remaining elements of nums are not important as well as the size of nums.
//Return k.

namespace _26_Remove_Duplicates_from_Sorted_Array
{
    class Program
    {
        public int RemoveDuplicates(int[] nums)
        {
            var k = 1;
            var currentNumberTested = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == currentNumberTested)
                {
                    nums[i] = 255;
                }
                else { k++; currentNumberTested = nums[i]; }
            }
            Array.Sort(nums);
            return k;
        }
        static void Main(string[] args)
        {
            int[] nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
            var k = new Program().RemoveDuplicates(nums);
            Console.WriteLine("No. of unique numbers: " + k);
            Console.WriteLine("Final array result...");
            foreach (int i in nums)
            {
                Console.Write(i + ", ");
            }
        }
    }
}