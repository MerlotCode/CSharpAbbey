using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRolling
{
    class DiceRolling
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());
            string result = "";
            for (int i = 0; i < amount; i++)
            {
                float input = float.Parse(Console.ReadLine());
                float val = 6 * input;
                int res = Convert.ToInt32(Math.Floor(val));
                res++;
                result += res + " ";
            }
            Console.WriteLine(result);
        }
    }
}
