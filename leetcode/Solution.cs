using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    class Solution
    {
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
            foreach (int i in list)
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
            foreach (int i in nums)
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
            if (root == null)
            {
                return 0;
            }
            int ldepth = 1 + MaxDepth(root.left);
            int rdepth = 1 + MaxDepth(root.right);

            return Math.Max(ldepth, rdepth);
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
            else
            {
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
            return a + b;
        }
        public static int MaxProfit(int[] prices)
        {
            int ret = 0;
            for (int p = 1; p < prices.Length; ++p)
                ret += Math.Max(prices[p] - prices[p - 1], 0);
            return ret;
        }

        public static ListNode ReverseList(ListNode head)
        {
            ListNode newHead;
            if (head == null || head.next == null)
            { return head; }
            else
            {
                newHead = ReverseList(head.next);
                head.next.next = head;
                head.next = null;
                return newHead;
            }
        }

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode newHead;
            if (l1 == null)
            {
                return l2;
            }
            if (l2 == null)
            {
                return l1;
            }
            if (l1.val < l2.val)
            {
                newHead = l1;
                newHead.next = MergeTwoLists(l1.next, l2);
            }
            else
            {
                newHead = l2;
                newHead.next = MergeTwoLists(l1, l2.next);
            }
            return newHead;
        }
        public static int Rob(int[] nums)
        {
            int routea = 0;
            int routeb = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums.Length < 2)
                {
                    return nums[i];
                }
                if (i % 2 == 0)
                {
                    routea += max(nums[i], routeb);
                }
                else
                {
                    routeb += max(nums[i], routea);
                }
            }
            return max(routea, routeb);
        }
        public static int max(int x, int y)
        {
            if (x > y)
            {
                return x;
            }
            return y;
        }
        public int NumJewelsInStones(string J, string S)
        {
            int jewelcount = 0;
            foreach (char j in J)
            {
                foreach (char s in S)
                {
                    if (j == s)
                    {
                        jewelcount++;
                    }
                }
            }
            return jewelcount;
        }

        public static int[] AnagramMappings(int[] A, int[] B)
        {
            int[] p = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i] == B[j])
                    {
                        p[i] = j;
                    }
                }
            }
            return p;
        }
        public static int CountBattleships(char[,] board)
        {

            var count = 0;

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] != 'X') continue;
                    if (i > 0 && board[i - 1, j] == 'X') continue;
                    if (j > 0 && board[i, j - 1] == 'X') continue;

                    count++;
                }
            }

            return count;
        }

        public static int LargestBSTSubtree(TreeNode root)
        {
            int count = 0;
            if (root == null)
            {
                return 0;
            }
            else
            {
                count += Math.Max(LargestBSTSubtree(root.left), LargestBSTSubtree(root.right));
            }
            return count;
        }

        public int RomanToInt(string s)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add('I', 1);
            hashtable.Add('V', 5);
            hashtable.Add('X', 10);
            hashtable.Add('L', 50);
            hashtable.Add('C', 100);
            hashtable.Add('D', 500);
            hashtable.Add('M', 1000);
            int count = 0;
            int pre = 0;
            int now = 0;
            return 0;
        }
    }
}
