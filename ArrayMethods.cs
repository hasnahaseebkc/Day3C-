using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ArrayMethods
    {
        static void Main(string[] args)
        {
            int[] list = {5, 8, 3, 1, 6};
            int[] temp = list;
            Console.Write("Original Array: ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();  //next line

            //reverse the array
            Array.Reverse(temp);
            Console.Write("Reversed Array: ");

            foreach(int i in temp)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine() ;

            //sort the array
            Array.Sort(list);
            Console.Write("Sorted Array: ");

            foreach (int i in list)
                Console.Write(i + " ");
            Console.WriteLine();

            Console.ReadLine();


        }
    }
}
