using System.ComponentModel.DataAnnotations;
//55. Jump Game
//
//You are given an integer array nums. You are initially positioned at the array's first index,
//and each element in the array represents your maximum jump length at that position.
//
//Return true if you can reach the last index, or false otherwise.
class Program
{
    public bool CanJump(int[] nums)
    {
        var maxReach = 0;

        for (var i = 0; i <= nums.Length - 1; i++)
        {

            maxReach = int.Max(maxReach, i + nums[i]);

            if (i > maxReach)
                return false;

            if (maxReach >= nums.Length - 1) return true;

            if (nums[i] == 0 && maxReach == i) break;

        }

        return false;
    }
    static void Main(string[] args)
    {
        int[] nums = [5, 9, 3, 2, 1, 0, 2, 3, 3, 1, 0, 0];
        //[1,1,0,1]
        //[1,1,1,0]
        //[2,5,0,0]
        //[2,0,0]
        //[3,0,8,2,0,0,1]
        //[1,1,2,2,0,1,1]
        //[2,3,0,1,4]
        //[3,2,1,0,4]
        //[5,9,3,2,1,0,2,3,3,1,0,0]

        var result = new Program().CanJump(nums);

        Console.WriteLine(result);

    }
}