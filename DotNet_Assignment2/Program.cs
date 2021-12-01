using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNet_Assignment // Note: actual namespace depends on the project name.
{
    
    public class Program
    {
        static int[] test_data = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };
        public static void Main(string[] args)
        {
            var value1 = new StatsComputation();

            value1.Numbers = test_data;
            var mean = value1.Calc_Mean();
            Console.WriteLine("Mean :"+mean);
            var median = value1.Calc_Median();
            Console.WriteLine("Median :" + median);
            var mode = value1.Calc_Mode();
            Console.WriteLine("Mode :"+ mode);
        }
    }
}