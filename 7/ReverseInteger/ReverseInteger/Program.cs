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
            Console.WriteLine(su.Reverse(1534236469).ToString());

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

        public int Reverse(int x)
        {
            if (x <= int.MinValue || (x >= int.MaxValue))
                return 0;
            else
            {

                int m = x;
                if (x < 0) m = Math.Abs(m);

                for (int i = 9; i >= 0; i--)
                {
                    y = Convert.ToInt32(Math.Floor(m / Math.Pow(10, i)));
                    z = Convert.ToInt32(Math.Floor(m % Math.Pow(10, i)));
                    m = z;

                    Console.WriteLine("y=" + y.ToString());

                    result_split[i] = y;
                }

                for (int j = 0; j < 10; j++)
                {
                    if (result_split[j] > 0) k = j;
                }

                Console.WriteLine("k=" + k.ToString());

                for (int u = 0; u <= k; u++)
                {
                    result += result_split[u] * Convert.ToInt32(Math.Pow(10, k - u));
                }

                if (x < 0) result = -result;

                return result;
            }
        }
    }
}
