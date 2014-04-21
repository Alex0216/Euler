using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Problem25
{
    class Program
    {
        static void Main(string[] args)
        {
            int rank = 1;
            foreach (var fibo in NextFibo().TakeWhile(f => f < BigInteger.Pow(10, 999)))
                rank++;

            Console.WriteLine(rank);
        }


        public static IEnumerable<BigInteger> NextFibo()
        {
            yield return 1;
            yield return 1;
            yield return 2;

            BigInteger previous = 2;
            BigInteger next = previous + 1;
            while(true)
            {
                yield return next;

                BigInteger tmp = next;
                next += previous;
                previous = tmp;
            }

        }
    }
}
