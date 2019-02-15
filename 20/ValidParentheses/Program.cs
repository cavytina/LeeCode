using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solu = new Solution();
            Console.WriteLine(solu.IsValid("(("));
            Console.ReadKey();

        }

        public class Solution
        {
            public bool IsValid(string s)
            {
                int num_small = 0, num_midlle = 0, num_big = 0;
                Stack<char> stack = new Stack<char>();

                if (s == string.Empty)
                    return true;

                if (s.Length % 2 == 1)
                    return false;

                foreach (char ch in s)
                {
                    switch (ch)
                    {
                        case '(':
                            num_small += 1;
                            stack.Push('(');
                            break;
                        case ')':
                            num_small -= 1;
                            if (stack.Count > 0)
                            {
                                if ('(' != stack.Pop())
                                    return false;
                            }
                            break;
                        case '[':
                            num_midlle += 1;
                            stack.Push('[');
                            break;
                        case ']':
                            num_midlle -= 1;
                            if (stack.Count > 0)
                            {
                                if ('[' != stack.Pop())
                                    return false;
                            }
                            break;
                        case '{':
                            num_big += 1;
                            stack.Push('{');
                            break;
                        case '}':
                            num_big -= 1;
                            if (stack.Count > 0)
                            {
                                if ('{' != stack.Pop())
                                    return false;
                            }
                            break;
                    }

                    //Console.WriteLine(String.Format("num_small={0};num_midlle={1};num_big={2}", num_small.ToString(), num_midlle.ToString(), num_big.ToString()));

                    if (num_small < 0 || num_midlle < 0 || num_big < 0)
                        return false;
                }

                if (num_small != 0 || num_midlle != 0 || num_big != 0)
                    return false;

                return true;
            }
        }
    }
}
