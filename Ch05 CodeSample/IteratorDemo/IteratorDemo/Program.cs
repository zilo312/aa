using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Wrox.ProCSharp.Arrays
{
    class Program
    {
        static void Main()
        {
            GameMoves g = new GameMoves();
            IEnumerator enumerator = g.Cross();
            while (enumerator.MoveNext())
            {
                enumerator = (IEnumerator)enumerator.Current;
            }

            MusicTitles titles = new MusicTitles();
            Console.WriteLine("Using GetEnumerator()");
            foreach (string title in titles)
            {
                Console.WriteLine(title);
            }
            Console.WriteLine();
            Console.WriteLine("reverse");
            foreach (string title in titles.Reverse())
            {
                Console.WriteLine(title);
            }
            Console.WriteLine();
            Console.WriteLine("subset");
            foreach (string title in titles.Subset(2, 2))
            {
                Console.WriteLine(title);
            }




           
        }
    }
}
