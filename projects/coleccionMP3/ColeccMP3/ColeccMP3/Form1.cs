using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ColeccMP3
{
    public partial class Form1 : Form
    {
        FormEditar formEditar;
        List<MP3> datos;

        public Form1()
        {
            InitializeComponent();
            formEditar = new FormEditar();
            datos = Cargar();
            RefrescarGrid(datos);
        }

        private List<MP3> Cargar()
        {
            List<MP3> datos = new List<MP3>();

            if (!File.Exists("mp3.xml"))
            {
                return datos;
            }

            try
            {
                XmlSerializer formatter = new XmlSerializer(datos.GetType());
                Stream stream = new FileStream("mp3.xml",
                    FileMode.Open, FileAccess.Read, FileShare.Read);
                datos = (List<MP3>)formatter.Deserialize(stream);
                stream.Close();
                return datos;
            }
            catch (IOException)
            {
                Console.WriteLine("Error de lectura");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            return datos;
        }

        private static void Guardar(List<MP3> datos)
        {
            try
            {
                XmlSerializer formatter = new XmlSerializer(datos.GetType());
                FileStream stream = new FileStream("mp3.xml", FileMode.Create,
                        FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, datos);
                stream.Close();
            }
            catch (IOException)
            {
                Console.WriteLine("Error de escritura");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        private void RefrescarGrid(List<MP3> datos)
        {
            dataGridView1.DataSource = typeof(MP3);
            dataGridView1.DataSource = datos;
        }

        private void btNuevoRegistro_Click(object sender, EventArgs e)
        {
            formEditar.Limpiar();
            DialogResult resultadoEdicion = formEditar.ShowDialog();
            if (resultadoEdicion != DialogResult.Cancel)
            {
                MP3 l = new MP3();
                l.Artista = formEditar.Artista;
                l.Titulo = formEditar.Titulo;
                l.Fichero = formEditar.Fichero;
                l.Categoria = formEditar.Categoria;
                l.Ubicacion = formEditar.Ubicacion;
                try
                {
                    l.TamanyoKB = Convert.ToInt32(formEditar.TamanyoKB);
                }
                catch (Exception)
                {
                    l.TamanyoKB = 0;
                }
                try
                {
                    l.Fecha = Convert.ToDateTime(formEditar.Fecha);
                }
                catch (Exception)
                {
                    l.Fecha = DateTime.Today;
                }

                datos.Add(l);
                RefrescarGrid(datos);
                Guardar(datos);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Acerca de...", "ColeccMP3, por Nacho");
        }
    }
}
