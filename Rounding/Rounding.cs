using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rounding
{
    class Rounding
    {
        static void Main(string[] args)
        {
            string result = "";
            int howMany = int.Parse(Console.ReadLine());
            for (int i = 0; i < howMany; i++)
            {
                string[] input = Console.ReadLine().Split();
                decimal a = decimal.Parse(input[0]);
                decimal b = decimal.Parse(input[1]);
                decimal sum = a / b;
                int rounded = (int)Math.Round(sum, MidpointRounding.AwayFromZero);
                result += rounded.ToString() + " ";
            }
            Console.WriteLine(result);
        }
    }
}
