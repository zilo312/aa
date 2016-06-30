using System;
using System.Collections.Generic;
using System.Text;

namespace Wrox.ProCSharp.Generics
{
    public abstract class Calc<T>
    {
        public abstract T Add(T x, T y);
        public abstract T Sub(T x, T y);
    }

    public class SimpleCalc : Calc<int>
    {
        public override int Add(int x, int y)
        {
            return x + y;   
        }

        public override int Sub(int x, int y)
        {
            return x - y;
        }
    }
}
