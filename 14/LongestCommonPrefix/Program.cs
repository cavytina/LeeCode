using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solu = new Solution();
            Console.WriteLine(solu.LongestCommonPrefix(new string[] {"c","acc","ccc"}));

            Console.ReadKey();
        }

        public class Solution
        {
            public string LongestCommonPrefix(string[] strs)
            {
                int strsMinlen = int.MaxValue;
                bool isMatched = true;
                string strMatch = "";
                String strResult = "";

                if (strs.Length==0)
                    return strResult;

                for (int g = 0; g <strs.Length; g++)
                {
                    if (strsMinlen > strs[g].Length)
                        strsMinlen = strs[g].Length;
                }

                if (strsMinlen > 0)
                {
                    for (int i = 0; i < strsMinlen; i++)
                    {
                            strMatch = strs[0].Substring(i, 1);

                        if (isMatched)
                        {
                            for (int j = 1; j < strs.Length; j++)
                            {
                                if (strs[j].IndexOf(strMatch, i, 1) == i)
                                    isMatched = true;
                                else
                                {
                                    isMatched = false;
                                    break;
                                }
                            }
                        }

                        if (isMatched)
                            strResult += strMatch;
                    }
                }

                return strResult;
            }
        }
    }
}
