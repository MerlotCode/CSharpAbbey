using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FtoC
{
    class FtoC
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int length = int.Parse(input[0]);
            string result = "";
            for (int i = 1; i <= length; i++)
            {
                decimal f = decimal.Parse(input[i]);
                decimal c = (f - 32) * 5 / 9;
                int rounded = (int)Math.Round(c, MidpointRounding.AwayFromZero);
                result += rounded.ToString() + " ";
            }
            Console.WriteLine(result);
        }
    }
}
