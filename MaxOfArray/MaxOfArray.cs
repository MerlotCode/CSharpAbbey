using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxOfArray
{
    class MaxOfArray
    {
        static void Main(string[] args)
        {
            string result = "";
            string[] input = Console.ReadLine().Split();
            int max = int.Parse(input[0]);
            int min = int.Parse(input[0]);
            for (int i = 0; i < 300; i++)
            {
                int val = int.Parse(input[i]);
                max = (max > val) ? max : val;
                min = (min < val) ? min : val;
            }
            result = max.ToString() + " " + min.ToString();
            Console.WriteLine(result);
        }
    }
}
