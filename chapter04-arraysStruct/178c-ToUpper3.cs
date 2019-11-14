using System;

class TriangleOfName3
{
    static void Main()
    {
        Console.Write("Text: ");
        string name = Console.ReadLine();

        string fragment = "";
        for (int i = 0; i < name.Length; i++)
        {
            fragment += name[i].ToString().ToUpper();
            Console.WriteLine(fragment);
        }

        fragment = "";
        for (int i = 0; i < name.Length; i++)
        {
            fragment += (""+name[i]).ToUpper();
            Console.WriteLine(fragment);
        }

        fragment = "";
        for (int i = 0; i < name.Length; i++)
        {
            fragment += Char.ToUpper(name[i]);
            Console.WriteLine(fragment);
        }
    }
}
