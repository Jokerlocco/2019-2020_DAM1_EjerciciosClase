//Pablo José Ferrándiz Navarro 

/*

Xmas Review 01

Create a program that asks the user his/her name and how many times they want 
to see it written. You must write the name as many times as told by the user, 
each in a different line. In the odd lines, the name will be displayed as is; 
in the even lines it will be shown uppercase and between "smiles"

Juan
(-: JUAN :-)
Juan

*/

using System;

class Xmas01
{
    static void Main()
    {
        int repetitions;
        string name;
        
        Console.Write("Enter your name: ");
        name = Convert.ToString(Console.ReadLine());
        Console.Write("How many times?: ");
        repetitions = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 1; i <= repetitions; i++)
        {
            if (i % 2 == 0)
            {
                string nameUpper = name.ToUpper();
                Console.WriteLine("(-: " + nameUpper + " :-)");
            }
            else
                Console.WriteLine(name);
        }
    }
}
