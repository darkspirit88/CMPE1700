using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMPE1700SJoICA8
{
    class Program
    {
        public class Node
        {
            // Node's internal data
            public int Value;
            //Reference to next tiem in the list(classes are reference types)
            public Node Next;

            
            //ctors
            public Node()
            {
                Value = 0;
                Next = null;
            }
            public Node(int val)
            {
                Value = val;
                Next = null;
            }
        }
        
        //Singly linked list methods
        static public Node AddToTail(Node Head, int Value)
        {
            Node Fresh = new Node(Value);

            //Do I have an empty list? Just return my node
            if (Head == null)
                return Fresh;

            //Otherwise
            Node Current = Head;
            while (Current.Next != null)
                Current = Current.Next;
            Current.Next = Fresh;
            
            return Head;
        }
        static public Node AddToHead(Node Head, int Value)
        {
            Node Fresh = new Node(Value);
            Fresh.Next = Head;
            return Fresh;
        }

        static public Node Reverse(Node Head)
        {
            Node reverse = new Node(Head.Value);
            while (Head.Next != null)
            {
                Head = Head.Next;
                Node temp = reverse;
                reverse = new Node(Head.Value);
                reverse.Next = temp;
            }
            return reverse;
        }
        static void PrintList(Node Head)
        {
            while (Head != null)
            {
                Console.Write(Head.Value + " ");
                Head = Head.Next;
            }
   
        }

        static void Main(string[] args)
        {
            Random rand = new Random();
            Node Head = null;
            for (int i = 0; i < 10; i++)
                Head = AddToHead(Head, i);
            
            PrintList(Head);
            
            Console.ReadLine();
        }
    }
}
