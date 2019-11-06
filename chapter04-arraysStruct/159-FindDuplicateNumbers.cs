// Finding duplicate numbers in a space-separated string

using System;

class FindDuplicateNumber
{
    static void Main()
    {
        Console.Write("Enter a few numbers: ");
        string[] sentence = Console.ReadLine().Split();

        bool repetitionsFound = false;

        for(int i = 0; i < sentence.Length; i++)
        {
            for(int j = i + 1; j < sentence.Length; j++)
            {
                if(sentence[i] == sentence[j])
                {
                    repetitionsFound = true;
                    Console.Write(sentence[i] + " ");
                }
            }
        }

        if(! repetitionsFound)
            Console.WriteLine("There are no repeated words");
    }
}
