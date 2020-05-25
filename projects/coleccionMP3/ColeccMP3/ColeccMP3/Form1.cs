using System;
using System.Collections.Generic;
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

                datos.Incluir(l);
                RefrescarGrid(datos.Datos);
                datos.Guardar();
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


        private void vistaDetalladaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formVisualizar.ShowDialog();
            RefrescarGrid(datos.Datos);
        }

    }
}
