using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem22
{
    class NameScore
    {
        static void Main(string[] args)
        {
           
            ulong rank = 1;
            ulong sum = 0;
            var names = GetNames();
            foreach (var name in names)
                sum += rank++ * GetAlphaValue(name);

            Console.WriteLine(sum);
        }

        public static List<string> GetNames()
        {
            List<string> names = new List<string>();

            using(StreamReader sr = new StreamReader("../../Names.txt"))
            {
                string file = sr.ReadToEnd();
                foreach(var name in file.Split(','))
                    names.Add(name.Trim('"'));
            }

            names.Sort();
            return names;
        }

        public static uint GetAlphaValue(string name)
        {
            uint value = 0;
            foreach (char c in name)
                value += (uint)c - 'A' + 1;

            return value;
        }
    }
}
