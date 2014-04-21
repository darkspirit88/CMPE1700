using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMPE1700SJoICA11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int[] array = new int[1000];
            int key = generator.Next(1001);

            for (int index = 0; index <1000; index++)
            {
                array[index] = index + 1;

            }

            Console.WriteLine("Guess a number between 1 and 1000");

            binarySearch(array, key);
            

            Console.ReadKey();
        }
        static int binarySearch(int[] array,int key)
        {
           int low = 0;
           int high = array.Length;
           int middle;
           int count = 1;
           string answer;


           while (low <= high)
           {
               do
               {
                   middle = (low + high) / 2;
                   Console.Write("Was your guess {0}?", middle);
                   answer = Console.ReadLine();

                   if (answer == "Lo" || answer == "Low" || answer == "L")
                   {
                       high = middle - 1;
                       count++;
                   }
                   else if (answer == "Hi" || answer == "High" || answer == "H")
                   {
                       low = middle + 1;
                       count++;
                   }
                   else if (answer == "Y" || answer == "Yes")
                   {
                       Console.Write("I got it in {0} guesses!", count);
                       return middle;
                   }
                   else
                   {
                       Console.WriteLine("I didn't understand that. Please answer specifically Hi, Lo or Yes.");
                   }
               } while (answer == "Yes" || answer == "Y");
               
           }

            return -1;

        }
    }
}
