using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingnment_3
{
    internal class StatsCalc
    {
        internal int[] Numbers 
        { 
            private 
                get; 
            set; 
        }

        internal StatsResults GetStatsProcessorResult()
        {
            var result = new StatsResults();
            result.Mean = CalculateMean();
            result.Median = CalculateMedian();
            result.Mode = CalculateMode();
            return result;
        }

        private decimal CalculateMean()
        {

            int sum = 0;
            decimal mean = 0;
            //to calculate the mean
            foreach (int test in Numbers)
            {
                sum = sum + test;

            }
            mean = (decimal)sum / Numbers.Length;
            //Console.WriteLine($"Mean :{mean}");
            return mean;
        }

        private int CalculateMedian()
        {

            //To calculate the median
            Array.Sort(Numbers);

            //Console.WriteLine(test_data.Length);
            int m = (Numbers.Length) / 2;
            int n = Numbers[m];
            return n;

        }

        private int CalculateMode()

        {
            int maxcount = 0, maxnum = 0;
            for (int i = 0; i < Numbers.Length; i++)
            {
                int count = 0;
                for (int j = 1; j < Numbers.Length - 1; j++)
                {
                    if (Numbers[i] == Numbers[j])
                    {

                        count++;
                    }
                }

                if (count > maxcount)
                {
                    maxcount = count;
                    maxnum = Numbers[i];
                }

            }


            return maxnum;
        }


    }
}
