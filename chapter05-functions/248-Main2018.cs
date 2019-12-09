//Abraham García - FuncionesMainAgain

using System;

class Funcionesmain
{
    static bool EsHappyNumber(ulong n)
    {
        ulong total = 0;
        string num = n.ToString();
        
        do
        {
            for (int i = 0; i < num.Length; i++)
            {
                total = (Convert.ToUInt64(num[i]-'0')*
                    Convert.ToUInt64(num[i]-'0'));
                num = total.ToString();
            }
        } while (total != 0);

        return true;
    }
    
    
    static void ContarAlfaEsp(string s, out int car, out int sp)
    {
       car = 0;
       sp = 0;
       s = s.ToUpper();
       
       foreach(char c in s)
       {
           if (c >= 'A' && c <= 'Z')
            car++;
            
            if ( c == ' ')
                sp++;
       }
    }
    
    
    static void DibujarRombo(int an, char c)
    {
       int alt = 1;
       int sp = an/2;
       
       for (int i = 0; i < an; i++)
       {
            for (int j = 0; j < sp; j++)
                Console.Write(" ");
            
            for (int j = 0; j < alt; j++)
                Console.Write(c);
                
            if (i >= an/2)
            {
                sp++;
                alt -= 2;
            }
            else
            {
                sp--;
                alt += 2;
            }
            Console.WriteLine();
       }
       
        if (an % 2 == 0)
        {
            for (int i = 0; i < sp; i++)
                Console.Write(" ");
            Console.Write(c);
        }
    }
    
    
    static bool BinSearch(int[] data, int num, int left, int right)
    {
        bool found = false;
        while (left <= right && !found)
        {
            int middle = left + (right - left) / 2;
            if (data[middle] == num)
                found = true;
            else if (data[middle] < num)
                left = middle + 1;
            else
                right = middle - 1;
        }
        return found;
    }
    
    
    static int Main(string[] args)
    {
        int error = 0;
        int[] datos = {10, 20, 30, 40, 50, 60, 70};
        
        if (args.Length == 0)
        {
            error = 2;
            Console.WriteLine("Uso: happy / contar / rombo / binsearch");
        }
        
        switch (args[0])
        {
            case "happy":
                if (args.Length != 2)
                {
                    error = 1;
                    Console.WriteLine("Faltan detalles");
                }
                else
                {
                    bool esHappy = EsHappyNumber(Convert.ToUInt64(args[1]));
                    if (esHappy)
                        Console.WriteLine("Es un número feliz");
                    else
                        Console.WriteLine("No es un número feliz");
                }
                break;
                
            case "contar":
                if (args.Length != 4)
                {
                    error = 1;
                    Console.WriteLine("Faltan detalles");
                }
                else
                {
                   int n1 = Convert.ToInt32(args[2]); 
                   int n2 = Convert.ToInt32(args[3]); 
                   ContarAlfaEsp(args[1], out n1, out n2);
                   Console.WriteLine("Alfabéticos: "+n1+
                        ", espacios: "+n2);
                }
                break;
                
            case "rombo":
                if (args.Length != 3)
                {
                    error = 1;
                    Console.WriteLine("Faltan detalles");
                }
                else
                {
                    DibujarRombo(Convert.ToInt32(args[1]), 'X');
                }
                break;
                
            case "binsearch":
                if (args.Length != 2)
                {
                    error = 1;
                    Console.WriteLine("Faltan detalles");
                }
                else
                {
                    if (BinSearch(datos, Convert.ToInt32(args[1]),
                        0, datos.Length-1))
                        Console.WriteLine("Está en el array");
                    else
                        Console.WriteLine("No está en el array");
                }
                break;
                
            default:
                error = 2;
                Console.WriteLine("Uso: happy / contar / rombo / binsearch");
                break;
        }
        
    return error;
    }
}
       
       
