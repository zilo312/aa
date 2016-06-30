using System;
using System.Collections.Generic;
using System.Text;

namespace Wrox.ProCSharp.Arrays
{
    class Program
    {
        static void SimpleArrays()
        {
            int[] myArray = new int[] { 4, 7, 11, 2 };
            int v1 = myArray[0];  // read first element
            int v2 = myArray[1];  // read second element
            myArray[3] = 44;     // change fourth element

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            foreach (int val in myArray)
            {
                Console.WriteLine(val);
            }


        }

        static void TwoDimArraysA()
        {
            int[,] twodim = new int[3, 3];
            twodim[0, 0] = 1;
            twodim[0, 1] = 2;
            twodim[0, 2] = 3;
            twodim[1, 0] = 4;
            twodim[1, 1] = 5;
            twodim[1, 2] = 6;
            twodim[2, 0] = 7;
            twodim[2, 1] = 8;
            twodim[2, 2] = 9;

        }


        static void TwoDimArraysB()
        {
            int[,] twodim = { { 1, 2, 3}, 
                              { 4, 5, 6 }, 
                              { 7, 8, 9 } };

            Console.WriteLine("rank of twodim: {0}", twodim.Rank);

        }


        static void ThreeDim()
        {
            int[, ,] threedim = { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } }, { { 9, 10 }, { 11, 12 } } };
            Console.WriteLine(threedim[0, 1, 1]);
        }

        static void Jagged()
        {
            int[][] jagged = new int[3][];
            jagged[0] = new int[2] { 1, 2 };
            jagged[1] = new int[6] { 3, 4, 5, 6, 7, 8 };
            jagged[2] = new int[3] { 9, 10, 11 };

            for (int row = 0; row < jagged.Length; row++)
            {
                for (int element = 0; element < jagged[row].Length; element++)
                {
                    Console.WriteLine("row: {0}, element: {1}, value: {2}",
                        row, element, jagged[row][element]);   
                }

            }

            foreach (int[] j in jagged)
            {
                foreach (int i in j)
                {
                    Console.WriteLine(i);
                }
            }

        }

        static void CreateUsingArrayClass()
        {
            Array intArray = Array.CreateInstance(typeof(int), 5);

            Array intArray1 = Array.CreateInstance(typeof(int), 5);
            for (int i = 0; i < 5; i++)
            {
               intArray1.SetValue(33, i);
            }

            for (int i = 0; i < 5; i++)
            {
               Console.WriteLine(intArray1.GetValue(i));
            }


            int[] ia = (int[])intArray;

            int[] lengths = { 2, 3 };
            int[] lowerBounds = { 1, 10 };
            Array racers = Array.CreateInstance(typeof(Person), lengths, lowerBounds);
            racers.SetValue(new Person("Alain", "Prost"), 1, 10);
            racers.SetValue(new Person("Emerson", "Fittipaldi"), 1, 11);
            racers.SetValue(new Person("Ayrton", "Senna"), 1, 12);
            racers.SetValue(new Person("Ralf", "Schumacher"), 2, 10);
            racers.SetValue(new Person("Fernando", "Alonso"), 2, 11);
            racers.SetValue(new Person("Jenson", "Button"), 2, 12);


            Person[,] p2 = (Person[,])racers;

            p2[1, 10] = new Person("x", "y");
            p2[1, 12] = new Person("a", "b");
            p2[3, 10] = new Person("b", "c");
            p2[3, 13] = new Person("x", "y");
            foreach (Person p in racers)
            {
                Console.WriteLine(p);
            }

          //   int[] k = new int[2];

        }




        static void Main(string[] args)
        {
            // SortingDemo.SortStringArray();
            //SortingDemo.SortPersonArray();

            CopyDemo.CopyPersonArray();
            CreateUsingArrayClass();
            // Jagged();
            try
            {

                Person[] myPersons = { new Person("Ayrton", "Senna"),
                       new Person("Michael", "Schumacher") };

                myPersons[3] = new Person();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }
    }
}
