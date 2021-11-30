﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_All_Challenges
{
    internal class Challenge6
    {
        public static void Dec_logic()
        {
            //Challenge on Decision Logic

            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            if (daysUntilExpiration == 0)
            {
                Console.WriteLine("Ooops! Your subscription has expired.");
            }
            else if (daysUntilExpiration == 1)
            {
                Console.WriteLine("Hurry up !Your subscription expires within a day!");
                discountPercentage = 20;
            }
            else if (daysUntilExpiration <= 5)
            {
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
                discountPercentage = 10;
            }
            else if (daysUntilExpiration <= 10)
            {
                Console.WriteLine("Your subscription will expire soon.  Renew now!");
            }

            if (discountPercentage > 0)
            {
                Console.WriteLine($"Renew now and save {discountPercentage}%.");
            }
        }
    }
}
