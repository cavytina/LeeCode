using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solu = new Solution();
            Console.WriteLine(solu.IsPalindrome(1).ToString());

            Console.ReadLine();
        }

        public class Solution
        {
            public bool IsPalindrome(int x)
            {
                return true;
            }
        }
    }
}
