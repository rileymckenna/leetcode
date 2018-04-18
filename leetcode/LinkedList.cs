using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    class LinkedList
    {
        LinkedList next = null;
        int data;

        public LinkedList(int d)
        {
            data = d;
        }

        public void Append(int d)
        {
            LinkedList end = new LinkedList(d);
            LinkedList l = this;
            while (l.next != null)
            {
                l = l.next;
            }
            l.next = end;
        }
        public LinkedList DeleteNode(LinkedList n, int d)
        {
            LinkedList linkedList = n;
            if(n.data == d)
            {
                return n.next;
            }
            while(linkedList.next != null)
            {
                if(linkedList.next.data == d)
                {
                    linkedList.next = linkedList.next.next;
                    return n;
                }
                n = n.next;
            }
            return n;
        }

        public LinkedList RemoveDuplicates(LinkedList list)
        {
            LinkedList head = list;
            int dup = head.data;
            while (list.next != null)
            {
                if(head.next.data != dup)
                {
                    head = head.next;
                    continue;
                }
                else { head = DeleteNode(list, dup); }
                list = list.next;
            }
            return head;
        }
        public int GetLength(LinkedList list)
        {
            int count;
            if (list == null) { return 0; }
            else {
                count = GetLength(list.next) +1; }
            return count;
        }
    }
}
