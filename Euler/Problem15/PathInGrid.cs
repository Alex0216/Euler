using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Problem15
{
    class Program
    {
        static long[,] NB_PATH = new long[21, 21];

        static void Main(string[] args)
        {
            for(int i = 0; i < 21; ++i)
            {
                NB_PATH[i, 20] = 1;
                NB_PATH[20, i] = 1;
            }

            Stopwatch timer = new Stopwatch();
            timer.Start();
            long answer = GetNbPathToEnd(0,0,20);
            timer.Stop();
            Console.WriteLine(answer + " time: " + timer.ElapsedMilliseconds);
        }

        public static long GetNbPathToEnd(int x, int y, int size)
        {
            if (x == size || y == size)
                return 1;

            if (NB_PATH[x + 1, y] == 0)
                NB_PATH[x + 1, y] = GetNbPathToEnd(x + 1, y, size);

            if (NB_PATH[x, y + 1] == 0)
                NB_PATH[x, y + 1] = GetNbPathToEnd(x, y + 1, size);

            return NB_PATH[x + 1, y] + NB_PATH[x, y + 1];
        }
    }
}
