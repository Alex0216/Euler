using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;



namespace Problem29
{
    class DistinctPower
    {
        static int SIZE = 98;
        static int LOW_BOUND = 2;
        static int HIGH_BOUND = 100;
        static bool[,] GRID = new bool[SIZE, SIZE];

        static void Main(string[] args)
        {
            //bruteforce 
            HashSet<BigInteger> set = new HashSet<BigInteger>();
            for(int a = LOW_BOUND; a <= HIGH_BOUND; ++a)
            {
                for (int b = LOW_BOUND; b <= HIGH_BOUND; ++b)
                    set.Add(BigInteger.Pow(a, b));
            }

            Console.WriteLine(set.Count);

        }


    }
}
