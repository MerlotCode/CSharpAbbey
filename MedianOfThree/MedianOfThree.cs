using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedianOfThree
{
    class MedianOfThree
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());
            int median = 0;
            string result = "";
            for (int i = 0; i < amount; i++)
            {
                string[] input = Console.ReadLine().Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                int c = int.Parse(input[2]);
                //median = max(min(a, b), min(max(a, b), c));

                int val1 = (a > b) ? a : b;
                val1 = (val1 < c) ? val1 : c;
                int val2 = (a < b) ? a : b;
                median = (val1 > val2) ? val1 : val2;
                result += median.ToString() + " ";
            }
            Console.WriteLine(result);
        }
    }
}
