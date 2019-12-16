/*

All Ireland Programming Olympiad 2016

Problem 1 - George Boole

George BooleGeorge Boole was an English mathematician, educator, 
philosopher who was born in 1815, 200 years ago. He was the first 
professor of mathematics at Queen's College, Cork (now University 
College Cork (UCC)) and is known as the inventor of boolean arithmetic: 
The field that is the basis of today’s computers.

In boolean arithmetic, instead of infinite numbers we only have 2 
values: 0/1, true/false, yes/no, etc. We will use the values true and 
false in this problem. The two most common operations in boolean 
arithmetic are AND and OR.

The result of an AND operation is true only if both elements are true. 
Examples:

true AND true = true

true AND false = false

false AND false = false

The result of an OR operation is true if any of the elements are true. 
Examples:

true OR true = true

false OR false = false

false OR true = true 

In this problem you’ll read one of such operations and write the 
correct result.

 Input

Read a single line from the standard input. The line will contain three 
words with the format:

value1 operation value2. 

The fields value1 and value2 will be either true or false. The field 
operation will be either AND or OR.

 

Output

Print either true or false.

Test your program with the following examples. We you execute your 
solution with the input example, the result should be exactly equal to 
the output example.

 Input example 1

true AND true

Output example 1

true

Input example 2

true OR true

Output example 2

true

Input example 3

true AND false

Output example 3

false

Input example 4

false OR true

Output example 4

true

Input example 5

false AND false

Output example 5

false

Input example 6

false OR false

Output example 6

false

*/

using System;
class GeorgeBoole1
{
    static void Main()
    {
        string[] data = Console.ReadLine().Split();

        bool data1 = Convert.ToBoolean(data[0]);
        bool data2 = Convert.ToBoolean(data[2]);

        switch(data[1])
        {
            // Note: these messages should be converted to lowercase
            case "AND":
                Console.WriteLine(data1 && data2);
                break;
            case "OR":
                Console.WriteLine(data1 || data2);
                break;
        }

    }
}
