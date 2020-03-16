//Pablo Conde

using System;
using System.IO;

class MiMp3
{
    static void Main()
    {
        Console.Write("File? ");
        string name = Console.ReadLine();
        
        if(!File.Exists(name))
            Console.WriteLine("File doesn't exist");
        
        else
        {
            FileStream  input = File.OpenRead(name);
            int size = (int) input.Length;
            byte[] data = new byte[size];
            
            int readedAmount = input.Read(data, 0, size);
            
            if(readedAmount < size)
               Console.WriteLine("Error!!!");
            
            input.Close();
            
            for (long i = data.Length-128; i < data.Length; i++)
            {
                byte d = (byte) data[i];
                if(i == (data.Length-128 + 3))
                {
                    Console.WriteLine();
                    Console.Write("Titulo: ");
                }
                
                if(i == (data.Length-128 + 3 + 30))
                {
                    Console.Write("\nArtista: ");
                }
                
                if(i == (data.Length-128 + 3 + 30 + 30))
                {
                    Console.Write("\nÁlbum: ");
                }
                
                if(i == (data.Length-128 + 3 + 30 + 30 + 30))
                {
                    Console.Write("\nAño: ");
                }
                
                if(i == (data.Length-128 + 3 + 30 + 30 + 30 + 4))
                {
                    Console.Write("\nComentario: ");
                }
                if(i == (data.Length-128 + 3 + 30 + 30 + 30 + 4 + 30))
                {
                    Console.Write("\nGénero: ");
                }
      
                if(i != data.Length - 1)
                    Console.Write((char) d);
                
                else
                    Console.Write((byte) d);
            }
        }
    }
}
