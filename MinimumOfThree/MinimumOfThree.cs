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
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                int c = int.Parse(input[2]);
                smaller = (a < b) ? a : b;
                smaller = (smaller < c) ? smaller : c;
                string sumStr = smaller.ToString() + " ";
                result = String.Concat(result, sumStr);
            }
            //Console.WriteLine("answer: ");
            Console.WriteLine(result);
        }
    }
}
