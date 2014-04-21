using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Problem14
{
    class LonguestCollatz
    {
        static Dictionary<uint, uint> CollatzLength = new Dictionary<uint, uint>();

        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            uint max = 0;
            uint maxLength = 0;

            for(uint i = 1; i < 1000000; ++i)
            {
                uint length = GetCollatzLength(i);

                if(length > maxLength)
                {
                    max = i;
                    maxLength = length;
                }
            }

            timer.Stop();
            Console.WriteLine(max + " time: " + timer.ElapsedMilliseconds);
        }

        public static uint GetCollatzLength(uint number)
        {
            Stack<uint> sequence = new Stack<uint>();

            uint length = 0;

            foreach(var col in CollatzSequence(number))
            {

                if (CollatzLength.TryGetValue(col, out length))
                    break;

                sequence.Push(col);
            }

            

            foreach(var col in sequence)
                CollatzLength[col] = ++length;

            return length ;
        }

        public static IEnumerable<uint> CollatzSequence(uint number)
        {
            uint collatz = number;
            while(collatz != 1)
            {
                yield return collatz;
                if(collatz % 2 == 0)
                    collatz /= 2;
                else
                    collatz = 3 * collatz + 1;
            }

            yield return collatz;
        }
    }
}
