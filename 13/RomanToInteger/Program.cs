using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solu = new Solution();
            Console.WriteLine(solu.RomanToInt("MCMXCIV").ToString());

            Console.ReadKey();
        }

        public class Solution
        {
            public int RomanToInt(string s)
            {
                int i = 0;
                int result = 0;

                int[] nums = new int[s.Length];
                int[] nums_shift = new int[s.Length];
                int[] nums_subtract = new int[s.Length];

                foreach (char ch in s)
                {
                    switch (ch)
                    {
                        case 'I': nums[i] = 1;
                            break;
                        case 'V': nums[i] = 5;
                            break;
                        case 'X': nums[i] = 10;
                            break;
                        case 'L': nums[i] = 50;
                            break;
                        case 'C': nums[i] = 100;
                            break;
                        case 'D': nums[i] = 500;
                            break;
                        case 'M': nums[i] = 1000;
                            break;
                    }
                    i++;
                }

                for(int j=0;j<nums_shift.Length-1;j++)
                {
                    nums_shift[j] = nums[j + 1];
                }

                for (int k = 0; k < nums_subtract.Length; k++)
                {
                    if (nums[k] >= nums_shift[k])
                    {
                        nums_subtract[k] = nums[k];
                    }
                    else if (nums[k] < nums_shift[k])
                    {
                        nums_subtract[k] = nums_shift[k] - nums[k];
                        k++;
                    }
                }

                foreach (int h in nums_subtract)
                {
                    result += h;
                }

                return result;
            }
        }
    }
}
