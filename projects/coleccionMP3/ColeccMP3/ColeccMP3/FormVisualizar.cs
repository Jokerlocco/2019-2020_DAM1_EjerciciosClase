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
    public partial class FormVisualizar : Form
    {
        int fichaActual;
        ListaMP3 datos;

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

        public FormVisualizar()
        {
            InitializeComponent();
            datos = new ListaMP3();
            fichaActual = 0;
        }

        public void Limpiar()
        {
            Titulo = Artista = Fichero = Categoria
                = Ubicacion = TamanyoKB = Fecha = "";
        }

        private void FormVisualizar_Activated(object sender, EventArgs e)
        {
            datos.Cargar();
            Refrescar();
        }

        private void Refrescar()
        {
            Limpiar();
            if (fichaActual <= datos.Cantidad - 1)
            {
                Titulo = datos.Get(fichaActual).Titulo;
                Artista = datos.Get(fichaActual).Artista;
                Fichero = datos.Get(fichaActual).Fichero;
                Categoria = datos.Get(fichaActual).Categoria;
                Ubicacion = datos.Get(fichaActual).Ubicacion;
                Fecha = datos.Get(fichaActual).Fecha.ToString();
                TamanyoKB = datos.Get(fichaActual).TamanyoKB.ToString();
                toolStripStatusLabel1.Text = "Ficha " +
                    (fichaActual + 1) + " de " + datos.Cantidad;
            }
        }

        private void btPrimero_Click(object sender, EventArgs e)
        {
            fichaActual = 0;
            Refrescar();
        }

        private void btAnterior_Click(object sender, EventArgs e)
        {
            if (fichaActual > 0)
                fichaActual--;
            Refrescar();
        }

        private void btPosterior_Click(object sender, EventArgs e)
        {
            if (fichaActual < datos.Cantidad - 1)
                fichaActual++;
            Refrescar();
        }

        private void btUltimo_Click(object sender, EventArgs e)
        {
            fichaActual = datos.Cantidad - 1;
            Refrescar();
        }

        private void btNumero_Click(object sender, EventArgs e)
        {

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btAnadir_Click(object sender, EventArgs e)
        {

        }

        private void btEditar_Click(object sender, EventArgs e)
        {

        }

        private void btBorrar_Click(object sender, EventArgs e)
        {

        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
