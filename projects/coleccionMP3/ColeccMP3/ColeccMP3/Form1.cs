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

    }
}
