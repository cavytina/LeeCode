using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution su = new Solution();
            Console.WriteLine(su.IsPalindrome(123321).ToString());

            Console.ReadKey();
        }
    }

    public class Solution
    {
        int y; //取模
        int z; //取余
        int k; //取最高位幂数

        int[] result_split = new int[11];   //底数

        int result;

        public bool IsPalindrome(int x)
        {
            if ((x < int.MaxValue) && (x >= 0))
            {
                int m = x;
                if (x < 0) m = Math.Abs(m);

                for (int i = 10; i >= 0; i--)
                {
                    y = Convert.ToInt32(Math.Floor(m / Math.Pow(10, i)));
                    z = Convert.ToInt32(Math.Floor(m % Math.Pow(10, i)));
                    m = z;

                    result_split[i] = y;
                }

                for (int j = 0; j <= 10; j++)
                {
                    if (result_split[j] > 0) k = j;
                }

                for (int u = 0; u <= k; u++)
                {

                    result += result_split[u] * Convert.ToInt32(Math.Pow(10, k - u));
                }

                if (x == result) return true;
            }

            return false;
        }
    }
}