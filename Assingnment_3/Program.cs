
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
    // Note: actual namespace depends on the project name.
{

    public class Program
    {
        static int[] test_data = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };
        public static void Main(string[] args)
        {
            var scObject = new StatsCalc();

            scObject.Numbers = test_data;

            /*
             * invoke the method to do the processing 
             * and capture the output
             */
            var result = scObject.GetStatsProcessorResult();

            /// console i/o is not the responsibility of the StatsProcessor class!
            Console.WriteLine($"Average: {result.Mean}");
            Console.WriteLine($"Median: {result.Median}");
            Console.WriteLine($"Mode :{ result.Mode}");


        }
    }
}

