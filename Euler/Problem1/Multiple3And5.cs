using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace Problem1
{
    class Multiple3And5
    {
        static void Main(string[] args)
        {
            int max = 1000;
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int sum = 0;
            for (int i = 0; i < max; ++i)
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            timer.Stop();
            Console.WriteLine(sum + " time: " + timer.ElapsedMilliseconds);

            //With LINQ
            timer.Restart();
            long totalSum = Enumerable.Range(1, max-1).Where(i => (i % 3 == 0 || i % 5 == 0)).Select(i => i).Sum();
            timer.Stop();
            Console.WriteLine(totalSum+ " time: " + timer.ElapsedMilliseconds);
        }
    }
}
