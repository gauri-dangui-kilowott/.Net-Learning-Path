using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_All_Challenges
{
    internal class Challenge5
    {   
        public static void Calc_Max()
        {
            //To find max of two no.s using System.Math class method
            int firstValue = 500;
            int secondValue = 600;
            int largerValue;

            largerValue = Math.Max(firstValue, secondValue);
            Console.WriteLine(largerValue);

        }
    }
}
