//Ruth Martínez Iborra

using System;

class Mode
{
    static void Main()
    {
        int[] numbers = { 3, 1, 1, 2, 3, 2, 5, 5, 3, 5, 3 };
        int mode = 0;
        int countMax = 0;

        for (int num = 0; num < numbers.Length; num++)
        {
            int count = 0;
            for (int pos = num + 1; pos < numbers.Length; pos++)
            {
                if (numbers[num] == numbers[pos])
                {
                    count++;
                }
            }
            if (count > countMax)
            {
                countMax = count;
                mode = numbers[num];
            }
        }
        Console.WriteLine("Mode: " + mode);
    }
}
