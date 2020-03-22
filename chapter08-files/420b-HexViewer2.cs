//Kiko
using System;
using System.IO;

class ByteToHexa
{
    static void Main(string [] args)
    {
        string path;        
        if(args.Length > 0)
        {
            path = args[0];
            try
            {
                if (!File.Exists(path))
                {
                    Console.WriteLine("Path does not exists.");
                }
                else
                {
                    FileStream data = new FileStream(path, FileMode.Open);
                    int dataToRead = 16;
                    byte[] dataReaded = new byte[dataToRead];
                    int dataRead = 0;
                    bool end = false;

                    while (!end)
                    {
                        //Leo linea a linea.
                        dataRead = data.Read(dataReaded, 0, dataToRead);
                        //Inicializo dos lineas donde almacenare los valores.
                        string dataInHexa = "";
                        string dataInAscii = "";
                        //Recorro byte a byte del bloque de 16
                        for (int i = 0; i < dataRead; i++)
                        {
                            //Si el valor de este es mayor de 32 lo guardo.
                            if (dataReaded[i] > 32)
                            {
                                dataInHexa += (Convert.
                                    ToString(dataReaded[i], 16) + " ");
                                dataInAscii += Convert.
                                   ToChar(dataReaded[i]);
                            }                            
                            //En caso contrario será un punto y 
                            //ademas compruebo la longitud y corrijo.
                            else
                            {
                                string actualData = Convert.
                                    ToString(dataReaded[i], 16);
                                if (actualData.Length == 1)
                                    actualData = "0" + actualData;

                                dataInHexa += actualData + " ";
                                dataInAscii += ".";
                            }
                        }
                        //Compruebo el tamaño de la frase en hexadecimal. 
                        string spaces = new string(' ', 48 - dataInHexa.Length);
                        dataInHexa += spaces;
                        Console.Write(dataInHexa);
                        Console.Write(dataInAscii);

                        if (dataRead != dataToRead)
                        {
                            end = true;
                        }                   
                        Console.WriteLine();
                    }
                    data.Close();
                }
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("path too long");
            }
            catch (IOException)
            {
                Console.WriteLine("I/O error");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
        else 
        {
            Console.WriteLine("Path is necessary.");
        }
    }
}

