using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Problem13
{
    class LargeSum
    {
        static void Main(string[] args)
        {
            var data = getData();

            Console.WriteLine(data);
        }

        public static BigInteger getData()
        {
            BigInteger bigNumber = 0;
           
            using(StreamReader sr = new StreamReader("../../Numbers.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    bigNumber += BigInteger.Parse(line);
                }
                
            }

            return bigNumber;
        }
    }
}
