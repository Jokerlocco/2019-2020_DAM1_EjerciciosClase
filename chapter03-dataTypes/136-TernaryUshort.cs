//Francisco Jiménez Velasco

using System;

class TernaryUshort
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        ushort n1 = Convert.ToUInt16(Console.ReadLine());
        Console.Write("Enter another number: ");
        ushort n2 = Convert.ToUInt16(Console.ReadLine());
        Console.Write("Enter another number: ");
        ushort n3 = Convert.ToUInt16(Console.ReadLine());
        
        ushort smallest;
        
        if ((n1 <= n2)&&(n1<= n3))
            smallest=n1;
        else if(n2 < n3)
            smallest=n2;
        else 
            smallest=n3;
        
        smallest = n1<= n2 && n1 <=n3 ? n1 :
                n2 < n3 ? n2:
                n3;
                
        Console.Write(smallest);
    }
}
        
        
