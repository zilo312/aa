using System;
using System.Xml.Linq;

namespace Wrox.ProCSharp.SqlServer
{
   class Program
   {
      static void Main()
      {
         ProCSharpDataContext db = new ProCSharpDataContext();

        
         foreach (Exam item in db.Exams)
         {
            XElement exam = item.Info.Element("Exam");
            Console.WriteLine("Exam: {0}", exam.Attribute("Number").Value);
            Console.WriteLine("Title: {0}", exam.Element("Title").Value);
            Console.Write("Course(s): ");
            foreach (var course in exam.Elements("Course"))
            {
               Console.Write("{0} ", course.Value);
            }
            Console.WriteLine();
         }
      }
   }
}
