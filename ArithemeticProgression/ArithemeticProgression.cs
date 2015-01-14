using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithemeticProgression
{
    class ArithemeticProgression
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string result = "";

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                int n = int.Parse(input[2]);
                int sum = 0;

                for (int j = 0; j < n; j++)
                {
                    sum += (a + (b * j));
                }
                result += sum + " ";
            }

            Console.WriteLine(result);
        }
    }
}
