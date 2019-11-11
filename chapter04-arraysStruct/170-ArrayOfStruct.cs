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
        const int MAX = 3;
        person[] persons = new person[MAX];
        
        // Getting the data
        for (int i = 0; i < MAX; i++)
        {
            Console.Write("Name of the person #{0}: ", i+1);
            persons[i].name = Console.ReadLine();
            Console.Write("Age of the person #{0}: ", i+2);
            persons[i].age = Convert.ToByte(Console.ReadLine());
        }
        
        // Displaying the data
        Console.WriteLine("You entered:");
        for (int i = 0; i < MAX; i++)
        {
            Console.WriteLine(persons[i].name);
            Console.WriteLine(persons[i].age);
        }
        
        // Alternate way to display the data
        foreach(person p in persons)
        {
            Console.WriteLine(p.name);
            Console.WriteLine(p.age);
        }        
    }    
}
