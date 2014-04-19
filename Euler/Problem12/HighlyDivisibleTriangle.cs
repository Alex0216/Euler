using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Problem12
{
    class HighlyDivisibleTriangle
    {
        static void Main(string[] args)
        {
            
            Stopwatch timer = new Stopwatch();
            timer.Start();
            long triangleNumber = NextTriangleNumber().AsParallel().SkipWhile(num => GetNbDivisor(num) < 500).First();
            timer.Stop();

            Console.WriteLine(triangleNumber + " time: " + timer.ElapsedMilliseconds);
        }

        public static IEnumerable<long> NextTriangleNumber()
        {
            long triangle = 1;
            long add = 2;
            while(true)
            {
                yield return triangle;
                triangle += add;
                add++;
            }
        }

        public static long GetNbDivisor(long number)
        {
            //special case for 1
            if (number == 1)
                return 1;

            long nbDivisor = 0;
            for (int i = 1; i*i <= number; ++i)
                if (number % i == 0)
                    nbDivisor++;
            return nbDivisor*2;
        }
    }
}
