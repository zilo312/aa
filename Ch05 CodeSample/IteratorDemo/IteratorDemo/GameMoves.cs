using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Wrox.ProCSharp.Arrays
{
    public class GameMoves
    {
        private IEnumerator cross;
        private IEnumerator circle;

        public GameMoves()
        {
            cross = Cross();
            circle = Circle();
        }

        private int move = 0;

        public IEnumerator Cross()
        {
            while (true)
            {
                Console.WriteLine("Cross, move {0}", move);
                move++;
                if (move > 8)
                    yield break;
                yield return circle; 
            }
        }

        public IEnumerator Circle()
        {
            while (true)
            {
                Console.WriteLine("Circle, move {0}", move);
                move++;
                if (move > 8)
                    yield break;
                yield return cross; 
            }
        }
    }
}
