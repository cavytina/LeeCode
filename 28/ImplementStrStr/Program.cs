using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementStrStr
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solu = new Solution();
            Console.WriteLine(solu.StrStr("aaa", "a"));

            Console.ReadKey();
        }

        public class Solution
        {
            public int StrStr(string haystack, string needle)
            {
                int index = -1;
                if (needle.Length == 0)
                {
                    index = 0;
                }
                else
                {
                    for (int i = 0; i <= haystack.Length - needle.Length; i++)
                    {
                        if (needle == haystack.Substring(i, needle.Length))
                        {
                            index = i;
                            break;
                        }
                    }
                }

                return index;
            }
        }
    }
}
