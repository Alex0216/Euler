using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem20
{
    class FactorialDigitSum
    {
        static void Main(string[] args)
        {
            
                Console.Write(Factorial(100).Sum());
        }

        public static List<int> Factorial(int n)
        {
            int tmp = n;
            List<int> bigInt = new List<int>();
            while (tmp != 0)
            {
                bigInt.Insert(0, tmp % 10);
                tmp /= 10;
            }

            for (int i = n-1; i > 0; --i)
            {
                //Multiply by the number
                for (int j = 0; j < bigInt.Count; ++j)
                    bigInt[j] *= i;

                //Go through the array to sum the carry
                for (int j = bigInt.Count - 1; j > 0; --j)
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
                while (num != 0)
                {
                    bigInt.Insert(0, num % 10);
                    num /= 10;
                }

            }


            return bigInt;
        }
    }
}
