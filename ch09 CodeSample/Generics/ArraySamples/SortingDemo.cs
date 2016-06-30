using System;
using System.Collections.Generic;
using System.Text;

namespace Wrox.ProCSharp.Arrays
{
    public static class SortingDemo
    {
        public static void SortStringArray()
        {
            string[] names = { "Christina Aguillera", "Shakira", "Beyonce", "Gwen Stefani" };
            Array.Sort(names);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        }

        public static void SortPersonArray()
        {
            Person[] persons = {
                new Person("Emerson", "Fittipaldi"),
                new Person("Niki", "Lauda"),
                new Person("Ayrton", "Senna"),
                new Person("Michael", "Schumacher")
            };

            Array.Sort(persons);
            foreach (Person p in persons)
            {
                Console.WriteLine(p);
                
            }
        }

        public static void SortPersonArrayUsingComparer()
        {
            Person[] persons = {
                new Person("Emerson", "Fittipaldi"),
                new Person("Niki", "Lauda"),
                new Person("Ayrton", "Senna"),
                new Person("Michael", "Schumacher")
            };

            Array.Sort(persons, new PersonComparer(PersonComparer.PersonCompareType.FirstName));
            foreach (Person p in persons)
            {
                Console.WriteLine(p);

            }
        }

        public static void SortUsingDelegate()
        {
            Person[] persons = {
                new Person("Emerson", "Fittipaldi"),
                new Person("Niki", "Lauda"),
                new Person("Ayrton", "Senna"),
                new Person("Michael", "Schumacher")
            };
            Array.Sort(persons, 
                delegate(Person p1, Person p2)
                {
                    return p1.FirstName.CompareTo(p2.FirstName);
                });
        }
    }
}
