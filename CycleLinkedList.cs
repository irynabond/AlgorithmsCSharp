using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    static class CycleLinkedList
    {
        public static void IsCircular ()
        {
            Node head = CycleLinkedList.GenerateLL();

            if (head.Next == null)
            {
                Console.WriteLine(false);
            }
            if (head == null)
            {
                Console.WriteLine(false);
            }

            Node slow = head.Next;
            Node fast = head.Next.Next;

            while (slow != fast &&fast!=null && fast.Next!=null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            if (slow == fast)
            {
                Console.WriteLine(true);
            } else
            {
                Console.WriteLine(false);
            }
        }

        public static Node GenerateLL ()
        {
            Node head = new Node(1);
            Node node2 = new Node(2);
            head.Next = node2;
            node2.Next = new Node(3);
            node2.Next.Next = new Node(4);
            node2.Next.Next.Next = new Node(5);
            //node2.Next.Next.Next.Next = new Node(6);
            return head;
        }
    }
}
