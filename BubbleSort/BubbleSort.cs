using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class BubbleSort
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            string result = "";
            int[] arr = new int[count];

            for (int x = 0; x < count; x++)
            {
                arr[x] = int.Parse(input[x]);
            }

            int passCount = 0;
            int swapCount = 0;
            int swapCountTotal = 0;
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                swapCount = 0;
                for (int j = 0; j < arr.Length - 1; j++)
                {                    
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                        swapCount++;
                    }
                }
                swapCountTotal += swapCount;
                passCount++;
                if (swapCount == 0) break;
            }
            result = passCount + " " + swapCountTotal;
            Console.WriteLine(result);
        }
    }
}
