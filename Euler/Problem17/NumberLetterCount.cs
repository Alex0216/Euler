using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem17
{
    class NumberLetterCount
    {
        static Dictionary<int, string> IntToStringDic = new Dictionary<int, string>
            {
                {1, "one"},  {11, "eleven"},
                {2, "two"},  {12, "twelve"},  {20, "twenty"},
                {3, "three"},{13, "thirteen"},{30, "thirty"},
                {4, "four"}, {14, "fourteen"},{40, "forty"},
                {5, "five"}, {15, "fifteen"}, {50, "fifty"},
                {6, "six"},  {16, "sixteen"}, {60, "sixty"},
                {7, "seven"},{17, "seventeen"},{70, "seventy"},
                {8, "eight"},{18, "eighteen"}, {80, "eighty"},
                {9, "nine"}, {19, "nineteen"}, {90, "ninety"},
                {10, "ten"}, {100, "hundred"}, {1000, "thousand"},
            };
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 1000; ++i)
                sum += GetNbLetter(i);

            Console.WriteLine(sum);
        }

        public static int GetNbLetter(int number)
        {
            string english;
            IntToStringDic.TryGetValue(number, out english);
            if (english != null && number != 1000 && number != 100)
                return english.Count();

            int nbLetter = 0;

            //check for number between 11 and 19
            int teens = number % 100;
            english = null;
            IntToStringDic.TryGetValue(teens, out english);
            if(english != null)
            {
                nbLetter += english.Count();
                if(number >= 100)
                    nbLetter += "and".Count();
                number -= teens;
            }


            int unit = number % 10;
            if(unit > 0)
            {
                nbLetter += IntToStringDic[unit].Count();
                if (number >= 100)
                    nbLetter += "and".Count();
                number -= unit;
            }

            int tens = number % 100;
            if(tens > 0)
            {
                nbLetter += IntToStringDic[tens].Count();
                number -= tens;
            }

            int hundred = number % 1000;
            if(hundred > 0)
            {
                nbLetter += IntToStringDic[100].Count();
                nbLetter += IntToStringDic[hundred / 100].Count();
                number -= hundred;
            }

            if (number >= 1000)
                nbLetter += IntToStringDic[1000].Count() + IntToStringDic[number / 1000].Count();

            return nbLetter;
        }

    }
}
