using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class FibonacciSequence
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            BigInteger input = new BigInteger();
            string result = "";

            double t = Math.Sqrt(5) + 0.5;

            for (int i = 0; i < count; i++)
            {
                input = BigInteger.Parse(Console.ReadLine());
                if (input.Equals(0))
                {
                    result += "0 ";
                    continue;
                }
                BigInteger x = input * (BigInteger)t;
                double res = Math.Log((double)x, ((1+Math.Sqrt(5))/2));
                int rounded = (int)Math.Round(res, MidpointRounding.AwayFromZero);
                result += rounded + " ";
            }
            Console.WriteLine(result);
        }
    }
}
