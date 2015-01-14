using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumOfTwo
{
    class MinimumOfTwo
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Data: ");
            int amount = int.Parse(Console.ReadLine());
            int smaller = 0;
            string result = "";
            for (int i = 0; i < amount; i++)
            {
                string[] input = Console.ReadLine().Split();
                smaller = (int.Parse(input[0]) < int.Parse(input[1])) ? int.Parse(input[0]) : int.Parse(input[1]);
                string sumStr = smaller.ToString() + " ";
                result = String.Concat(result, sumStr);
            }
            //Console.WriteLine("answer: ");
            Console.WriteLine(result);
        }
    }
}
