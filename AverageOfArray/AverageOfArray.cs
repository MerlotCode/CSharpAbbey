using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageOfArray
{
    class AverageOfArray
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());
            string result = "";
            for (int i = 0; i < amount; i++)
            {
                float avg = 0;
                float tot = 0;
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < input.Length - 1; j++)
                {
                    tot += float.Parse(input[j]);
                }
                avg = tot / (input.Length - 1);
                int res = (int)Math.Round(avg, MidpointRounding.AwayFromZero);
                result += res + " ";
            }
            Console.WriteLine(result);
        }
    }
}
