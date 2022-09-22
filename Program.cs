using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_9_Assi.Q5_Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Q-5 Find duplicate numbers in an array of integers

            int[] array = { 1, 2, 5, 2, 3, 3, 4, 5, 2 };
            int[] count = new int[9];

            foreach (int i in array)
            {
                count[i]++;
            }

            foreach (int c in count)
            {
                int iCount = count[c];
                if (iCount > 0)
                {
                    Console.WriteLine(c + " occurs " + iCount + " times");
                }
            }




            //Q6 Remove a given element from an array.

            int[] numbers = new int[5] { 11, 2, 23, 25, 14 };

            Array.Clear(numbers ,1,2);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();









        }
    }
}
