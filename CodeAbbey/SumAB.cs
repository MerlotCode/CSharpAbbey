using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAbbey
{
    class SumAB
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Data: ");
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int sum = a + b;
            Console.WriteLine("answer: ");
            Console.WriteLine(sum);
        }
    }
}
