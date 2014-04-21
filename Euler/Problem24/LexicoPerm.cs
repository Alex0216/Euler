using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem24
{
    class LexicoPerm
    {
        static void Main(string[] args)
        {
            List<int> set = new List<int> { 0,1,2,3,4,5,6,7,8,9};
            for(int i = 0; i < 999999; ++i)
            {

                set = NextPermutation(set);
                Console.WriteLine();
            }
            foreach (int s in set)
                Console.Write(s);
            
        }

        //implementation of the algo found at http://en.wikipedia.org/wiki/Permutation#Generation_in_lexicographic_order
        public static List<int> NextPermutation(List<int> set)
        {
            if (set.Count < 2)
                return set;

            //Find the largest index k such that a[k] < a[k + 1]
            int k = set.Count-2;
            while (k >= 0 && set[k] > set[k + 1] )
                k--;

            //If no such index exists, the permutation is the last permutation.
            if (k == -1)
                return set;

            //Find the largest index l such that a[k] < a[l].
            int i = k + 1;
            while (i < set.Count-1 && set[i+1] > set[k])
                ++i;

            //Swap the value of a[k] with that of a[l].
            int temp = set[k];
            set[k] = set[i];
            set[i] = temp;

            int nbSwap = (set.Count - (k + 1)) / 2;
            //Reverse the sequence from a[k + 1] up to and including the final element a[n]
            for(int index = k+1, offset = 1; offset <= nbSwap; ++index, ++offset)
            {
                int tmp = set[index];
                set[index] = set[set.Count - offset];
                set[set.Count - offset] = tmp;
            }

            return set;

        }
    }
}
