using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Problem6
{
    class SumSquareDiff
    {
        const int MAX = 100;
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int result = SquareOfSum(MAX) - SumOfSquare(MAX);
            timer.Stop();
            Console.WriteLine(result + " time : " + timer.ElapsedMilliseconds);
        }

        public static int SumOfSquare(int number)
        {
            int sum = 0;
            foreach (int n in Enumerable.Range(1, number))
                sum += (int)Math.Pow(n, 2);

            return sum;
        }

        public static int SquareOfSum(int number)
        {
            return (int)Math.Pow(Enumerable.Range(1, number).Sum(), 2);
        }
    }
}
