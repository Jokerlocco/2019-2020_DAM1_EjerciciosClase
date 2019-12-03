using System;

class Program
{
    static void Get2Max(float [] data,ref float absMax, ref float Max2)
    {
        Max2 = data[0];
        absMax = data[0];
        int posMax = 0;
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] >= absMax)
            {
                absMax = data[i];
                posMax = i;
            }
        }

        for (int i = 0; i < data.Length; i++)
        {
            if(i!= posMax)
            {
                if (data[i] >= Max2)
                {
                    Max2 = data[i];
                }
            }
        }
    }

    static void Main()
    {
        float[] data = { 2, 7.5f, 6, -1, 20, 5 };
        float max = 0;
        float max2 = 0;

        Get2Max(data, ref max, ref max2);
        Console.WriteLine("Max is " + max + 
            ", second is " + max2);
    }
}
