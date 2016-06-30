using System;
using System.Collections;

namespace Wrox.ProCSharp.Arrays
{
    public class Hello
    {
        public IEnumerator GetEnumerator()
        {
            yield return "Hello";
            yield return "World";
        }
    }

}
