// Cristina Francés

using System;
using System.IO;

class EncriptarGIF
{
    static void Main()
    {
        Console.Write("Nombre fichero entrada: ");
        string nom = Console.ReadLine();
        
        
        if (!File.Exists(nom))
            Console.WriteLine("El fichero no existe");
        else
        {
            try 
            {
                FileStream datos = File.Open(nom, FileMode.Open, 
                    FileAccess.ReadWrite);
                    
                byte cab1 = (byte)datos.ReadByte();
                byte cab2 = (byte)datos.ReadByte();
                byte cab3 = (byte)datos.ReadByte();
                
                datos.Seek(0, SeekOrigin.Begin);

                datos.WriteByte(cab3);
                datos.WriteByte(cab2);
                datos.WriteByte(cab1);
                
                datos.Close();
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Demasiado largo");
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error inesperado" + e.Message);
            }
        }
    }
}
