// Pablo Conde
// Turn blanks into "_"

using System;
using System.Text;

class StringBuilderExample2
{
    static void Main()
    {
       string text;
       Console.Write("Enter some text: ");
       text = Console.ReadLine();
       
       // Using "Replace"
       string text2 = text.Replace(" ","_");
       Console.WriteLine(text2);
       
       // Using "StringBuilder"
       StringBuilder text3 = new StringBuilder(text);
       for (int i = 0; i < text3.Length; i++)
       {
            if(text3[i] == ' ')
                text3[i] = '_';
       }
       Console.WriteLine(text3);
    }
}
