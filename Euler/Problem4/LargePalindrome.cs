using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Problem4
{
    class LargePalindrome
    {
        const int NB_DIGIT = 3;
        
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            //Find the largest palindrome, then test if it can be obtain by 
            //the product of two 3 digits number
            int maxHalf = (int)Math.Pow(10, NB_DIGIT) - 1;

            int minLimit = (int)Math.Pow(Math.Pow(10, NB_DIGIT - 1), 2);


            for (int palindrome = maxHalf * maxHalf; palindrome >= minLimit; --palindrome )
            {
                while (!IsPalindrome(palindrome))
                    palindrome--;

                if (IsProductOfNDigits(palindrome, NB_DIGIT))
                {
                    timer.Stop();
                    Console.WriteLine(palindrome + " time: " + timer.ElapsedMilliseconds);
                    return;
                }

            }
     
        }

        public static bool IsProductOfNDigits(int num, int nbDigits)
        {
            int max = (int)Math.Pow(10, nbDigits) - 1;
            int min = (int)Math.Pow(10, nbDigits - 1);

            for (int divisor = max; divisor >= min; --divisor)
            {
                if (num % divisor == 0 && num / divisor >= min && num/divisor <= max)
                    return true;
            }

            return false;
        }


        //Could do some optimization here!
        public static bool IsPalindrome(int num)
        {
            
            List<int> list = new List<int>();
            while(num != 0)
            {
                list.Add(num % 10);
                num /= 10;
            }

            for (int i = 0; i < list.Count / 2; ++i )
            {
                if (list[i] != list[list.Count - i - 1])
                    return false;
            }

            return true;
        }
    }
}
