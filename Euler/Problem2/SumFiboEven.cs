using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Problem2
{
    class SumFiboEven
    {
        const int LIMIT = 4000000;
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();

            timer.Start();
            int a = 1; 
            int b = 2;
            int sum = 2;
            int c = 0;
            while(c < LIMIT)
            {
                c = a + b;
                a = b;
                b = c;
                if (b % 2 == 0)
                    sum += b;
            }
            timer.Stop();
            Console.WriteLine(sum + " time: " + timer.ElapsedMilliseconds);
        }
    }
}
