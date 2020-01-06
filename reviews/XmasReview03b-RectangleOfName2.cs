//Pablo Jose Ferrándiz Navarro

/*Crea un programa que pida al usuario su nombre, la anchura y la altura y 
escriba un rectángulo con ese tamaño formado por su nombre*/

using System;

class Ej03a
{
    static void Main()
    {
        string name;
        int rows;
        int colums;
        
        Console.Write("Enter your name: ");
        name = Convert.ToString(Console.ReadLine());
        
        Console.Write("How many rows?: ");
        rows = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("How many colums?: ");
        colums = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 0; i < rows; i++)
            Console.Write(name);
            
        Console.WriteLine();
        
        for(int i = 0; i < colums-2 ; i++)
        {
            Console.Write(name);
            
            for(int j = 0; j < (name.Length*(rows-2)); j++)
                Console.Write("_");
                
            Console.Write(name);
            Console.WriteLine();
        }
        
        for(int i = 0; i < rows; i++)
            Console.Write(name);
    }
}
