// Cristina Francés

using System;
using System.IO;

class VisorHexa
{
    static void Main(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine("Debe introducir un argumento");
        }
        else
        {
            if (!File.Exists(args[0]))
                Console.WriteLine("El fichero no existe");
            else
            {
                FileStream fichero = File.OpenRead(args[0]);
                int cantidadBloques = (int) (fichero.Length / 16);
                if (fichero.Length % 16 != 0)
                    cantidadBloques ++;
                    
                byte[] bloque = new byte[16];
                
                for (int j = 0; j < cantidadBloques; j++)
                {
                    int datosBloque = fichero.Read(bloque,0,16);
                    string datos = "";
                    
                    for(int i = 0 ; i < datosBloque; i++)//Parte Hexadecimal
                    {
                        datos += bloque[i].ToString("X2");
                        datos += " ";
                    }
                    if ( datosBloque != 16 )
                    {
                        int caracFalta = 16-datosBloque;
                        
                        while (caracFalta > 0 )
                        {
                            datos += "   ";
                            caracFalta--;
                        }
                    }  
                    for(int i = 0 ; i < datosBloque; i++)//Parte Caracteres
                    {
                        if (bloque[i] < 32)
                            datos += ".";
                        else
                            datos += (char)bloque[i];
                    }
                    Console.WriteLine(datos);
                    
                }
                fichero.Close();
            }
        }
    }
}
