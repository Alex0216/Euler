using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Problem3;

namespace Problem27
{
    class QuadraticPrime
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NbPrimeFound(-79, 1601));

            List<long> primes = LargestPrimeFactor.GetNextPrime().TakeWhile(a => a < 1000).ToList();
            int max = 0;
            long maxA = 0;
            long maxB = 0;

            for(long a = -999; a < 1000; ++a)
            {
                foreach(var b in primes)
                {
                    int tmp;
                    if((tmp = NbPrimeFound(a,b)) > max)
                    {
                        max = tmp;
                        maxA = a;
                        maxB = b;
                    }
                }
            }

            Console.WriteLine("a: " + maxA + " b: " + maxB + "product: " + maxA * maxB);
        }

        public static int NbPrimeFound(long a, long b)
        {
            long n = 1;
            while (LargestPrimeFactor.IsPrime((long)Math.Pow(n, 2) + a * n + b))
                n++;

            return (int)n - 1;
        }

        
    }
}
