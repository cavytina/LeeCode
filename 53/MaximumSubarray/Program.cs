using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumSubarray
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solu = new Solution();
            solu.MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });

            Console.ReadKey();
        }

        public class Solution
        {
            public int MaxSubArray(int[] nums)
            {
                for (int i = 1; i < nums.Length; i++)
                {
                    nums[i] = Math.Max(nums[i], nums[i] + nums[i - 1]);
                    nums[0] = Math.Max(nums[0], nums[i]);
                }
                return nums[0];
            }
        }
    }
}
