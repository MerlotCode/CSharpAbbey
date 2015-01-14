using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    class SumOfDigits
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());
            string result = "";

            for (int i = 0; i < amount; i++)
            {
                string input = Console.ReadLine();
                string[] arr = input.Split(' ');

                int x = int.Parse(arr[0]);
                int y = int.Parse(arr[1]);
                int z = int.Parse(arr[2]);

                int res = x * y + z;
                int sum = 0;

                while (res > 0)
                {
                    sum += (res % 10);
                    res = res / 10;
                }

                result +=  sum + " ";

            }
            Console.WriteLine(result);
        }
    }
}
