using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem28
{
    class NumberSpiralDiagonal
    {
        static void Main(string[] args)
        {
            int sum = 1;
            int pos = 1;
            int jump;
            int dimension = 1001;
            int layer = dimension / 2;

            for(int i = 1; i <= layer; ++i )
            {
                jump = 2 * i;
                for(int corner = 0; corner < 4; ++corner)
                {
                    pos = pos + jump;
                    sum += pos;
                }
                
            }
            Console.WriteLine(sum);
        }
    }
}
