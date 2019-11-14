using System;

class StructExample
{
    struct birthday
    {
        public byte day;
        public byte month;
        public ushort year;
    }
    
    struct person
    {
        public string name;
        public birthday bday;
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
            Console.Write("Day of birth (1-31) of the person #{0}: ", i+1);
            persons[i].bday.day = Convert.ToByte(Console.ReadLine());
            Console.Write("Month of birth (1-31) of the person #{0}: ", i+1);
            persons[i].bday.month = Convert.ToByte(Console.ReadLine());
            Console.Write("Year of birth (1-31) of the person #{0}: ", i+1);
            persons[i].bday.year = Convert.ToUInt16(Console.ReadLine());
        }
        
        // Displaying the data
        Console.WriteLine("You entered:");
        for (int i = 0; i < MAX; i++)
        {
            Console.WriteLine(persons[i].name);
            Console.WriteLine(persons[i].bday.day + "/" + 
                persons[i].bday.month + "/" + persons[i].bday.year);
        }
        
        // Alternate way to display the data
        foreach(person p in persons)
        {
            Console.WriteLine(p.name);
            Console.WriteLine(p.bday.day + "/" + 
                p.bday.month + "/" + p.bday.year);
        }        
    }    
}
