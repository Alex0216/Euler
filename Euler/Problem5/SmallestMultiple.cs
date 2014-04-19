using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Problem5
{
    class SmallestMultiple
    {
        const int MAX = 20;
        static void Main(string[] args)
        {
            
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int number = MAX;
            while(true)
            {
                if(IsDivisible(number))
                {
                    timer.Stop();
                    Console.WriteLine(number + " time : " + timer.ElapsedMilliseconds);
                    return;
                }
                number += MAX;
            }
            
/*
            HashSet<int> factors = new HashSet<int>();

            ulong result = 1;
            for (int i = 1; i <= MAX; ++i)
                result *= (ulong)i;

            for (int i = MAX; i > 0; i--)
            {
                if (factors.Contains(i))
                    continue;

                int currentNumber = i;
                foreach (int fac in GetFactors(i))
                {
                    result /= (ulong)fac;
                    factors.Add(fac);
                }


            }

            Console.WriteLine(result);
 */
        }

        public static List<int> GetFactors(int number)
        {
            List<int> factors = new List<int>();

            for(int i = 1; i < number; ++i)
            {
                if (number % i == 0)
                    factors.Add(i);
            }

            return factors;
        }

        public static bool IsDivisible(int number)
        {
            
            for (int i = 2; i <= MAX; ++i)
                if (number % i != 0)
                    return false;

            return true;

        }
    }
}
