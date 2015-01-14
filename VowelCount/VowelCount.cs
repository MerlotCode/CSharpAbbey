using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelCount
{
    class VowelCount
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string result = "";
            for (int i = 1; i <= length; i++)
            {
                string str = Console.ReadLine().ToLower();

                int count = System.Text.RegularExpressions.Regex.Matches(str, "[aeiouy]").Count;
                result += count + " ";
            }
            Console.WriteLine(result);
        }
    }
}
