using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    internal class ParamArray
    {
        public int Addelements(params int[] arr)
        {
            int sum = 0;

            foreach (int i in arr)
                sum += i;
            return sum;

        }
        
    }

    class TestClass
    {
        static void Main(string[] args)
        {
            ParamArray app = new ParamArray();
            int sum = app.Addelements(1,2,3,4,5);

            Console.WriteLine("The sum is: {0}",sum);
            Console.ReadLine();


        }
    }
}
