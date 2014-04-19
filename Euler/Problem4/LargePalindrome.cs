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


            foreach (int palindrome in NextPalindrome())
            {
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

        public static IEnumerable<int> NextPalindrome()
        {
            int maxHalf = (int)Math.Pow(10, NB_DIGIT) - 1;
            //hardcode here for 3 digits
            for (int i = maxHalf; i >= 10; --i)
                yield return MakePalindrome(i);

            for (int i = maxHalf; i >= 100; --i)
                yield return MakePalindrome(i, true);
            
        }

        /*
         * Return a palindrome where half is the left side
         * If odd is true, the palindrome will have an odd number 
         * of digits, with the last digit of half as the middle digit
         */
        public static int MakePalindrome(int half, bool odd = false)
        {
            List<int> list = new List<int>();
            int tmp = half;
            while (tmp != 0)
            {
                list.Add(tmp % 10);
                tmp /= 10;
            }
            //List contain the digits of half in reverse order
            int palindrome = half * (int)Math.Pow(10, NB_DIGIT);

            int i = (odd) ? 1 : 0;
            if (odd) palindrome /= 10;
            for(; i < list.Count; ++i)
            {
                palindrome += list[i] * (int)Math.Pow(10, list.Count - i-1);
            }

            return palindrome;

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
