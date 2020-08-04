using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        public List<string> BinaryTreePaths(TreeNode root)
        {
            List<string> strList = new List<string>();
            TreeNode nodeCurrent, nodeRetain;
            nodeCurrent = nodeRetain = root;
            Dictionary<TreeNode, string> doubleNodeList = new Dictionary<TreeNode, string>();
            string str = nodeCurrent.val.ToString();

            while (nodeCurrent.left != null || nodeCurrent.right != null)
            {
                //第一种情况：只有单孩子，有可能是左边或是右边
                if (nodeCurrent.left != null && nodeCurrent.right == null)
                {
                    str += "->" + nodeCurrent.left.val.ToString();
                    nodeCurrent = nodeCurrent.left;
                    nodeRetain.left = null;
                    nodeRetain = nodeCurrent;

                    if (nodeCurrent.left != null || nodeCurrent.right != null)
                        continue;
                    else
                    {
                        strList.Add(str);
                        if (doubleNodeList.Count != 0)
                        {
                            nodeCurrent = doubleNodeList.Keys.Last();
                            str = doubleNodeList.Values.Last();
                            doubleNodeList.Remove(doubleNodeList.Keys.Last());
                            continue;
                        }
                    }

                }
                else if (nodeCurrent.left == null && nodeCurrent.right != null)
                {
                    str += "->" + nodeCurrent.right.val.ToString();
                    nodeCurrent = nodeCurrent.right;
                    nodeRetain.right = null;
                    nodeRetain = nodeCurrent;

                    if (nodeCurrent.left != null || nodeCurrent.right != null)
                        continue;
                    else
                    {
                        strList.Add(str);
                        if (doubleNodeList.Count != 0)
                        {
                            nodeCurrent = doubleNodeList.Keys.Last();
                            str = doubleNodeList.Values.Last();
                            doubleNodeList.Remove(doubleNodeList.Keys.Last());
                            continue;
                        }
                    }
                }
                //第二种情况：有两孩子,先取左边的
                else if (nodeCurrent.left != null && nodeCurrent.right != null)
                {
                    doubleNodeList.Add(nodeCurrent, str);
                    str += "->" + nodeCurrent.left.val.ToString();
                    nodeCurrent = nodeCurrent.left;
                    nodeRetain.left = null;
                    nodeRetain = nodeCurrent;

                    if (nodeCurrent.left != null || nodeCurrent.right != null)
                        continue;
                    else
                    {
                        strList.Add(str);
                        if (doubleNodeList.Count != 0)
                        {
                            nodeCurrent = doubleNodeList.Keys.Last();
                            str = doubleNodeList.Values.Last();
                            doubleNodeList.Remove(doubleNodeList.Keys.Last());
                            continue;
                        }
                    }
                }
            }

            return strList;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TreeNode third1 = new TreeNode(5, null, null);
            TreeNode second1 = new TreeNode(2, null, third1);
            TreeNode second2 = new TreeNode(3, null, null);
            TreeNode first = new TreeNode(1, second1, second2);

            Solution solo = new Solution();

            foreach (string str in solo.BinaryTreePaths(first))
                Console.WriteLine(str);

            Console.ReadKey();
        }
    }
}
