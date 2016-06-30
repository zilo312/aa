using System;
using System.Collections.Generic;
using System.Text;

namespace Wrox.ProCSharp.Collections
{

   class Program
   {
      static void Main()
      {
         System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
         Dictionary<EmployeeId, Employee> employees =
               new Dictionary<EmployeeId, Employee>(31);

         EmployeeId idJeff = new EmployeeId("C7102");
         Employee jeff = new Employee(idJeff, "Jeff Gordon",
               5164580.00m);
         employees.Add(idJeff, jeff);
         Console.WriteLine(jeff);

         EmployeeId idTony = new EmployeeId("C7105");
         Employee tony = new Employee(idTony, "Tony Stewart", 4814200.00m);
         employees.Add(idTony, tony);
         Console.WriteLine(tony);

         EmployeeId idDenny = new EmployeeId("C8011");
         Employee denny = new Employee(idDenny, "Denny Hamlin", 3718710.00m);
         employees.Add(idDenny, denny);
         Console.WriteLine(denny);

         EmployeeId idCarl = new EmployeeId("F7908");
         Employee carl = new Employee(idCarl, "Carl Edwards", 3285710.00m);
         employees[idCarl] = carl;
         Console.WriteLine(carl);

         EmployeeId idMatt = new EmployeeId("F7203");
         Employee matt = new Employee(idMatt, "Matt Kenseth", 4520330.00m);
         employees[idMatt] = matt;
         Console.WriteLine(matt);


         while (true)
         {
            try
            {
               Console.Write("Enter employee id (X to exit)> ");
               string userInput = Console.ReadLine();
               userInput = userInput.ToUpper();
               if (userInput == "X") break;
               EmployeeId id = new EmployeeId(userInput);

               Employee employee;
               if (!employees.TryGetValue(id, out employee))
               {
                  Console.WriteLine("Employee with id {0} does not exist",
                     id);
               }
               else
               {
                  Console.WriteLine(employee);
               }
            }
            catch (Exception ex)
            {
               Console.WriteLine("Error: " + ex.Message);
            }
         }

      }

   }
}
