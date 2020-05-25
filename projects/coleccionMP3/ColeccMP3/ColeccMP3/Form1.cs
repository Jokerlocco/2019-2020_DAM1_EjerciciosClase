using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ColeccMP3
{
    public partial class Form1 : Form
    {
        FormEditar formEditar;
        FormVisualizar formVisualizar;
        ListaMP3 datos;

        public Form1()
        {
            InitializeComponent();
            formEditar = new FormEditar();
            formVisualizar = new FormVisualizar();
            datos = new ListaMP3();
            RefrescarGrid(datos.Datos);
        }

        private void RefrescarGrid(List<MP3> datos)
        {
            dataGridView1.DataSource = typeof(MP3);
            dataGridView1.DataSource = datos;
        }

        private void btNuevoRegistro_Click(object sender, EventArgs e)
        {
            formVisualizar.Anadir(datos);
            RefrescarGrid(datos.Datos);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Acerca de...", "ColeccMP3, por Nacho");      
        }


        private void vistaDetalladaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formVisualizar.ShowDialog();
            datos.Cargar();
            RefrescarGrid(datos.Datos);
        }

        private void importarDesdeCarpetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = folderBrowserDialog1.ShowDialog();
            if (respuesta != DialogResult.Cancel)
            {
                string carpeta = folderBrowserDialog1.SelectedPath;
                tomarFicherosDeCarpeta(carpeta, datos);
            }
        }

        private void tomarFicherosDeCarpeta(string carpeta, ListaMP3 datos)
        {
            DirectoryInfo directorio = new DirectoryInfo(carpeta);
            FileInfo[] listaFicheros = directorio.GetFiles(".");
            foreach (FileInfo info in listaFicheros)
            {
                if (info.Extension == ".mp3")
                {
                    try
                    {
                        datos.Incluir(new MP3
                        {
                            Fichero = info.Name,
                            Ubicacion = info.DirectoryName,
                            TamanyoKB = (int)(info.Length / 1024),
                            Artista = info.Name.Split('-')[0].Trim(),
                            Titulo = info.Name.Split('-')[1].
                                Replace(".mp3","").Trim(),
                        });
                    }
                    catch (Exception)
                    {
                        // Ignorar fichero si no tiene el formato esperado
                    }
                }
            }

            foreach (string dir in Directory.GetDirectories(carpeta))
            {
                tomarFicherosDeCarpeta(dir, datos);
            }
        }
    }
}
