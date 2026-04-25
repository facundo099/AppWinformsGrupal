namespace WinFormsApp1
{
    partial class frmAltaArticulo
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
            lblCodigo = new Label();
            lblNombre = new Label();
            lblDescripcion = new Label();
            txtCodigo = new TextBox();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblMarca = new Label();
            lblCategoria = new Label();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            cboCategoria = new ComboBox();
            cboMarca = new ComboBox();
            txtUrlImagen = new TextBox();
            lblUrlImagen = new Label();
            pbImagen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(138, 47);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(58, 20);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(138, 105);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(115, 159);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(87, 20);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripción";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(209, 43);
            txtCodigo.Margin = new Padding(3, 4, 3, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(138, 27);
            txtCodigo.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(209, 159);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(138, 27);
            txtDescripcion.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(209, 105);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(138, 27);
            txtNombre.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(117, 443);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(86, 31);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(262, 443);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(154, 365);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(50, 20);
            lblMarca.TabIndex = 9;
            lblMarca.Text = "Marca";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(130, 315);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(74, 20);
            lblCategoria.TabIndex = 10;
            lblCategoria.Text = "Categoria";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(154, 269);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 11;
            lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(210, 267);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(138, 27);
            txtPrecio.TabIndex = 4;
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(210, 315);
            cboCategoria.Margin = new Padding(3, 4, 3, 4);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(138, 28);
            cboCategoria.TabIndex = 5;
            // 
            // cboMarca
            // 
            cboMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMarca.FormattingEnabled = true;
            cboMarca.Location = new Point(210, 365);
            cboMarca.Margin = new Padding(3, 4, 3, 4);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(138, 28);
            cboMarca.TabIndex = 6;
            // 
            // txtUrlImagen
            // 
            txtUrlImagen.Location = new Point(209, 213);
            txtUrlImagen.Margin = new Padding(3, 4, 3, 4);
            txtUrlImagen.Name = "txtUrlImagen";
            txtUrlImagen.Size = new Size(138, 27);
            txtUrlImagen.TabIndex = 3;
            txtUrlImagen.Leave += txtUrlImagen_Leave;
            // 
            // lblUrlImagen
            // 
            lblUrlImagen.AutoSize = true;
            lblUrlImagen.Location = new Point(115, 217);
            lblUrlImagen.Name = "lblUrlImagen";
            lblUrlImagen.Size = new Size(89, 20);
            lblUrlImagen.TabIndex = 13;
            lblUrlImagen.Text = "URL imagen";
            // 
            // pbImagen
            // 
            pbImagen.Location = new Point(432, 47);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(304, 340);
            pbImagen.TabIndex = 14;
            pbImagen.TabStop = false;
            
            // 
            // frmAltaArticulo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 521);
            Controls.Add(pbImagen);
            Controls.Add(txtUrlImagen);
            Controls.Add(lblUrlImagen);
            Controls.Add(cboMarca);
            Controls.Add(cboCategoria);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(lblCategoria);
            Controls.Add(lblMarca);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtNombre);
            Controls.Add(txtDescripcion);
            Controls.Add(txtCodigo);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombre);
            Controls.Add(lblCodigo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAltaArticulo";
            Text = "*";
            Load += frmAltaArticulo_Load;
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblNombre;
        private Label lblDescripcion;
        private TextBox txtCodigo;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblMarca;
        private Label lblCategoria;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private ComboBox cboCategoria;
        private ComboBox cboMarca;
        private TextBox txtUrlImagen;
        private Label lblUrlImagen;
        private PictureBox pbImagen;
    }
}