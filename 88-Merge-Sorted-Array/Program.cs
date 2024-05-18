//88. Merge Sorted Array
//You are given two integer arrays nums1 and nums2, sorted in non-decreasing order,
//and two integers m and n, representing the number of elements in nums1 and nums2 respectively.

//Merge nums1 and nums2 into a single array sorted in non-decreasing order.

//The final sorted array should not be returned by the function, but instead be stored inside the array nums1.
//To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged,
//and the last n elements are set to 0 and should be ignored. nums2 has a length of n.

//Example 1:

//Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
//Output: [1,2,2,3,5,6]
//Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
//The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.
//Example 2:

//Input: nums1 = [1], m = 1, nums2 = [], n = 0
//Output: [1]
//Explanation: The arrays we are merging are [1] and [].
//The result of the merge is [1].
//Example 3:

//Input: nums1 = [0], m = 0, nums2 = [1], n = 1
//Output: [1]
//Explanation: The arrays we are merging are [] and [1].
//The result of the merge is [1].
//Note that because m = 0, there are no elements in nums1. The 0 is only there to ensure the merge result can fit in nums1.Example 1:

//Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
//Output: [1,2,2,3,5,6]
//Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
//The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.
//Example 2:

//Input: nums1 = [1], m = 1, nums2 = [], n = 0
//Output: [1]
//Explanation: The arrays we are merging are [1] and [].
//The result of the merge is [1].
//Example 3:

//Input: nums1 = [0], m = 0, nums2 = [1], n = 1
//Output: [1]
//Explanation: The arrays we are merging are [] and [1].
//The result of the merge is [1].
//Note that because m = 0, there are no elements in nums1. The 0 is only there to ensure the merge result can fit in nums1.


//Start of program
namespace _88_Merge_Sorted_Array
{
    class Program
    {
        public static int[] Merge(int[] nums1, int m, int[] nums2, int n)
        {

            var j = 0;

            for (var i = m; i < nums1.Length; i++)
            {

                nums1[i] = nums2[j];
                j++;

            }

            Array.Sort(nums1);
            return nums1;

        }
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter the values of the 1st array.\nPlease take into account to separate the values with a ','. ");
            Console.Write("1st array: ");

            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input)) { throw new ArgumentNullException(); }

            var inputArray = input.Split(",");

            int[] intArray = new int[inputArray.Length];
            var i = 0;
            foreach (var number in inputArray)
            {
                intArray[i] = int.Parse(number); i++;
            }


            int[] nums1 = intArray;
            var m = nums1.Length;

            Console.WriteLine("Please enter the values of the 2nd array.\nPlease take into account to separate the values with a ','. ");
            Console.Write("2nd array: ");

            input = Console.ReadLine();

            Console.WriteLine("\nProcessing...");

            if (string.IsNullOrWhiteSpace(input)) { throw new ArgumentNullException(); }

            inputArray = input.Split(",");

            intArray = new int[inputArray.Length];
            i = 0;
            foreach (var number in inputArray)
            {
                intArray[i] = int.Parse(number); i++;
            }


            int[] nums2 = intArray;
            var n = nums2.Length;

            Array.Resize(ref nums1, nums1.Length + nums2.Length);

            var resultArray = Merge(nums1, m, nums2, n);
            Console.WriteLine("\n");
            Console.Write("The final resulting array is: [ ");
            foreach (var number in resultArray)
            {

                Console.Write(number + " ");
            }
            Console.Write("]");

        }
    }
}
// End of program