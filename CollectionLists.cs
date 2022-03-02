using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CollectionLists
    {

        static void Main(string[] args)
        {


            //ArrayList Collection
            var data = new ArrayList();
            data.Add("Demo");       //add element
            data.Add(1);
            data.Add(5);
            data.Add(26);
            data.Add(56.4);
            data.Add(32);
            data.Remove(5);         // remove element
            foreach (object obj in data)
            {
                Console.WriteLine(obj);
            }


            var value = new List<string>();     //list collection
            value.Add("Cricket");
            value.Add("Football");
            value.Add("Volleyball");
            value.Add("Hockey");
            value.Add("Basketball");
            value.Add("Tennis");
            value.Remove("Football");
            value.Remove("Tennis");
            value.Insert(3, "Badminton");
            foreach( string st in value)
            {
                Console.WriteLine(st);
            }


            var val = new SortedList<string, int>();
            val.Add("java", 3);
            val.Add("javascript", 4);
            val.Add("c-sharp", 5);
            val.Add("dotnet", 25);

            foreach( object ob in val)
            {
                Console.WriteLine(ob);
            }


            var link = new LinkedList<int>();
            link.AddLast(13);
            link.AddLast(33);
            link.AddLast(23);
            link.AddLast(51);
            link.AddLast(60);
            link.AddFirst(4);
            link.AddFirst(6);
            LinkedListNode<int> node = link.Find(51);
            link.AddBefore(node, 40);
            foreach( int i in link)
                Console.WriteLine(i);


            Console.ReadLine();
        }
    }
}
