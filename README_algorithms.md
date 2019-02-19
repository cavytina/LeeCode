# LeeCode算法题解题思路 #
## 1.Two Sum ##
这个似乎是LeeCode算法题里面最出名的了，由于第一次做算法题，题目涉及很多数组应用，复习用了很多时间。历时6小时左右。
### 自己 ###
    for (int j = 0; j <= nums.Length - 1; j++)
		{
			if ((i != j) && (nums[i] + nums[j] == target))
### 网上 ###
    for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
将i+1传入j的赋值，减少了判断条件，对程序有适当优化。
## 2.Reverse Integer ##
用了很多的时间在算最高位幂数上，思维偏线性。这道题有1032个测试，着实是吓了我一跳，并且有些测试是边界测试，应该引起注意
### 自己 ###
    for (int i = 10; i >= 0; i--)
    {
        y = Convert.ToInt32(Math.Floor(m / Math.Pow(10, i)));
        z = Convert.ToInt32(Math.Floor(m % Math.Pow(10, i)));
        m = z;

        result_split[i] = y;
    }
### 网上 ###
    while(x != 0)
    {
        try
        {
            checked
            {
                output = output * 10 + x % 10;
            }
        }
        catch(OverflowException)
        {
            return 0;
        }

        x = x / 10;
    }
网上的算法直接除10，绕去了算最高位幂数的步骤。
注意int类型边界测试。int值范围**[−231,  231 − 1]**
## 9. Palindrome Number ##
将7题做适当修改即可。
## 13. Roman to Integer ##
罗马字符的减法是运算的难点，采用将转换数组左移一位相减的办法得出最后结果。
### 自己 ###
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
### 网上 ###
	public IDictionary<string,int> map = new Dictionary<string,int>
    {
        {"I",1},
        {"V",5},
        {"X",10},
        {"L",50},
        {"C",100},
        {"D",500},
        {"M",1000},
        {"IV", 4},
        {"IX", 9},
        {"XL", 40},
        {"XC", 90},
        {"CD", 400},
        {"CM", 900}
    }
由于罗马减法只能由I、X、C前置构成，具有特殊性，网上解题方法充分抓住这一点，穷举出所有可能的罗马字符组合，并且保存字符组合使用的数据类型：字典也非常合适。
# 14. Longest Common Prefix #
开始尝试按照试题1思路，取第1个字符串，利用foreach(char ch in strs[0])循环处理字符，但是foreach循环不好对字符进行对比，所以放弃使用。
其后发现所有公共字符串前缀都应该在字符串数组相同位置，可以通过比较字符串数组相同位置上字符是否相同判断，可以使用string.IndexOf函数实现此功能。
最后引入strsMinlen变量找出字符串数组最小长度，防止由于字符串长度变小，引起索引超范围异常。
# 20. Valid Parentheses #
由题可知，括号数量应为偶数。并且将六种括号分为三组，分别引入三个变量记录总数：num_small、num_midlle、num_big，由题可知，变量必须>0。
由于题目要求括号必须按照先进后出的顺序排列，非常适合栈的数据结构，所以引入栈验证括号顺序。
根据测试用例"){"、"(("对括号顺序及括号总数是否为零进行判断。
# 26. Remove Duplicates from Sorted Array #
拿到题目看了半天，没有搞懂题目要求返回的长度是什么意思，参照了力扣中文网站，才弄明白是将不重复的数字排序后计算长度。
### 自己 ###
```
for (int i = 0; i < nums.Length; i++)
{
    for (int j = i + 1; j < nums.Length; j++)
    {
        if (nums[i] != nums[j])
        {
            for (int k = i + 1; k < j; k++)
            {
                nums[k] = nums[j];
            }
            len++;
            break;
        }
    }
}
```
### 网上 ###
```
for (int i = 1; i < nums.Length; i++)
{
    if (nums[i] != nums[j])
    {
        j++;
        nums[j] = nums[i];
    }
}
```
网上算法耗时300+ms，自己的算法耗时700+ms，使用3次循环增加了复杂度，应尽量寻找最优算法。
# 27. Remove Element #
