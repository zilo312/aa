using System;
using System.Collections.Generic;
using System.Text;
using Interop.SearchAPI;

namespace AQSSample
{
   class Program
   {
      static void Main(string[] args)
      {
         CSearchManager manager = new CSearchManager();
         CSearchCatalogManager catalogManager = manager.GetCatalog("SystemIndex");
         CSearchQueryHelper queryHelper = catalogManager.GetQueryHelper();
         string sql = queryHelper.GenerateSQLFromUserQuery("text kind:music");

         Console.WriteLine(sql);
         
      }
   }
}
