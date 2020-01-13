// Create a new version of the exercise 170 
// (array of struct Person), using classes
// instead of structs

using System;

class Person
{
    private string name;
    private byte age;

    public string GetName() { return name; }
    public byte GetAge() { return age; }

    public void SetName(string name) { this.name = name;  }
    public void SetAge(byte age) { this.age = age; }

}

class ArrayOfClassPerson
{
    static void Main()
    {
        const int MAX = 3;
        Person[] persons = new Person[MAX];

        // Getting the data
        for (int i = 0; i < MAX; i++)
        {
            persons[i] = new Person();
            Console.Write("Name of the person #{0}: ", i + 1);
            persons[i].SetName( Console.ReadLine() );
            Console.Write("Age of the person #{0}: ", i + 1);
            persons[i].SetAge( Convert.ToByte(Console.ReadLine()) );
        }

        // Displaying the data
        Console.WriteLine("You entered:");
        for (int i = 0; i < MAX; i++)
        {
            Console.WriteLine(persons[i].GetName());
            Console.WriteLine(persons[i].GetAge());
        }

        // Alternate way to display the data
        foreach (Person p in persons)
        {
            Console.WriteLine(p.GetName());
            Console.WriteLine(p.GetAge());
        }
    }
}
