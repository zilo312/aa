using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
   class ParameterPassing
   {
      public void ChangeVal(ref int x)
      {
         x = 3;
      }

      public void ChangeVal(int x)
      {
      }
      public void GetVal(out int a)
      {
         a = 3;
      }
   }
}
