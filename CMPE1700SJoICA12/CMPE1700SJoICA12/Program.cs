using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMPE1700SJoICA12
{
    class Program
    {
        public class Node
        {
            public int Value;
            public Node Next;

            public Node()
            {
                Value = 0;
                Next = null;
            }
            public Node(int s)
            {
                Value = s;
                Next = null;
            }
            public Node(int s, Node n)
            {
                Value = s;
                Next = n;
            }

        }
        
        
        
        static void Main(string[] args)
        {
            Random generator = new Random();
            int value;
            List<int> numbers = new List<int>();
            LinkedList<int> values = new LinkedList<int>();

            for (int x = 0; x <= 100; x++)
            {
                value = generator.Next(-99, 100);
                numbers.Add(value);
                values.AddLast(value);
            }

            var array = values.ToArray();

            foreach (int x in numbers)
            {
                //Console.WriteLine(x);
            }

            SelectionSort(numbers);

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
            
            foreach(int x in numbers)
            {
                //Console.WriteLine(x);
            }

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");

            foreach (int x in array)
            {
                Console.WriteLine(x);
            }

            array = InsertionSort(array);
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");


            foreach (int x in array)
            {
                Console.WriteLine(x);
            }


            Console.ReadKey();
        }

        static List<int> SelectionSort(List<int> numbers)
        {
            int i;
            int j;
            int min;
            int temp;
            for (i = 0; i < numbers.Count; i++)
            {
                min = i;
                for (j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[j] < numbers[min])
                    {
                        min = j;
                    }
                }
                temp = numbers[i];
                numbers[i] = numbers[min];
                numbers[min] = temp;
            }
            return numbers;
        }

        static int[] InsertionSort(int[] array)
        {
            int index, i, j;
            for (i = 1; i < array.Length; i++)
            {
                index = array[i];
                j = i;
                while ((j > 0) && (array[j - 1] > index))
                {
                    array[j] = array[j - 1];
                    j = j - 1;
                }
                array[j] = index;
            }
            return array;
        }

    }
}
