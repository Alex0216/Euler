using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

using Problem3;

namespace Problem26
{
    class ReciprocalCycle
    {
        static void Main(string[] args)
        {
            
            long d = 0;
            int phi = 1;
            List<long> primes = LargestPrimeFactor.GetNextPrime().TakeWhile(a => a < 1000).ToList();

            Console.WriteLine(IsPrimitiveRoot10(7, 6, ref primes));
            Console.WriteLine(IsPrimitiveRoot10(137, 136, ref primes));
            Console.WriteLine(IsPrimitiveRoot10(997, 996, ref primes));

            foreach(var prime in primes)
            {
                if (IsPrimitiveRoot10(prime, (int)(prime-1),ref primes))
                    d = prime;

                phi ++;
            }

            Console.WriteLine(d);
        }

        public static bool IsPrimitiveRoot10(long number, int phi, ref List<long> primes)
        {
            foreach (var p in NextPrimeFactor(phi))
            {
                int power = (int)(phi / p);
                if (BigInteger.Pow(10, power) % number == 1)
                    return false;
            }
                

            return true;

        }

        public static IEnumerable<long> NextPrimeFactor(long number)
        {
            foreach (var prime in LargestPrimeFactor.GetNextPrime().TakeWhile(a => a <= number / 2))
                if (number % prime == 0)
                    yield return prime;
        }
    }
}
