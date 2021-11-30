// To calculate the mean we used the following formula

sum/length of the array 
length of the array has been found by using .Length function

//To find the median the array has been first sorted.
 int m = (test_data.Length)/2 ;
            Console.WriteLine($"Median :{test_data[m]}");

//To calculate the mode we first found the frequency of each number. The below code then compares each count with the previous count
if(count> maxcount)
                {
                    maxcount = count;
                    maxnum = test_data[i];  
                }
