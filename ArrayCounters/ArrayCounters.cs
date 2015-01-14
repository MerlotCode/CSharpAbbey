using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCounters
{
    class ArrayCounters
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            int m = int.Parse(data[0]);
            int n = int.Parse(data[1]);
            string result = "";

            string[] strValues = Console.ReadLine().Split(' ');
            int[] occurs = new int[n];
            for (int j = 0; j < n; j++)
            {
                occurs[j] = 0;
            }
            for (int i = 0; i < strValues.Length; i++)
            {
                int x = int.Parse(strValues[i]);
                occurs[x - 1]++;
            }
            for (int k = 0; k < n; k++)
            {
                result += occurs[k].ToString() + " ";
            }
            Console.WriteLine(result);
        }
    }
}
