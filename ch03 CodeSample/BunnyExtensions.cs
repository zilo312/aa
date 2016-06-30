using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter3.Extensions
{
    public static class BunnyExtensions
    {
        public static int Do2Birthday(this Bunny bunny)
        {
            return bunny.Age += 2;
        }
    }
}
