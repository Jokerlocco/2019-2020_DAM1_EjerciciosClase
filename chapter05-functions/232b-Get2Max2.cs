// Get2Max, second approach

using System;

class Get2MaxB
{
    static void Get2Max(float[] data, ref float max1, ref float max2)
    {
        int size = data.Length;
        int[] copyOfData = new int[size];
        Array.Copy(data, copyOfData, size);

        for (int i = 0; i < copyOfData.Length - 1; i++)
        {
            for (int j = i + 1; j < copyOfData.Length; j++)
            {
                if (copyOfData[i] > copyOfData[j])
                {
                    float aux = copyOfData[i];
                    copyOfData[i] = copyOfData[j];
                    copyOfData[j] = aux;
                }
            }
        }
        max1 = copyOfData[copyOfData.Length - 1];
        max2 = copyOfData[copyOfData.Length - 2];
    }

    static void Main()
    {
        float[] data = { 2, 7.5f, 6, -1, 20, 5 };
        float max = 0;
        float max2 = 0;

        Get2Max(data, ref max, ref max2);
        Console.WriteLine("Max is " + max +
            ", second is " + max2);

        foreach (float f in data) Console.Write(f + " ");
    }
}
