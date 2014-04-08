using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedListDemo
{
    class Program
    {
        public class Node
    {
        public string Value;
        public Node Next;
 
        public Node()
        {
            Value = "";
            Next = null;
        }
 
        public Node(string s)
        {
            Value = s;
            Next = null;
        }
        public Node(string s, Node n)
        {
            Value = s;
            Next = n;
        }
    }

        
        
        
        static void Main(string[] args)
        {
            Node Head = null; //Empty List
            Node Current = null; //Reference to node that is currently of interest
            Node Temp = null; //Used for creating a new node
            string data = null;

            //Populate my list
            do
            {
                Console.Write("Enter a string: ");
                data = Console.ReadLine();
                //Add data to list at end of list
                if (data.Length > 0)
                {
                    //Create my node
                    Temp = new Node(data);
                    //Find last node
                    if (Head == null)//List is empty
                    {
                        Head = Temp;
                    }
                    else
                    {
                        Current = Head; //Start at beginning
                        while (Current.Next != null) //If there is a next item
                            Current = Current.Next;//go to it.
                        //Now, insert after current (which should be the last item)
                        Current.Next = Temp;
                    }

                }
            }
            while (data.Length > 0);
            PrintList(Head);

            Console.ReadKey();

        }

        static public void PrintList(Node Head)
        {
            if (Head != null)
            {
                Console.WriteLine(Head.Value);
                PrintList(Head.Next);
            }
        }

    }
}
