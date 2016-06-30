using System;
using System.IO;

namespace AdminRequired
{
   class Program
   {
      static void Main()
      {
         // WriteToProgramFiles();
         ReadFromProgramFiles();
         Console.WriteLine("Press return to exit...");
         Console.ReadLine();


        // string f = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
         
        //// Array ar = Enum.GetValues(typeof(Environment.SpecialFolder));
        // foreach (Environment.SpecialFolder folder in Enum.GetValues(typeof(Environment.SpecialFolder)))
        // {
        //          Console.Write(folder + ": ");
        //          Console.WriteLine(Environment.GetFolderPath(folder));
        //          Console.WriteLine("Name: {0}", Enum.GetName(typeof(Environment.SpecialFolder), folder));
        //          Console.WriteLine();
      		 
        // }
      }

      private static void WriteToProgramFiles()
      {
         string programFiles = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
         string appDir = Path.Combine(programFiles, "WroxSampleApp");
         if (!Directory.Exists(appDir))
            Directory.CreateDirectory(appDir);

         string demoFile = Path.Combine(appDir, "samplefile.txt");
         File.WriteAllText(demoFile, "test content");
      }

      private static void ReadFromProgramFiles()
      {
         string programFiles = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
         string appDir = Path.Combine(programFiles, "WroxSampleApp");
         if (!Directory.Exists(appDir))
            Directory.CreateDirectory(appDir);

         string demoFile = Path.Combine(appDir, "samplefile.txt");
         Console.WriteLine(File.ReadAllText(demoFile));

      }
   }
}
