using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solu=new Solution();

            foreach (int i in solu.TwoSum(new int[] { 2, 7, 11,15 }, 9))
            {
                Console.WriteLine("result="+i.ToString());
            }

            Console.ReadKey();  
        }
    }

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result=new int[] {0,0};

            for (int i = 0; i <= nums.Length - 1; i++)
            {
                for (int j = 0; j <= nums.Length - 1; j++)
                {
                    if ((i != j) && (nums[i] + nums[j] == target))
                    {
                        result = new int[] { i, j };
                        break;
                    }
                }
            }

            return result;
        }
    }
}
