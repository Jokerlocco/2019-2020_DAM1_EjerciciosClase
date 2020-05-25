using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ColeccMP3
{
    public class ListaMP3
    {
        List<MP3> lista;
        public int Cantidad { get { return lista.Count; } }

        public List<MP3> Datos { get { return lista; } }

        public ListaMP3()
        {
            Cargar();
        }

        public MP3 Get(int n)
        {
            return lista[n];
        }

        public void Incluir(MP3 l)
        {
            lista.Add(l);
            lista.Sort();
            Guardar();
        }

        public void Modificar(MP3 l, int posicion)
        {
            lista[posicion] = l;
            lista.Sort();
            Guardar();
        }

        public void Borrar(int n)
        {
            lista.RemoveAt(n);
            Guardar();
        }

        // Forma alternativa de ordenar, no usado en este momento
        public void Ordenar()
        {
            lista.Sort((x, y) => x.Titulo.CompareTo(y.Titulo));
        }

        public int Cargar()
        {
            lista = new List<MP3>();

            if (!File.Exists("mp3.xml"))
            {
                return 1;
            }

            try
            {
                XmlSerializer formatter = new XmlSerializer(lista.GetType());
                Stream stream = new FileStream("mp3.xml",
                    FileMode.Open, FileAccess.Read, FileShare.Read);
                lista = (List<MP3>)formatter.Deserialize(stream);
                stream.Close();
            }
            catch (IOException)
            {
                // Console.WriteLine("Error de lectura");
                return 2;
            }
            catch (Exception)
            {
                // Console.WriteLine("Error: " + e.Message);
                return 3;
            }
            return 0;
        }

        public int Guardar()
        {
            try
            {
                XmlSerializer formatter = new XmlSerializer(lista.GetType());
                FileStream stream = new FileStream("mp3.xml", FileMode.Create,
                        FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, lista);
                stream.Close();
            }
            catch (IOException)
            {
                // Console.WriteLine("Error de escritura");
                return 1;
            }
            catch (Exception)
            {
                // Console.WriteLine("Error: " + e.Message);
                return 2;
            }
            return 0;
        }
    }
}
