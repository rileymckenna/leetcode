
namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums1 = new int[] { };
            int[] nums2 = new int[] { 2, 1 };
            //double mean = FindMedianSortedArrays(nums1, nums2);
            //System.Console.WriteLine("Mean:" + mean);
            //TreeNode tree = new TreeNode(9);
            //TreeNode rb = new TreeNode(6);
            //tree.add(tree, new TreeNode(3), rb.add(rb, new TreeNode(12), new TreeNode(13)));
            //System.Console.WriteLine(MaxDepth(tree));
            //int[] arr = new int[] { 0,1, 2, 0, 3, 0, 5, 7, 0, 9 };
            //MoveZeroes(arr);
            //ListNode ln = new ListNode(1);
            //ln.add(ln, new ListNode(2));
            //ln.add(ln.next, new ListNode(4));
            //ListNode ln2 = new ListNode(1);
            //ln2.add(ln2, new ListNode(3));
            //ln2.add(ln2.next, new ListNode(4));
            ////ln.add(ln.next.next.next.next, new ListNode(6));
            ////ListNode ln1 = ReverseList(null);
            ////ln = RemoveElements(ln, 6);
            //ListNode ln1 = MergeTwoLists(ln, ln2);
            //System.Console.WriteLine(ln1.val);
            //System.Console.WriteLine(ln1.next.val);
            //System.Console.WriteLine(ln1.next.next.val);
            //System.Console.WriteLine(ln1.next.next.next.val);
            //System.Console.WriteLine(ln1.next.next.next.next.val);
            //System.Console.WriteLine(ln1.next.next.next.next.next.val);
            //MaxProfit(nums2);
            LinkedList linkedList = new LinkedList(1);
            linkedList.Append(2);
            linkedList.Append(4);
            linkedList.Append(5);
            linkedList.Append(2);
            System.Console.Write(linkedList.RemoveDuplicates(linkedList));
        }
    }  
}
