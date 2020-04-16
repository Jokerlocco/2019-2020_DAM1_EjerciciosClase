//kiko

// Note: the speed is good, but the results for big
// numbers are not correct

/*A composite number is a positive integer that has at least one positive
 * divisor other than one or the number itself.In other words, a composite 
 * number is any positive integer greater than one that is not a prime number.
 
    For example, 14 = 2*7 and 18 = 2*3*3 are composite numbers.

    We will say a number is "almost prime" if it has exactly two 
    (not necessarily distinct) prime factors.

    For example, the following numbers are almost prime: 6 = 2*3, 25 = 5*5. 
    And the following numbers are not: 17 (prime), 81 = 3*3*3*3.


    Please help us get an idea about how many almost prime numbers
    there are in certain integer intervals.

    Input
    The first line contains an integer T, the number of test cases.
    T lines follow, containing two integers each: A and B, separated by a space.


    Output
    For each test case, print the number of almost prime 
    numbers P that verify A ≤ P ≤ B.

Sample input

6
1 10
10 20
30000 40000
300000 400000
2000000 5000000
1 9999999

Sample output

4
3
2329
20923
571990
1904324

Time taken on i7 7700:

30000 40000 : 1.27 seg
300000 400000 : 15.9 seg
2000000 5000000 : interrupted after several minutes
1 9999999 : not tested

*/

using System;
using System.Collections.Generic;

class AlmostPrime
{
    static void Main()
    {
        int cases = Convert.ToInt32(Console.ReadLine());
        bool debugging = true;

        for (int i = 0; i < cases; i++)
        {
            string numbers = Console.ReadLine();
            DateTime start = DateTime.Now;

            int head = Convert.ToInt32(numbers.Split(' ')[0]);
            int tail = Convert.ToInt32(numbers.Split(' ')[1]);

            List<int> primesToCheck = new List<int>();
            List<int> almostPrime = new List<int>();
            
            //Get prime numbers until greatest number           
            
            primesToCheck.Add(2);
            bool stop = false;
            int j = 0;

            for (int l = 2; l <= tail; l++)
            {
                stop = false;
                j = 0;
                while (j < primesToCheck.Count && !stop)
                {
                    float result = l / primesToCheck[j];

                    if (result < primesToCheck[j])
                    {
                        primesToCheck.Add(l);
                        
                        
                        stop = true;
                    }

                    else if (l % primesToCheck[j] == 0)
                    {
                        stop = true;
                    }
                    j++;
                }
            }
           
            //At this point is where i can check all the prime numbers recorded 
            //previously multiplying all the possible combinations

            int headToMultiply = 0;
            int tailToMultiply = 0;

            bool numberChanged = false;

            while (headToMultiply < primesToCheck.Count)
            {
                numberChanged = false;
                int result = primesToCheck[headToMultiply] *
                    primesToCheck[tailToMultiply];

                if (result > tail || tailToMultiply == primesToCheck.Count - 1)
                {
                    headToMultiply++;
                    tailToMultiply = headToMultiply;
                    numberChanged = true;
                }

                else if (result <= tail && result >= head)
                {
                    almostPrime.Add(result);                    
                }

                if (tailToMultiply < primesToCheck.Count && !numberChanged)
                    tailToMultiply++;
            }
            Console.WriteLine(almostPrime.Count);
            if (debugging)
                Console.WriteLine(" Taken: " + (DateTime.Now-start));
        }
    }
}
