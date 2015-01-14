using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumInLoop
{
    class SumInLoop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data: ");
            int amount = int.Parse(Console.ReadLine());
            int sum = 0;
            string result = "";
            for (int i = 0; i < amount; i++)
            {
                string[] input = Console.ReadLine().Split();
                sum = int.Parse(input[0]) + int.Parse(input[1]);
                string sumStr = sum.ToString() + " ";
                result = String.Concat(result, sumStr);               
            }
            Console.WriteLine("answer: ");
            Console.WriteLine(result);
        }
    }
}
