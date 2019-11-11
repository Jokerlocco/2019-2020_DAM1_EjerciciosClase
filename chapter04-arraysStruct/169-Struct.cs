// Daniel García - "struct" example

using System;

class StructExample
{
    struct person
    {
        public string name;
        public byte age;
    }
        
    static void Main()
    {
        person p1, p2;
        
        Console.Write("Name of the first person: ");
        p1.name = Console.ReadLine();
        Console.Write("Age of the first person: ");
        p1.age = Convert.ToByte(Console.ReadLine());
        
        Console.Write("Name of the second person: ");
        p2.name =  Console.ReadLine();
        Console.Write("Age of the second person: ");
        p2.age = Convert.ToByte(Console.ReadLine());
        
        Console.WriteLine("You entered:");
        Console.WriteLine(p1.name);
        Console.WriteLine(p1.age);
        Console.WriteLine(p2.name);
        Console.WriteLine(p2.age);
    }    
}
