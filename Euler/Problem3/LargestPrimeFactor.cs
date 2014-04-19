using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Problem3
{
    public class LargestPrimeFactor
    {
        const long NUMBER = 600851475143;
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            long largestPrimeFactor = FindLargestPrimeFactor(NUMBER);
            timer.Stop();
            Console.WriteLine( largestPrimeFactor + " time: " + timer.ElapsedMilliseconds);
        }

        /*
         * Find the largest prime factor of a given number
         */
        public static long FindLargestPrimeFactor(long number)
        {

            if (IsPrime(number))
                return number;

            foreach(long prime in GetNextPrime())
            {
                if(number % prime == 0) //this prime is a factor;
                {
                    return Math.Max(prime, FindLargestPrimeFactor(number / prime));
                }
            }

            //Should never go there...
            return 0;
        }

        /*
         * Prime number generator
         */
        public static IEnumerable<long> GetNextPrime()
        {   
            yield return 2;
            yield return 3;

            long k = 1;
            while(true)
            {
                long prime = 6 * k - 1;

                for (int i = 0; i < 3; ++i, ++prime)
                    if (IsPrime(prime))
                        yield return prime;

                    k++;
            }
        }

        /*
         * Simple function that check if a number is prime
         */
        public static bool IsPrime(long number)
        {
            if (number <= 1)
                return false;

            if (number == 2)
                return true;
            if (number % 2 == 0 || number % 3 == 0)
                return false;

            for (long divisor = 5; divisor * divisor <= number; divisor += 6)
                if (number % divisor == 0 || number % (divisor + 2) == 0)
                    return false;
            return true;
        }
    }
}
