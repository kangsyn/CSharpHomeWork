using System;
namespace ConsoleApp3
{
    class Program
    {
 static  void Main(string[] args)
           {
            int[] nums = new int[101];
            for (int i = 2; i < 101; i++)
            {
                nums[i] = i;
            }
            for (int i = 2; i < 101; i++)
            {
                for (int j = 2; i * j < 101; j++)
                {
                    nums[i * j] = 0;
                }
            }
                for (int i = 2; i < 101; i++)
            {
                if (nums[i] != 0)
                {
                    Console.WriteLine(nums[i]);
                }
            }

        }
    }
}
