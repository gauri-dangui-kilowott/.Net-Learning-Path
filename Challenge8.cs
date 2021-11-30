using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_All_Challenges
{
    internal class Challenge8
    {
        public static void Code_more_readable()
        {
            //To make the code more readable
            /*
 To reverse a string and count the number of times a particular character appears.
 */

            string originalMessage = "The quick brown fox jumps over the lazy dog.";
            char[] changedMessage = originalMessage.ToCharArray();

            Array.Reverse(changedMessage);

            int count = 0;

            foreach (char i in changedMessage)
            {
                if (i == 'o')
                {
                    count++;
                }
            }

            string newMessage = new String(originalMessage);

            Console.WriteLine(changedMessage);
            Console.WriteLine($"'o' appears {count} times.");
        }

    }
}
