using System;

namespace Wrox.ProCSharp.Generics
{
    public interface IDocumentManager<TDocument>
     where TDocument : IDocument
    {
        void AddDocument(TDocument doc);
        TDocument GetDocument();
        bool IsDocumentAvailable { get; }
    }
}
