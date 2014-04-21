using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem19
{
    class CountingSunday
    {
        
        readonly static int[] MAGIC = new int[] { 0, 3, 2,5,0,3,5,1,4,6,2,4};

        static void Main(string[] args)
        {
            int nbSunday = 0;
            for (int y = 1901; y <= 2000; ++y )
            {
                for(int m = 1; m <=12; ++m)
                    if( DayOfWeek(y, m, 1) == 0)
                        nbSunday++;
            }
            Console.WriteLine(nbSunday);
        }

        public static int DayOfWeek(int year, int month, int day)
        {
            year -= (month < 3) ? 1 : 0;

            return (year + year / 4 - year / 100 + year / 400 + MAGIC[month - 1] + day) % 7;
        }
    }
}
