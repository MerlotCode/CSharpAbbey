using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollatzSequence
{
    class CollatzSequence
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            string result = "";

            for (int i = 0; i < count; i++)
            {
                long value = long.Parse(input[i]);
                int steps = 0;

                while (value > 1)
                {
                    if (value % 2 == 0)
                        value = (value / 2);
                    else
                        value = (3 * value + 1);
                    steps++;
                }
                result += steps.ToString() + " ";
            }
            Console.WriteLine(result);
        }
    }
}
