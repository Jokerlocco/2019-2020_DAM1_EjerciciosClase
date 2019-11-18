// Daniel García

using System;
using System.Text;

class PacoPoco
{
    static void Main()
    {
        string name = "Paco";
        //name[1] = 'o';

        string name2 = name.Remove(1, 1);
        name2 = name2.Insert(1, "o");
        Console.WriteLine(name2);

        string name2b = name.Remove(1, 1).Insert(1, "o");
        Console.WriteLine(name2b);

        string name3 = 
            name.Substring(0, 1)
            + 'o'
            + name.Substring(2);
        Console.WriteLine(name3);

        char[] letters = name.ToCharArray();
        letters[1] = 'o';
        Console.WriteLine(new string(letters));

        // ----

        StringBuilder name4 = new StringBuilder(name);
        name4[1] = 'o';
        Console.WriteLine(name4);

        // !!!
        Console.WriteLine( name4.ToString().ToUpper() );
    }
}
