using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Wrox.ProCSharp.Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticDemo<string>.x = 4;
            StaticDemo<int>.x = 5;
            Console.WriteLine(StaticDemo<string>.x);

            LinkedList list1 = new LinkedList();
            list1.AddLast(1);
            list1.AddLast(2);
            // list1.AddLast("3");

            foreach (int i in list1)
            {
                Console.WriteLine(i);
            }

            LinkedList<int> list2 = new LinkedList<int>();
            list2.AddLast(3);
            list2.AddLast(5);
            list2.AddLast(7);

            foreach (int i in list2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
