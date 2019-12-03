using System;

class Main2016
{
    static int SumDigits(int num)
    {
        string digits = num.ToString();
        int sum = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            sum += Convert.ToInt32(
                digits.Substring(i,1));
        }
        return sum;
    }
    
    
    static void DisplayTextFramed(string text)
    {
        int length = text.Length;
        Console.Write("+");
        for (int i = 0; i < length + 4; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine("+");
        
        Console.Write("|  ");
        Console.Write(text);
        Console.WriteLine("  |");
        
        Console.Write("+");
        for (int i = 0; i < length + 4; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine("+");
    }
    
    
    static void Get2Max(float [] data,ref float max1, ref float max2)
    {
        max2 = data[0];
        max1 = data[0];
        int posMax = 0;
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] >= max1)
            {
                max1 = data[i];
                posMax = i;
            }
        }

        for (int i = 0; i < data.Length; i++)
        {
            if(i!= posMax)
            {
                if (data[i] >= max2)
                {
                    max2 = data[i];
                }
            }
        }
    }
    
    
    static int AmountOfDigits(uint number)
    {
        int digits = 1;
        while (number >= 10)
        {
            number = number / 10;
            digits++;
        }
        return digits;
    }

    static int AmountOfDigitsR(uint number)
    {
        if (number >= 10)
        {
            return 1 + AmountOfDigitsR(number / 10);
        }
        else
            return 1;
    }
       

    static int Main(string[] args)
    {
        int errorCode = 0;
        if (args.Length == 0)
            errorCode = 1;
        else
        {
            switch (args[0].ToUpper())
            {
                case "SUM":
                    if (args.Length == 2)
                        Console.WriteLine( SumDigits(
                            Convert.ToInt32(args[1]) );
                    else
                        errorCode = 2;
                    break;

                case "SECOND":
                    // ...
                    break;

                case "FRAME":
                    // ...
                    break;

                case "DIGITS":
                    // ...
                    break;

                default:
                    errorCode = 1;
                    break;
            }
            
            if (errorCode == 2)
                Console.WriteLine("Missing parameters");
            else if (errorCode == 1)
                Console.WriteLine("Usage: " +
                    "sum / second / frame / digits");
            
            return errorCode;
        }
    }
}
