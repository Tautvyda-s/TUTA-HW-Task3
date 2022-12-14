using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String Array Task - printing all words of string Array

            String[] stringArray = new String[5] { "First ", "Second", "Third", "Fourth", "Fifth" };
            Console.WriteLine("Printing all words in stringArray: ");
            Console.WriteLine(" ");

            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }

            //Int Array task - printing all values of int Array backwards

            int[] intArray = new int[20] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            Array.Reverse(intArray); //reverse intArray values backwards

            Console.WriteLine(" ");
            Console.WriteLine("Printing intArray numbers backwards: ");
            Console.WriteLine("");

            foreach (int i in intArray)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(" ");
        }
    }
}
