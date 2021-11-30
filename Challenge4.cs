using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_All_Challenges
{
    internal class Challenge4
    {
        public static void Conv_temp()
        {
            //To convert temperature from fahrenheit to degree celcius
            int fahrenheit = 94;

            decimal celsius = (fahrenheit - 32m) * (5m / 9m);

            Console.WriteLine("The temperature is " + celsius + " Celsius.");
        }
    }
}
