using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesfromSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solu = new Solution();
            Console.WriteLine(solu.RemoveDuplicates(new int[] { }).ToString());

            Console.ReadKey();
        }

        public class Solution
        {
            public int RemoveDuplicates(int[] nums)
            {
                int len = nums.Length == 0 ? 0 : 1;

                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] != nums[j])
                        {
                            for (int k = i + 1; k < j; k++)
                            {
                                nums[k] = nums[j];
                            }
                            len++;
                            break;
                        }
                    }
                }

                return len;
            }
        }
    }
}
