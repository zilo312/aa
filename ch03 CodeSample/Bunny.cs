using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chapter3.Extensions;

namespace Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            Bunny bunny1 = new Bunny();
            bunny1.Name = "Fred";
            bunny1.Age = 25;
            bunny1.IsRabbit = true;

            if (bunny1.IsRabbit)
            {
                Console.WriteLine("The rabbit's name is " + bunny1.Name);
                Console.WriteLine("The rabbit's age is " + bunny1.Age.ToString());
            }

            var bunny2 = new { Name = "George", Age = 30, IsRabbit = bunny1.IsRabbit };
            if (bunny2.IsRabbit)
            {
                Console.WriteLine("The rabbit's name is " + bunny2.Name);
                Console.WriteLine("The rabbit's age is " + bunny2.Age.ToString());
            }

            Console.WriteLine("Bunny1 is type " + bunny1.GetType().ToString());
            Console.WriteLine("Bunny2 is type " + bunny2.GetType().ToString());

            bunny1.DoBirthday();
            Console.WriteLine("Bunny1 is now " + bunny1.Age.ToString());
            bunny1.Do2Birthday();
            Console.WriteLine("Bunny1 is now " + bunny1.Age.ToString());
        }
    }

    public class Bunny
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsRabbit { get; set; }

        public void DoBirthday()
        {
            this.Age += 1;
        }

    }
}
