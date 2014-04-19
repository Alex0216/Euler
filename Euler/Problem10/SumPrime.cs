using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

using Problem3;

namespace Problem10
{
    class SumPrime
    {
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            long sum = LargestPrimeFactor.GetNextPrime().TakeWhile(item => item < 2000000).Aggregate((a, b) => a + b);
            timer.Stop();
            Console.WriteLine(sum + " time : " + timer.ElapsedMilliseconds);
        }
    }
}
