//Joel Martinez

using System;

class mainFunciones
{
    static int mcd(int num1, int num2)
    {
        if (num2 == 0)
        {
            return num1;
        } 
        
        int aux = 0;
        while (num2 != 0)
        {
            aux = num1;
            num1 = num2;
            num2 = aux % num2;
        }
        
        return num1;
    }
    
    public static bool IsPrime(long x)
    {
        for(long i = 2; i < x / 2; i++)
        {
            if(x % i == 0)
                return false;
        }
        return true;
    }
    
    
    public static bool IsCircularPrime(long x)
    {
        string numberStr = x.ToString();
        int size = numberStr.Length;
        
        for(int i = 0; i < size; i++)
        {
            if(!IsPrime( Convert.ToInt64(numberStr) ))
                return false;
            numberStr = numberStr.Substring(1) + numberStr[0];
        }
        return true;
    }
    
    
    static void CountMm( string s, ref int upper, ref int lower )
    {
        upper = 0;
        lower = 0;
        
        for ( int i = 0; i < s.Length; i++ )
        {
            if ( s[i] >= 'A' && s[i] <= 'Z' )
                upper++;
            else if ( s[i] >= 'a' && s[i] <= 'z' )
                lower++;
        }
    }
    
    
    static void DrawParallelogram(byte width, byte height, char symbol)
    {
        // First line
        Console.WriteLine(new string (symbol, width));

        // Middle lines
        string spaces = new string(' ', width - 2);
        for (int i = 1; i < height-1; i++)
        {
            Console.WriteLine(new string (' ', i) + 
                symbol + spaces + symbol);
        }

        // Last line
        Console.WriteLine(new string (' ', height-1) 
            + new string (symbol, width));
    }
    
    
    static void Main(string[] args)
    { 
        Convert.ToString(args[0]).ToLower();
        int errorCode = 0;
        
        switch (args[0])
        {
            case "cprime":
                if (args.Length == 3)
                {
                    if (IsCircularPrime(Convert.ToInt64(args[1])))
                    {
                        Console.WriteLine("Es un numero primo circular");
                    } else 
                    {
                        Console.WriteLine("No es un numero primo circular");
                    }
                } else
                {
                    errorCode = 2;
                }
                break;
            case "mm":
                if (args.Length == 2)
                {
                
                    int upper = 0;
                    int lower = 0;
                    CountMm(args[1], ref upper, ref lower);
                    Console.WriteLine("Hay " + upper + " Mayusculas y " + lower + " Minusculas");
                } else 
                {
                    errorCode = 2;
                }
                break;
            case "para":
                if (args.Length == 3)
                {
                    char caracter = '#';
                    DrawParallelogram(Convert.ToByte(args[1]), Convert.ToByte(args[2]), caracter);
                } else 
                {
                    errorCode = 2;
                }
                break;
            case "mcd":
                if (args.Length == 3)
                {
                    Console.WriteLine(mcd(Convert.ToInt32(args[1]), Convert.ToInt32(args[2])));
                } else 
                {
                    errorCode = 2;
                }
                break;
            default:
                Console.WriteLine("Uso: cprime / mm / para / mcd");
                errorCode = 1;
                break;
        }
        
    }
}
