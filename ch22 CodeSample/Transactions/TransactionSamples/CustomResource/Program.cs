using System;
using System.Transactions;

namespace Wrox.ProCSharp.Transactions
{
    class Program
    {
         static void Main()
        {
            UseTransactional();
           
  
        }

        private static void UseTransactional()
        {
            Transactional<int> intVal = new Transactional<int>(1);
            Transactional<Student> student1 = new Transactional<Student>(new Student());
            student1.Value.FirstName = "Andrew";
            student1.Value.LastName = "Wilson";

            Console.WriteLine("before the transaction, value: {0}", intVal.Value);
            Console.WriteLine("before the transaction, student: {0}", student1.Value);

            using (TransactionScope scope = new TransactionScope())
            {
                intVal.Value = 2;
                Console.WriteLine("inside transaction, value: {0}", intVal.Value);

                student1.Value.FirstName = "Ten";
                student1.Value.LastName = "Sixty-Nine";

                if (!Utilities.AbortTx())
                    scope.Complete();
            }
            Console.WriteLine("outside of transaction, value: {0}", intVal.Value);
            Console.WriteLine("outside of transaction, student: {0}", student1.Value);

        }

        private static void IntDemo1()
        {
            Transactional<int> myint = new Transactional<int>(1);

            Transactional<Student> myStudent = new Transactional<Student>();

            myStudent.Value.FirstName = "Tom";
            myStudent.Value.LastName = "Turbo";

            myint.Value = 2;
            using (TransactionScope scope = new TransactionScope())
            {
                Transactional<string> mystring = new Transactional<string>("one");

                Console.WriteLine(myint.Value);
                myint.Value = 5;
                Console.WriteLine(myint.Value);

                using (TransactionScope scope2 = new TransactionScope(TransactionScopeOption.RequiresNew))
                {
                    Console.WriteLine(mystring);
                    Console.WriteLine(myint.Value);
                    scope2.Complete();
                }

                // scope.Complete();
            }
            Console.WriteLine(myint.Value);
        }
    }
}
