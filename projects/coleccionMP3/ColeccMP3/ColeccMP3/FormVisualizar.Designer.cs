namespace ColeccMP3
{
    partial class FormVisualizar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVisualizar));
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.tbFecha = new System.Windows.Forms.TextBox();
            this.lbFecha = new System.Windows.Forms.Label();
            this.tbTamanyoKB = new System.Windows.Forms.TextBox();
            this.lbTamanyoKB = new System.Windows.Forms.Label();
            this.tbUbicacion = new System.Windows.Forms.TextBox();
            this.lbUbicacion = new System.Windows.Forms.Label();
            this.tbCategoria = new System.Windows.Forms.TextBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.tbFichero = new System.Windows.Forms.TextBox();
            this.lbFichero = new System.Windows.Forms.Label();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.tbArtista = new System.Windows.Forms.TextBox();
            this.lbArtista = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btPrimero = new System.Windows.Forms.ToolStripButton();
            this.btAnterior = new System.Windows.Forms.ToolStripButton();
            this.btPosterior = new System.Windows.Forms.ToolStripButton();
            this.btUltimo = new System.Windows.Forms.ToolStripButton();
            this.btNumero = new System.Windows.Forms.ToolStripButton();
            this.btBuscar = new System.Windows.Forms.ToolStripButton();
            this.btAnadir = new System.Windows.Forms.ToolStripButton();
            this.btEditar = new System.Windows.Forms.ToolStripButton();
            this.btBorrar = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(326, 277);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(100, 28);
            this.btCancelar.TabIndex = 39;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAceptar.Location = new System.Drawing.Point(208, 278);
            this.btAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(100, 28);
            this.btAceptar.TabIndex = 38;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // tbFecha
            // 
            this.tbFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFecha.Location = new System.Drawing.Point(137, 237);
            this.tbFecha.Margin = new System.Windows.Forms.Padding(4);
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.ReadOnly = true;
            this.tbFecha.Size = new System.Drawing.Size(289, 22);
            this.tbFecha.TabIndex = 37;
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(37, 237);
            this.lbFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(47, 17);
            this.lbFecha.TabIndex = 36;
            this.lbFecha.Text = "Fecha";
            // 
            // tbTamanyoKB
            // 
            this.tbTamanyoKB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTamanyoKB.Location = new System.Drawing.Point(137, 205);
            this.tbTamanyoKB.Margin = new System.Windows.Forms.Padding(4);
            this.tbTamanyoKB.Name = "tbTamanyoKB";
            this.tbTamanyoKB.ReadOnly = true;
            this.tbTamanyoKB.Size = new System.Drawing.Size(289, 22);
            this.tbTamanyoKB.TabIndex = 35;
            // 
            // lbTamanyoKB
            // 
            this.lbTamanyoKB.AutoSize = true;
            this.lbTamanyoKB.Location = new System.Drawing.Point(37, 205);
            this.lbTamanyoKB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTamanyoKB.Name = "lbTamanyoKB";
            this.lbTamanyoKB.Size = new System.Drawing.Size(92, 17);
            this.lbTamanyoKB.TabIndex = 34;
            this.lbTamanyoKB.Text = "Tamaño (KB)";
            // 
            // tbUbicacion
            // 
            this.tbUbicacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUbicacion.Location = new System.Drawing.Point(137, 173);
            this.tbUbicacion.Margin = new System.Windows.Forms.Padding(4);
            this.tbUbicacion.Name = "tbUbicacion";
            this.tbUbicacion.ReadOnly = true;
            this.tbUbicacion.Size = new System.Drawing.Size(289, 22);
            this.tbUbicacion.TabIndex = 33;
            // 
            // lbUbicacion
            // 
            this.lbUbicacion.AutoSize = true;
            this.lbUbicacion.Location = new System.Drawing.Point(37, 173);
            this.lbUbicacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUbicacion.Name = "lbUbicacion";
            this.lbUbicacion.Size = new System.Drawing.Size(70, 17);
            this.lbUbicacion.TabIndex = 32;
            this.lbUbicacion.Text = "Ubicación";
            // 
            // tbCategoria
            // 
            this.tbCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCategoria.Location = new System.Drawing.Point(137, 143);
            this.tbCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.ReadOnly = true;
            this.tbCategoria.Size = new System.Drawing.Size(289, 22);
            this.tbCategoria.TabIndex = 31;
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(37, 143);
            this.lbCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(69, 17);
            this.lbCategoria.TabIndex = 30;
            this.lbCategoria.Text = "Categoría";
            // 
            // tbFichero
            // 
            this.tbFichero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFichero.Location = new System.Drawing.Point(137, 111);
            this.tbFichero.Margin = new System.Windows.Forms.Padding(4);
            this.tbFichero.Name = "tbFichero";
            this.tbFichero.ReadOnly = true;
            this.tbFichero.Size = new System.Drawing.Size(289, 22);
            this.tbFichero.TabIndex = 29;
            // 
            // lbFichero
            // 
            this.lbFichero.AutoSize = true;
            this.lbFichero.Location = new System.Drawing.Point(37, 111);
            this.lbFichero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFichero.Name = "lbFichero";
            this.lbFichero.Size = new System.Drawing.Size(55, 17);
            this.lbFichero.TabIndex = 28;
            this.lbFichero.Text = "Fichero";
            // 
            // tbTitulo
            // 
            this.tbTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTitulo.Location = new System.Drawing.Point(137, 79);
            this.tbTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.ReadOnly = true;
            this.tbTitulo.Size = new System.Drawing.Size(289, 22);
            this.tbTitulo.TabIndex = 27;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(37, 79);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(43, 17);
            this.lbTitulo.TabIndex = 26;
            this.lbTitulo.Text = "Titulo";
            // 
            // tbArtista
            // 
            this.tbArtista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbArtista.Location = new System.Drawing.Point(137, 47);
            this.tbArtista.Margin = new System.Windows.Forms.Padding(4);
            this.tbArtista.Name = "tbArtista";
            this.tbArtista.ReadOnly = true;
            this.tbArtista.Size = new System.Drawing.Size(289, 22);
            this.tbArtista.TabIndex = 25;
            // 
            // lbArtista
            // 
            this.lbArtista.AutoSize = true;
            this.lbArtista.Location = new System.Drawing.Point(37, 47);
            this.lbArtista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbArtista.Name = "lbArtista";
            this.lbArtista.Size = new System.Drawing.Size(48, 17);
            this.lbArtista.TabIndex = 24;
            this.lbArtista.Text = "Artista";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btPrimero,
            this.btAnterior,
            this.btPosterior,
            this.btUltimo,
            this.btNumero,
            this.btBuscar,
            this.btAnadir,
            this.btEditar,
            this.btBorrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(467, 27);
            this.toolStrip1.TabIndex = 40;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btPrimero
            // 
            this.btPrimero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btPrimero.Image = ((System.Drawing.Image)(resources.GetObject("btPrimero.Image")));
            this.btPrimero.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btPrimero.Name = "btPrimero";
            this.btPrimero.Size = new System.Drawing.Size(24, 24);
            this.btPrimero.Text = "Primero";
            this.btPrimero.Click += new System.EventHandler(this.btPrimero_Click);
            // 
            // btAnterior
            // 
            this.btAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btAnterior.Image")));
            this.btAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAnterior.Name = "btAnterior";
            this.btAnterior.Size = new System.Drawing.Size(24, 24);
            this.btAnterior.Text = "Anterior";
            this.btAnterior.Click += new System.EventHandler(this.btAnterior_Click);
            // 
            // btPosterior
            // 
            this.btPosterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btPosterior.Image = ((System.Drawing.Image)(resources.GetObject("btPosterior.Image")));
            this.btPosterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btPosterior.Name = "btPosterior";
            this.btPosterior.Size = new System.Drawing.Size(24, 24);
            this.btPosterior.Text = "Posterior";
            this.btPosterior.Click += new System.EventHandler(this.btPosterior_Click);
            // 
            // btUltimo
            // 
            this.btUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btUltimo.Image")));
            this.btUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btUltimo.Name = "btUltimo";
            this.btUltimo.Size = new System.Drawing.Size(24, 24);
            this.btUltimo.Text = "Ultimo";
            this.btUltimo.Click += new System.EventHandler(this.btUltimo_Click);
            // 
            // btNumero
            // 
            this.btNumero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btNumero.Image = ((System.Drawing.Image)(resources.GetObject("btNumero.Image")));
            this.btNumero.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btNumero.Name = "btNumero";
            this.btNumero.Size = new System.Drawing.Size(24, 24);
            this.btNumero.Text = "Numero";
            this.btNumero.Click += new System.EventHandler(this.btNumero_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btBuscar.Image")));
            this.btBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(24, 24);
            this.btBuscar.Text = "Buscar";
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btAnadir
            // 
            this.btAnadir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btAnadir.Image = ((System.Drawing.Image)(resources.GetObject("btAnadir.Image")));
            this.btAnadir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAnadir.Name = "btAnadir";
            this.btAnadir.Size = new System.Drawing.Size(24, 24);
            this.btAnadir.Text = "Añadir";
            this.btAnadir.Click += new System.EventHandler(this.btAnadir_Click);
            // 
            // btEditar
            // 
            this.btEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btEditar.Image = ((System.Drawing.Image)(resources.GetObject("btEditar.Image")));
            this.btEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(24, 24);
            this.btEditar.Text = "Editar";
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btBorrar.Image")));
            this.btBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(24, 24);
            this.btBorrar.Text = "Borrar";
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 326);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(467, 25);
            this.statusStrip1.TabIndex = 41;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(55, 20);
            this.toolStripStatusLabel1.Text = "Ficha 0";
            // 
            // FormVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 351);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.tbFecha);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.tbTamanyoKB);
            this.Controls.Add(this.lbTamanyoKB);
            this.Controls.Add(this.tbUbicacion);
            this.Controls.Add(this.lbUbicacion);
            this.Controls.Add(this.tbCategoria);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.tbFichero);
            this.Controls.Add(this.lbFichero);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.tbArtista);
            this.Controls.Add(this.lbArtista);
            this.Name = "FormVisualizar";
            this.Text = "Vista detallada";
            this.Activated += new System.EventHandler(this.FormVisualizar_Activated);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.TextBox tbFecha;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.TextBox tbTamanyoKB;
        private System.Windows.Forms.Label lbTamanyoKB;
        private System.Windows.Forms.TextBox tbUbicacion;
        private System.Windows.Forms.Label lbUbicacion;
        private System.Windows.Forms.TextBox tbCategoria;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.TextBox tbFichero;
        private System.Windows.Forms.Label lbFichero;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TextBox tbArtista;
        private System.Windows.Forms.Label lbArtista;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btPrimero;
        private System.Windows.Forms.ToolStripButton btAnterior;
        private System.Windows.Forms.ToolStripButton btPosterior;
        private System.Windows.Forms.ToolStripButton btUltimo;
        private System.Windows.Forms.ToolStripButton btNumero;
        private System.Windows.Forms.ToolStripButton btBuscar;
        private System.Windows.Forms.ToolStripButton btAnadir;
        private System.Windows.Forms.ToolStripButton btEditar;
        private System.Windows.Forms.ToolStripButton btBorrar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}