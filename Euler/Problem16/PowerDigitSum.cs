using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Problem16
{
    class PowerDigitSum
    {
        static void Main(string[] args)
        {
            int sum = Power(2, 1000).Sum();
            
            Console.WriteLine(sum);
        }

        public static List<int> Power(int n, int pow)
        {
            int tmp = n;
            List<int> bigInt = new List<int>();
            while(tmp != 0)
            {
                bigInt.Insert(0, tmp % 10);
                tmp /= 10;
            }

            for (int i = 1; i < pow; ++i )
            {
                //Multiply by the number
                for (int j = 0; j < bigInt.Count; ++j)
                    bigInt[j] *= n;

                //Go through the array to sum the carry
                for (int j = bigInt.Count-1; j > 0 ; --j)
                {
                    if (bigInt[j] < 10)
                        continue;

                    int number = bigInt[j];
                    bigInt[j] = number % 10;
                    bigInt[j - 1] += number / 10;
                }

                //Fix the end of the number
                int num = bigInt[0];
                bigInt[0] = num % 10;
                num /= 10;
                while(num != 0)
                {
                    bigInt.Insert(0, num % 10);
                    num /= 10;
                }

            }


            return bigInt;
        }
    }
}
