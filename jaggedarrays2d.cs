using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class jaggedarrays2d
    {
        static void Main(string[] args)
        {

            //create a jagged array
            int[][] jaggedArray =
            {
                new int[] { 1, 3, 5 },
                new int[] {2, 4 }
            };


            //print elements of jagged array
            Console.WriteLine("jaggedArray[1][0]: " + jaggedArray[1][0]);   //2
            Console.WriteLine("jaggedArray[1][1]: " + jaggedArray[1][1]);   //4
            Console.WriteLine("jaggedArray[1][0]: " + jaggedArray[0][2]);   //5


            //declare and initialise jagged array with 2D array

            int[][,] jaggedArray2d = new int[3][,]
            {
                new int[,] { { 1, 8 }, { 6, 7 } },
                new int[,] { { 0, 3 }, { 5, 6 },{ 9, 10 } },
                new int[,] { { 11, 23 }, {100,88 },{0,10 } }

            };

            Console.WriteLine(jaggedArray2d[0][0, 1]);
            Console.WriteLine(jaggedArray2d[1][2, 1]);
            Console.WriteLine(jaggedArray2d[2][1, 0]);

            Console.ReadLine();
        }
    }
}
