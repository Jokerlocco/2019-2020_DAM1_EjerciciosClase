//Pablo Conde - Sequence length and minimum
//(Source: Zonal Indian Informatics Olympiad, 2013, Problem 2)

/*
Sequence length and minimum

You are given a sequence of integers, separated with commas.  You are allowed 
to pick some contiguous segment of this sequence (that is, a segment without 
any gaps), and multiply the length of this segment by the minimum number in the 
segment.  What is the maximum value that you can generate in this manner?

For example, suppose the given sequence is 7,2,8,10.  If you pick the entire 
sequence,the length is 4 and the minimum number is 2,  so the product is 8.  If 
you pick the segment 8,10, the length is 2 and the minimum number is 8, so the 
product is 16.  This is the maximum value you can generate for this sequence.  
Note that you cannot pick 7,8,10, since it is not a contiguous segment

So...

Example input
7,2,8,10

Ouput for that input
16

In each of the cases below, you are given a sequence of values and you have to 
determine the maximum value that you can generate by picking a contiguous 
segment and multiplying its length by the minimum number in the segment.

(a) 5,14,8,7,6,10,10,4,2,5,30
(b) 24,22,16,18,6,7,17,16,5,20,8,19,16
(c) 15,30,23,1,47,23,3,8,9,10,19,21,13,5,4

(Source: Zonal Indian Informatics Olympiad, 2013, Problem 2)
*/

using System;
using System.Linq;

class SequenceLength
{
    static void Main()
    {
        bool debugging = true;
        string[] arrayNumbers = Console.ReadLine().Split(',');
        int[] numList = new int[arrayNumbers.Length];
        
        for (int i = 0; i < arrayNumbers.Length; i++)
            numList[i] = Convert.ToInt32(arrayNumbers[i]);
        
        int maxValue = numList.Max();
        int length = 2;
      
        while(length <= numList.Length)
        {
            for (int i = 0; i < numList.Length-(length-1); i++)
            {
                int min = numList[i];
                
                for (int j = i; j < i + length; j++)
                {
                    if(numList[j] < min)
                        min = numList[j];
                }
                if(length * min > maxValue)
                {
                    if (debugging)
                        Console.WriteLine("New candidate: Len = " +length
                            + " Min =" + min);
                    maxValue = length * min;
                }
            }
            length++;
        }
        Console.WriteLine(maxValue);
    }
}
