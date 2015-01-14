using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMassIndex
{
    class BodyMassIndex
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());
            string result = "";
            for (int i = 0; i < amount; i++)
            {
                string[] input = Console.ReadLine().Split();
                int weight = int.Parse(input[0]);
                float height = float.Parse(input[1]);
                float BMI = weight / (height * height);
                if (BMI < 18.5)
                    result += "under ";
                else if (BMI < 25)
                    result += "normal ";
                else if (BMI < 30)
                    result += "over ";
                else
                    result += "obese ";
            }
            Console.WriteLine(result);
        }
    }
}
