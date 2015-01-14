using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayChecksum
{
    class ArrayChecksum
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string[] arr = input.Split(' ');

            long result = 0;

            for (int i = 0; i < amount; i++)
            {
                result += long.Parse(arr[i]);
                result = result * 113;
                result = (result % 10000007);
            }
            Console.WriteLine(result.ToString());
        }
    }
}
