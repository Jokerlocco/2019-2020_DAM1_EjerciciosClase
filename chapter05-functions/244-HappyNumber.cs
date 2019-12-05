//Pablo Conde
//Número Feliz

using System;

class NumeroFeliz
{
    static void Main()
    {
        if ( IsHappyNumber(19) )
            Console.WriteLine("Working for 19...");
        else
            Console.WriteLine("Not working for 19");
            
        if ( ! IsHappyNumber(22) )
            Console.WriteLine("Working for 22...");
        else
            Console.WriteLine("Not working for 22");
    } 

    
    static bool IsHappyNumber( long numero)
    {
        long suma = 0;
        
        while (suma != 1 && suma !=4)
        {
            string numeroString = numero.ToString();
            long size = numeroString.Length;
            suma = 0;
            
            for (int i = 0; i < size; i++)
            {
                suma += Convert.ToInt64(numeroString[i]-'0')
                    * Convert.ToInt64(numeroString[i]-'0'); 
            }
            if (suma == 1)
                return true;
            
            if (suma == 4)
                return false;
            
            numero = suma;
        }
        // Just to avoid the compiler warning...
        return true;
 
    }
   
}
