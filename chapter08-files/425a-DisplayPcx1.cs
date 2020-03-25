//Daniel Contreras

using System;
using System.IO;

class Ejercicio425
{
    public static void Main(string[] args)
    {
        Console.Write("Nombre fichero: ");
        string nomFic = Console.ReadLine();

        if (!File.Exists(nomFic))
        {
            Console.WriteLine("Fichero no existe.");
        }
        else
        {
            try
            {
                BinaryReader imagenPcx = new BinaryReader(
                        File.Open("img-pcx.pcx", FileMode.Open));
                byte marca = imagenPcx.ReadByte();
                if (marca != 10)
                {
                    Console.WriteLine("No es un fichero PCX.");
                    return;
                }
                imagenPcx.BaseStream.Seek(4, SeekOrigin.Begin);
                short xMin = imagenPcx.ReadInt16();
                short yMin = imagenPcx.ReadInt16();
                short xMax = imagenPcx.ReadInt16();
                short yMax = imagenPcx.ReadInt16();

                int ancho = xMax - xMin + 1;
                int alto = yMax - yMin + 1;

                string datosImagen = "";
                imagenPcx.BaseStream.Seek(128, SeekOrigin.Begin);
                while (imagenPcx.BaseStream.Position < imagenPcx.BaseStream.Length - 1)
                {
                    byte dato = imagenPcx.ReadByte();
                    if (dato < 192)
                    {
                        datosImagen += PixelADibujar(dato);
                    }
                    else
                    {
                        byte repeticiones = (byte)(dato - 192);
                        dato = imagenPcx.ReadByte();
                        for (int r = 0; r < repeticiones; r++)
                        {
                            datosImagen += PixelADibujar(dato);
                        }
                    }
                }

                imagenPcx.Close();

                int posicionActual = 0;
                for (int fila = 0; fila < alto; fila++)
                {
                    for (int columna = 0; columna < ancho; columna++)
                    {
                        Console.Write(datosImagen[posicionActual]);
                        posicionActual++;
                    }
                    Console.WriteLine();
                }
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path too long ");
            }
            catch (IOException)
            {
                Console.WriteLine("IO Error.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }

    private static char PixelADibujar(byte dato)
    {
        if (dato > 200)
        {
            return ' ';
        }
        else if (dato > 150)
        {
            return('.');
        }
        else if (dato > 100)
        {
            return 'i';
        }
        else if (dato > 50)
        {
            return 'n';
        }
        else
        {
            return '#';
        }
    }
}
