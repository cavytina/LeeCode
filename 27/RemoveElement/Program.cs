using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solu = new Solution();
            Console.WriteLine(solu.RemoveElement(new int[] { 34, 45, 56, 2 }, 2).ToString());

            Console.ReadKey();
        }

        public class Solution
        {
            public int RemoveElement(int[] nums, int val)
            {
                int len = 0;
                int num = 0;                  //保存交换中间变量 

                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == val)
                    {
                        for (int k = nums.Length - 1; k >= 0; k--)
                        {
                            if ((nums[k] != val) && (i < k))
                            {
                                num = nums[i];
                                nums[i] = nums[k];
                                nums[k] = num;

                                len++;
                                break;
                            }
                        }
                    }
                    else
                    {
                        len++;
                    }

                }

                return len;
            }
        }
    }
}