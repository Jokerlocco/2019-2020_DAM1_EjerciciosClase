using System;
using System.IO;

class Mp3Header
{
    static void Main()
    {
        FileStream fichero = new FileStream("mp3.mp3", FileMode.Open);
        int tamanyoCabecera = 128;
        byte[] cabecera = new byte[tamanyoCabecera];
        fichero.Seek(-128, SeekOrigin.End);
        fichero.Read(cabecera, 0, 128);
        fichero.Close();

        string tag = "" + (char) cabecera[0] +
            (char)cabecera[1] + (char)cabecera[2];
        if (tag != "TAG")
        {
            Console.WriteLine("No es un MP3 con cabecera ID3 V1");
        }
        else
        {
            string titulo = "";
            for (int i = 3; i < 33; i++)
            {
                titulo += (char) cabecera[i];
            }
            Console.WriteLine(titulo);

            string artista = "";
            for (int i = 33; i < 63; i++)
            {
                artista += (char) cabecera[i];
            }
            Console.WriteLine(artista);
        }
    }
}
