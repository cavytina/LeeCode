using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInsertPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solu = new Solution();
            Console.WriteLine(solu.SearchInsert(new int[] { 1, 3, 5, 6 }, 0).ToString());

            Console.ReadKey();
        }

        public class Solution
        {
            public int SearchInsert(int[] nums, int target)
            {
                int index = 0;
                while (index < nums.Length)
                {
                    if (nums[index] >= target)
                        break;
                    index++;
                }

                return index;
            }
        }
    }
}
