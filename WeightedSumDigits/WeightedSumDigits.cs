using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightedSumDigits
{
    class WeightedSumDigits
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());
            string result = "";
            string input = Console.ReadLine();
            string[] arr = input.Split(' ');
            for (int i = 0; i < amount; i++)
            {
                string tempStr = arr[i];
                int value = 0;
                for (int j = 0; j < tempStr.Length; j++)
                {
                    value += (int)char.GetNumericValue(tempStr[j]) * (j + 1);               
                }
                result += value + " ";
            }
            Console.WriteLine(result);
        }
    }
}
