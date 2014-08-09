using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem30
{
    class DigitFifthPower
    {
        static void Main(string[] args)
        {
            int min = 10; //according to WolframAlpha
            int pow = 5;
            int dumbMax = 999999;

            int sum = 0;
            int i = min;
            int result;
            while (i <= dumbMax)
            {
                if ((result = SumOfPower(i, pow)) == i)
                    sum += result;

                ++i;
            }

            Console.WriteLine(sum);

        }

        public static int SumOfPower(int nb, int pow)
        {
            int sum = 0;

            while(nb != 0)
            {
                int digit = nb % 10;
                sum += (int)Math.Pow(digit, pow);
                nb /= 10;
            }

            return sum;
        }
    }
}
