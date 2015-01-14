using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularCalculator
{
    class ModularCalculator
    {
        static void Main(string[] args)
        {
            BigInteger result = BigInteger.Parse(Console.ReadLine());

            string op = "";
            long value = 0;
            string[] input;

            while (!op.Equals("%"))
            {
                input = Console.ReadLine().Split(' ');
                op = input[0];
                value = long.Parse(input[1]);
                if (op.Equals("+"))
                {                    
                    result = (result + value);
                }
                else if (op.Equals("*"))
                {
                    result = (result * value);
                }
                else
                {
                    result %= value;
                }
            }
            Console.WriteLine(result);
        }
    }
}
