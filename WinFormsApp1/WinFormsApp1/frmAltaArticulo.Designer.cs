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
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(121, 35);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(121, 79);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(101, 119);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripción";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(183, 32);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(121, 23);
            txtCodigo.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(183, 119);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(121, 23);
            txtDescripcion.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(183, 79);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(121, 23);
            txtNombre.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(102, 332);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(229, 332);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(135, 274);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 9;
            lblMarca.Text = "Marca";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(114, 236);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 10;
            lblCategoria.Text = "Categoria";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(135, 202);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 11;
            lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(184, 200);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(121, 23);
            txtPrecio.TabIndex = 4;
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(184, 236);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(121, 23);
            cboCategoria.TabIndex = 5;
            // 
            // cboMarca
            // 
            cboMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMarca.FormattingEnabled = true;
            cboMarca.Location = new Point(184, 274);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(121, 23);
            cboMarca.TabIndex = 6;
            // 
            // txtUrlImagen
            // 
            txtUrlImagen.Location = new Point(183, 160);
            txtUrlImagen.Name = "txtUrlImagen";
            txtUrlImagen.Size = new Size(121, 23);
            txtUrlImagen.TabIndex = 3;
            // 
            // lblUrlImagen
            // 
            lblUrlImagen.AutoSize = true;
            lblUrlImagen.Location = new Point(101, 163);
            lblUrlImagen.Name = "lblUrlImagen";
            lblUrlImagen.Size = new Size(71, 15);
            lblUrlImagen.TabIndex = 13;
            lblUrlImagen.Text = "URL imagen";
            // 
            // frmAltaArticulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 391);
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
            Name = "frmAltaArticulo";
            Text = "*";
            Load += frmAltaArticulo_Load;
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
    }
}