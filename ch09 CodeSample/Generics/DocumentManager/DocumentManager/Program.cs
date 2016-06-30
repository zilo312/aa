using System;
using System.Collections.Generic;
using System.Text;

namespace Wrox.ProCSharp.Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentManager<Document> dm = new DocumentManager<Document>();
            dm.AddDocument(new Document("Title A", "Sample A"));
            dm.AddDocument(new Document("Title B", "Sample B"));

            dm.DisplayAllDocuments();

            if (dm.IsDocumentAvailable)
            {
                Document d = dm.GetDocument();
                Console.WriteLine(d.Content);
            }

            dm.DisplayAllDocuments();
            
        }
    }
}
