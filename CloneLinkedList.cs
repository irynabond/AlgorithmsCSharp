using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Node
    {
        public Node (int data)
        {
            Data = data;
            Next = null;
            Random = null;
        }

        public int Data { get; set; }
        public Node Next { get; set; }
        public Node Random { get; set; }
    }
    static class CloneLinkedList
    {
        //Node head;
        public static Node GenerateLinkedList()
        {
            Node head = new Node(1);
            head.Next = new Node(2);
            head.Next.Next = new Node(3);
            head.Random = head.Next.Next;
            head.Next.Random = head;
            head.Next.Next.Random = head.Next;
            return head;
        } 
        
        public static Node CloneNodes(Node head)
        {           
            var current = head;

            while (current!=null)
            {
                Node node = new Node(current.Data);
                var next = current.Next;
                current.Next = node;
                node.Next = next;
                current = current.Next.Next;
            }
            return head;
        }

        public static Node CloneRandoms(Node head)
        {          
            var current = head;

            while (current!=null)
            {
                current.Next.Random = current.Random.Next;
                current = current.Next.Next;
            }

            return head;
        }

        public static List<Node> SeparateLists(Node head)
        {
            Node head1 = head;
            Node head2 = head1.Next;
            var current1 = head1;
            var current2 = head2;

            while (current2!=null)
            {
                
                current1.Next = current1.Next.Next;
                if (current2.Next==null)
                {
                    current2 = null;
                } else
                {
                    current2.Next = current2.Next.Next;
                    current1 = current1.Next;
                    current2 = current2.Next;
                }                         
            }

            List<Node> list = new List<Node>();
            list.Add(head1);
            list.Add(head2);
            return list;
        }

        public static void CloneListRandomPointer()
        {
            var list = GenerateLinkedList();
            list = CloneNodes(list);
            list = CloneRandoms(list);

            List<Node> ListOfwo = SeparateLists(list);
            
            foreach (var l in ListOfwo)
            {
                var current = l;
                while (current!=null)
                {
                    
                    Console.WriteLine(current.Data + " ");
                    current = current.Next;
                }
                Console.WriteLine("-------------------------------");
            }
        }
    }
}
