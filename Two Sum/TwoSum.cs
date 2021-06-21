using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = TwoSum(new int[] { 3,3 },6);
            foreach (int i in mas) { Console.WriteLine(i); }
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int[] mas = new int[2];
            bool flag = false;
            for(int i=0;i<nums.Length;i++)
            {
                int temp = nums[i];
                for(int j=0;j<nums.Length;j++)
                {
                    if(temp + nums[j] == target && i!=j)
                    {
                        mas[0] = i;
                        mas[1] = j;
                        
                        flag = true;
                        break;
                    }
                }
                if (flag == true) { break; }
            }
            return mas;
        }
    }
}
