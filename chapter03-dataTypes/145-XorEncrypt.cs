using System;

class XorEncrypt
{
    static void Main()
    {
        Console.Write("Enter some text: ");
        string text = Console.ReadLine();

        foreach (char c in text)
        {
            char encrypted = (char)(c ^ 1);
            Console.Write( encrypted );
            char decrypted = (char)(encrypted ^ 1);
            Console.WriteLine( decrypted );
        }
    }
}
