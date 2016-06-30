using System;
using System.Collections.Generic;
using System.Text;

namespace Wrox.ProCSharp.Arrays
{
    public static class CopyDemo
    {
        public static void CopyIntArray()
        {
            int[] one = { 3, 4 };
            int[] clone = (int[])one.Clone();
            clone[0] = 33;
            Console.WriteLine(one[0]);



        }

        public static void CopyPersonArray()
        {
            Person[] personArr1 = {
                        new Person("John", "Lennon"), 
                        new Person("Paul", "McCartney")
                      };
            Person[] personArr2 = (Person[])personArr1.Clone();

            personArr2[0].LastName = "test";
            Console.WriteLine(personArr1[0].LastName);

            Person[] personArr3 = new Person[2];
            personArr1.CopyTo(personArr3, 0);
            personArr3[0].LastName = "abc";
            Console.WriteLine(personArr1[0].LastName);


        }
    }
}
