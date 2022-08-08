using System;

namespace BST_SortedLinkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            Node a1 = new Node(10);
            Node a2 = new Node(20);
            Node a3 = new Node(30);
            Node a4 = new Node(40);
            Node a5 = new Node(50);
            Node a6 = new Node(60);
            Node a7 = new Node(70);

            a1.next = a2;
            a2.next = a3;
            a3.next = a4;
            a4.next = a5;
            a5.next = a6;
            a6.next = a7;

            Console.WriteLine("\n Linkedlist");
            print(a1);

            TNode root = SortedBST(a1);

            Console.WriteLine("\n BST Tree\n");
            PreOrder(root);
      
        }
        static TNode SortedBST(Node head)
        {
            if (head == null)
                return null;
            Node mid = findmid(head);
            TNode root = new TNode(mid.data);

            if (head == mid)
                return root;

            root.left = SortedBST(head);
            root.right = SortedBST(mid.next);

            return root;
        }
        static Node findmid(Node head)
        {
            Node slow = head, fast = head;
            Node prev = head;

            while(fast != null && fast.next != null)
             {
                prev = slow;
                slow = slow.next;
                fast = fast.next.next;
            }
            if (prev != null)
                prev.next = null;
            return slow;
        }

        static void PreOrder(TNode head)
        {
            if (head == null)
                return;

            Console.Write(head.data + "->");
            PreOrder(head.left);            
            PreOrder(head.right);
        }

         static void print(Node head)
        {
            while (head != null)
            {
                Console.Write(head.data + "->");
                head = head.next;
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

    public class TNode
    {
        public int data;
        public TNode left,right;
        public TNode(int d)
        {
            data = d;
            left = null;
            right = null;
        }
    }


}
