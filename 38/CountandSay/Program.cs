using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountandSay
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solu = new Solution();
            Console.WriteLine(solu.CountAndSay(6));

            Console.ReadKey();
        }

        public class Solution
        {
            public string CountAndSay(int n)
            {
                if (n == 1) return "1";
                //递归调用，然后对字符串处理
                string str = CountAndSay(n - 1) + "*";//为了str末尾的标记，方便循环读数
                int count = 1; //用于计算每个字符出现的次数；
                string s = "";
                for (int i = 0; i < str.Length - 1; i++) //因为增加了一个“*”,所以只能遍历到"*"之前的字符；
                {
                    if (str[i] == str[i + 1])
                    {
                        count++;//计数增加
                    }
                    else
                    {
                        s = s + count.ToString() + str[i];//个数在前，字符在后；
                        count = 1;//初始化，为后面的字符做准备；
                    }
                }
                return s;
            }
        }
    }
}
