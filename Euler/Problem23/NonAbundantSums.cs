using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

using Problem21;

namespace Problem23
{
    class NonAbundantSums
    {
        const int LIMIT = 28123;
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            List<bool> integer = Enumerable.Repeat(false, LIMIT).ToList();
            List<int> abundant = new List<int>();

            //find all abundant number
            for (int i = 1; i < LIMIT; ++i )
                if (AmicableNumber.GetFactorSum(i) > i)
                    abundant.Add(i);

            //compute all the possible sum of two abundant number and remove from the list
            for (int i = 0; i < abundant.Count; ++i)
                for (int j = i; j < abundant.Count; ++j)
                {
                    int absum = abundant[i] + abundant[j];
                    if(absum < LIMIT)
                        integer[absum] = true;
                }
                    

            int sum = 0;
            for (int i = 0; i < LIMIT; ++i)
                if (!integer[i])
                    sum += i;

            timer.Stop();
            Console.WriteLine(sum + " time: " + timer.ElapsedMilliseconds);
        }
    }
}
