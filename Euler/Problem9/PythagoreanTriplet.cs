using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9
{
    class PythagoreanTriplet
    {
        static void Main(string[] args)
        {
            for(int i = 5; i < 1000; ++i)
            {
                int prod = FindTriangle(i, 1000);
                if (prod != 0)
                    Console.WriteLine(prod);
            }
        }


        public static List<Tuple<int, int>> GetFactorPairs(int number)
        {
            List<Tuple<int, int>> pairs = new List<Tuple<int, int>>();
            for(int i = 1; i*i < number; ++i)
            {
                if(number % i == 0)
                    pairs.Add(new Tuple<int, int>(i, number/i));
            }
            return pairs;
        }


        public static int FindTriangle(int b, int goalSum)
        {
            int init = b;
            bool even = (b % 2 == 0) ? true : false;

            if (!even) 
                b *= 2;
            
            foreach(var pair in GetFactorPairs(b/2))
            {
                int a = (int)(Math.Pow(pair.Item2, 2) - Math.Pow(pair.Item1, 2));
                int c = (int)(Math.Pow(pair.Item2, 2) + Math.Pow(pair.Item1, 2));          

                int sum = a + b + c;

                if (!even)
                    sum /= 2;
                
                if(sum == goalSum)
                {
                    int product = a * b * c;
                    if (!even)
                        product /= 8;
                    return product;
                }
            }

            return 0;
        }

    }
}
