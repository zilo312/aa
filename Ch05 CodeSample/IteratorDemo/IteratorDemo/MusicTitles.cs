using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Wrox.ProCSharp.Arrays
{
    public class MusicTitles
    {
        string[] names = {"Tubular Bells", "Hergest Ridge", "Ommadawn", "Platinum" };

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < 4; i++)
            {
                yield return names[i];
            }
        }

        public IEnumerable Reverse()
        {
            for (int i = 3; i >= 0; i--)
            {
                yield return names[i];
            }
        }

        public IEnumerable Subset(int index, int length)
        {
            for (int i = index; i < index + length; i++)
            {
                yield return names[i];
            }
        }
    }
}
