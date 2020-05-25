using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColeccMP3
{
    public partial class FormEditar : Form
    {
        public string Titulo
        {
            get { return tbTitulo.Text; }
            set { tbTitulo.Text = value; }
        }

        public string Artista
        {
            get { return tbArtista.Text; }
            set { tbArtista.Text = value; }
        }

        public string Fichero

        {
            get { return tbFichero.Text; }
            set { tbFichero.Text = value; }
        }

        public string Categoria
        {
            get { return tbCategoria.Text; }
            set { tbCategoria.Text = value; }
        }

        public string Ubicacion
        {
            get { return tbUbicacion.Text; }
            set { tbUbicacion.Text = value; }
        }

        public string Fecha
        {
            get { return tbFecha.Text; }
            set { tbFecha.Text = value; }
        }

        public string TamanyoKB
        {
            get { return tbTamanyoKB.Text; }
            set { tbTamanyoKB.Text = value; }
        }


        public FormEditar()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            Titulo = Artista = Fichero = Categoria 
                = Ubicacion = TamanyoKB = Fecha = "";
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
