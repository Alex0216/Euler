using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

using Problem3;

namespace Problem7
{
    class NthPrime
    {
        const int N = 10001;
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            long prime = LargestPrimeFactor.GetNextPrime().Skip(N-1).First();
            timer.Stop();
            Console.WriteLine(N + "th prime is: " + prime + " time : " + timer.ElapsedMilliseconds);
        }
    }
}
