using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums1 = new int[] { };
            int[] nums2 = new int[] { 2,1 };
            //double mean = FindMedianSortedArrays(nums1, nums2);
            //System.Console.WriteLine("Mean:" + mean);
            //TreeNode tree = new TreeNode(9);
            //TreeNode rb = new TreeNode(6);
            //tree.add(tree, new TreeNode(3), rb.add(rb, new TreeNode(12), new TreeNode(13)));
            //System.Console.WriteLine(MaxDepth(tree));
            //int[] arr = new int[] { 0,1, 2, 0, 3, 0, 5, 7, 0, 9 };
            //MoveZeroes(arr);
            //ListNode ln = new ListNode(1);
            //ln.add(ln, new ListNode(6));
            //ln.add(ln.next, new ListNode(2));
            //ln.add(ln.next.next, new ListNode(3));
            //ln.add(ln.next.next.next, new ListNode(4));
            //ln.add(ln.next.next.next.next, new ListNode(6));
            //ln = RemoveElements(ln, 6);
            //System.Console.WriteLine(ln.val);
            //System.Console.WriteLine(ln.next.val);
            //System.Console.WriteLine(ln.next.next.val);
            //System.Console.WriteLine(ln.next.next.next.val);
            //System.Console.WriteLine(ln.next.next.next.next.val);
            // System.Console.WriteLine(ln.next.next.next.next.next.val);
            MaxProfit(nums2);



        }
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double median = 0.0;
            int[] combined = nums1.Concat(nums2).ToArray();
            Array.Sort(combined); 
            median = ((double)combined.Length + 1) / 2;
            return median; 
        }

        public static string ReverseString(string s)
        {
            char[] cArray = s.ToCharArray();
            Array.Reverse(cArray);
            return new string(cArray);
        }

        public static IList<string> FizzBuzz(int n)
        {
            IList<int> list = new List<int>();
            IList<string> list1 = new List<string>();
            string f = "Fizz";
            string b = "Buzz";
            string fb = f + b;
            for (int i = 1; i <= n; i++)
            {
                list.Add(i);
            }
            foreach(int i in list)
            {
                System.Console.WriteLine("i: " + i);
                if ((i % 3 == 0) & (i % 5 == 0))
                {
                    list1.Add(fb);
                }
                else if (i % 5 == 0)
                {
                    list1.Add(b);
                }
                else if (i % 3 == 0)
                {
                    list1.Add(f);
                }
                else
                {
                    list1.Add(i.ToString());
                }
            }
            return list1;
        }

        public static int SingleNumber(int[] nums)
        {
            int num = 0;
            foreach(int i in nums)
            {
                num ^= i;
            }
            return num;
        }
        public class TreeNode
        {
          public int val;
          public TreeNode left;
          public TreeNode right;
          public TreeNode add(TreeNode root, TreeNode l, TreeNode r) { root.left = l; root.right = r; return root; }
          public TreeNode(int x) { val = x; }
  }
        public static int MaxDepth(TreeNode root)
        {
            if(root == null)
            {
                return 0;
            }
            int ldepth = 1 + MaxDepth(root.left);
            int rdepth = 1 + MaxDepth(root.right);

            return Math.Max(ldepth,rdepth); 
        }

        public static void MoveZeroes(int[] array)
        {
            int len = array.Length;
            int zeroPosition = -1;
            int zero = 0;
            for (int i = 0; i < len; i++)
            {
                if (zeroPosition == -1)
                {
                    if (array[i] == zero)
                    {
                        zeroPosition = i;
                    }
                }
                else
                {
                    if (array[i] != zero)
                    {
                        array[zeroPosition] = array[i];
                        array[i] = zero;
                        zeroPosition++;
                    }
                }
            }

        }
        public int RemoveElement(int[] nums, int val)
        {
            int len = nums.Length;
            int valPosition = -1;
            int zero = val;
            int eleCount = 0;
            for (int i = 0; i < len; i++)
            {
                if (nums[i] == val)
                {
                    eleCount++;
                }
                if (valPosition == -1)
                {
                    if (nums[i] == zero)
                    {
                        valPosition = i;
                    }
                }
                else
                {
                    if (nums[i] != zero)
                    {
                        nums[valPosition] = nums[i];
                        nums[i] = zero;
                        valPosition++;
                    }
                }
            }
            return len - eleCount;
        }
 public class ListNode
        {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
      public ListNode add(ListNode node, ListNode n) { node.next = n; return node; }
  }
        public static ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
            {
                return null;
            }
            else {
                if (head.val == val)
                {
                    return RemoveElements(head.next, val);
                }
                else
                {
                    head.next = RemoveElements(head.next, val);
                }
            }
            return head;
        }

        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
        public int GetSum(int a, int b)
        {
            return a+b;
        }
        public static int MaxProfit(int[] prices)
        {
            int ret = 0;
            for (int p = 1; p < prices.Length; ++p)
                ret += Math.Max(prices[p] - prices[p - 1], 0);
            return ret;
        }
    }
}
