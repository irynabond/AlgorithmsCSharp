using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Strings
    {
        public static void RemoveDuplicate(string str)
        {
            var hashset = new HashSet<char>();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i<str.Length; i++)
            {
                hashset.Add(str[i]);
            }

            foreach (var c in hashset)
            {
                result.Append(c);
            }
            result.ToString();
            Console.WriteLine(result);
        }
    }
}
