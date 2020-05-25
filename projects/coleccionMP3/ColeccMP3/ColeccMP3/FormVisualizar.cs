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
        FormEditar formEditar;

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
            formEditar = new FormEditar();
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
            if (datos.Cantidad > 0)
                fichaActual = datos.Cantidad - 1;
            Refrescar();
        }

        private void btNumero_Click(object sender, EventArgs e)
        {
            string numeroStr = Microsoft.VisualBasic.Interaction.InputBox(
                "¿Número de ficha?", "Ir a", "1");
            try
            {
                int numero = Convert.ToInt32(numeroStr);
                if ((numero > 0) && (numero <= datos.Cantidad))
                {
                    fichaActual = numero - 1;
                    Refrescar();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Número no válido");
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            int fichaDePartida = fichaActual;
            bool encontrado = false;
            string textoBusqueda = Microsoft.VisualBasic.Interaction.InputBox(
                "¿Texto a buscar?", "Buscar", "");

            while ((fichaActual < datos.Cantidad) && (!encontrado))
            {
                if (datos.Get(fichaActual).Contiene(textoBusqueda))
                    encontrado = true;
                else
                    fichaActual++;
            }
            if (!encontrado)
            {
                fichaActual = fichaDePartida;
                MessageBox.Show("No encontrado");
            }
            Refrescar();
        }

        private void btAnadir_Click(object sender, EventArgs e)
        {
            Anadir(datos);
            Refrescar();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            Modificar(datos, fichaActual);
            Refrescar();
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea borrar esta ficha?", "Borrar",
                MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                datos.Borrar(fichaActual);
                if (fichaActual >= datos.Cantidad)
                    fichaActual = datos.Cantidad - 1;
                Refrescar();
                MessageBox.Show("Borrado");
            }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Anadir(ListaMP3 datos)
        {
            formEditar.Limpiar();
            formEditar.Text = "Modificar";
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

                Cursor = Cursors.WaitCursor;
                datos.Incluir(l);
                datos.Guardar();
                Cursor = Cursors.Default;
            }
        }

        public void Modificar(ListaMP3 datos, int n)
        {
            formEditar.Artista = datos.Get(n).Artista;
            formEditar.Titulo = datos.Get(n).Titulo;
            formEditar.Fichero = datos.Get(n).Fichero;
            formEditar.Categoria = datos.Get(n).Categoria;
            formEditar.Ubicacion = datos.Get(n).Ubicacion;
            formEditar.TamanyoKB = datos.Get(n).TamanyoKB.ToString();
            formEditar.Fecha = datos.Get(n).Fecha.ToString();
            formEditar.Text = "Editar";

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

                Cursor = Cursors.WaitCursor;
                datos.Modificar(l, n);
                datos.Guardar();
                Cursor = Cursors.Default;
            }
        }
    }
}
