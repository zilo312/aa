using System;
using System.Collections.Generic;
using System.Text;

namespace Wrox.ProCSharp.Generics
{
    public class Document : IDocument
    {
        public Document()
        {

        }

        public Document(string title, string content)
        {
            this.Title = title;
            this.Content = content;
        }


        public string Title {get; set;}


        public string Content {get; set;}

    }
}
