using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem21
{
    public class AmicableNumber
    {
        static void Main(string[] args)
        {
            List<int> amicableNumber = new List<int>();

            Console.WriteLine(GetFactorSum(220));
            Console.WriteLine(GetFactorSum(284));

            for(int i = 1; i < 10000; ++i)
            {
                if (amicableNumber.Contains(i))
                    continue;
                
                int da = GetFactorSum(i);
                
                int db =(i < da)?0: GetFactorSum(da);

                if (i == db && i != da)
                {
                    amicableNumber.Add(i);
                    amicableNumber.Add(da);
                }
            }

            Console.WriteLine(amicableNumber.Sum());
        }

        public static int GetFactorSum(int num)
        {
            return GetFactor(num).Sum();
        }

        public static List<int> GetFactor(int num)
        {
            List<int> factor = new List<int>();
            for (int i = 1; i <= num / 2; ++i)
                if (num % i == 0)
                    factor.Add(i);
            return factor;
        }
    }
}
