// Pablo Conde

/*Create a program that asks the user for their name,
the width and height and displays a rectangle
of that size, using that name, like this:

Enter your name: Nacho
Height: 4
Width: 4

NachoNachoNachoNacho
Nacho          Nacho
Nacho          Nacho
NachoNachoNachoNacho*/

using System;

class RectanguloNombre
{
    static void Main()
    {
        int width, height;
        string name;
        
        Console.Write("Enter your name: ");
        name = Console.ReadLine();
        Console.Write("Height: ");
        height = Convert.ToInt32(Console.ReadLine());
        Console.Write("Width: ");
        width = Convert.ToInt32(Console.ReadLine());
        
        DisplayRectangle(width, height, name);
    }
    
    static void DisplayRectangle (int width, int height, string name)
    {
        string blanks = new string(' ', name.Length);
        Console.WriteLine();
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if(i == 0 || i == height - 1 || j == 0 || j == width - 1)
                    Console.Write(name);
                else
                    Console.Write(blanks);
            }
            Console.WriteLine();
        }
    }
}
