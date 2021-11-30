using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Assignment
{
    internal class stats
    {
        public static void Calc_stats()
        {
            int[] test_data = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };
            int sum = 0 , maxcount = 0 , maxnum = 0 ;
            decimal mean = 0;
            //to calculate the mean
            foreach(int test in test_data)
            {
                sum = sum + test;

            }
            mean = (decimal)sum / test_data.Length;
            Console.WriteLine($"Mean :{mean}");

            //To calculate the median
            Array.Sort(test_data);
            //Console.WriteLine(test_data.Length);
            int m = (test_data.Length)/2 ;
            Console.WriteLine($"Median :{test_data[m]}");

            //To calculate the mode
              for (int i=0; i < test_data.Length; i++)
            {
                int count = 0;
                for(int j=1;j<test_data.Length-1; j++)
                {
                    if(test_data[i]==test_data[j])
                    {
                       
                        count++;
                     }
                }
        
                if(count> maxcount)
                {
                    maxcount = count;
                    maxnum = test_data[i];  
                }
            }
            

                Console.WriteLine($"Mode : {maxnum}");
            }


        
    }
}

