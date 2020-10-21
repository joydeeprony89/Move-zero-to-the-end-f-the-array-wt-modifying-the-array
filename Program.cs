using System;

namespace Move_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 0,1,0,3,12 };
            MoveZeroes(nums);
            foreach (int i in nums)
                Console.WriteLine(i);
        }

        static void MoveZeroes(int[] nums)
        {
            int zeroCount = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0) zeroCount ++;
                else
                {
                    int temp = nums[i];
                    nums[i] = 0;
                    nums[i - zeroCount] = temp;
                }
            }
        }
    }
}
