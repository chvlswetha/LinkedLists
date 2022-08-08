using System;

namespace RemoveDuplicates_LinkedList
{
    //Remove duplicates from an unsorted linked list.
    //Temporary buffer is not allowed?
    class Program
    {
        static void Main(string[] args)
        {
            Node a = new Node(7);
            Node b = new Node(5);
            Node c = new Node(4);
            Node d = new Node(5);
            Node e = new Node(8);
            Node f = new Node(7);
            Node g = new Node(4);
            Node h = new Node(6);

            a.next = b;
            b.next = c;
            c.next = d;
            d.next = e;
            e.next = f;
            f.next = g;
            g.next = h;
            Console.WriteLine("input data:");
            print_N(a);

            Node head = MergeSort(a);

            Console.WriteLine(" \nSorted data:");
            print_N(head);

            Node Final = RemoveDuplicates(head);

            Console.WriteLine(" \n After Removing duplicate data:");
            print_N(Final);

        }

        static Node RemoveDuplicates(Node head)
        {
            Node curr = head;
            while(curr != null)
            {
                while (curr.next != null && curr.data == curr.next.data)
                    curr.next = curr.next.next;
                curr = curr.next;
            }
            return head;
        }
       static Node MergeSort(Node head)
        {

            if (head.next == null)
                return head;

            Node mid = findmid(head);
            Node head1 = head;
            Node head2 = mid.next;
            mid.next = null;

            Node Nh1 = MergeSort(head);
            Node Nh2 = MergeSort(head2);

            Node Merged = Merge(Nh1, Nh2);

            return Merged;

        }

        static Node findmid(Node head)
        {
            Node s = head;
            Node f = head.next;
            while (f != null && f.next != null)
            {
                s = s.next;
                f = f.next.next;
            }
            return s;
        }

        static Node Merge(Node head1, Node head2)
        {
            Node Merged = new Node(-1);
            Node temp = Merged;

           while(head1 != null && head2 != null)
            {
                if (head1.data < head2.data)
                {
                    temp.next = head1;
                    head1 = head1.next;

                }
                else
                {
                    temp.next = head2;
                    head2 = head2.next;
                }
                temp = temp.next;
            }

           while( head1 != null)
            {
                temp.next = head1;
                head1 = head1.next;
                temp = temp.next;
            }

            while (head2 != null)
            {
                temp.next = head2;
                head2 = head2.next;
                temp = temp.next;
            }

            return Merged.next;

        }

        static void print_N(Node ptr)
        {
            while (ptr != null)
            {
                Console.Write(ptr.data + "->");
                ptr = ptr.next;
            }
        }
    }
    public class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
}
