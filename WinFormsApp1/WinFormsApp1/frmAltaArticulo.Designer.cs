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
            txtCategoria = new TextBox();
            txtMarca = new TextBox();
            txtPrecio = new TextBox();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(65, 25);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(65, 87);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(65, 149);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripción";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(163, 17);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(163, 149);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(163, 79);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 5;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(59, 354);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(222, 354);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(70, 298);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 9;
            lblMarca.Text = "Marca";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(70, 250);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 10;
            lblCategoria.Text = "Categoria";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(70, 206);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 11;
            lblPrecio.Text = "Precio";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(163, 247);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(100, 23);
            txtCategoria.TabIndex = 12;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(163, 290);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(100, 23);
            txtMarca.TabIndex = 13;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(163, 206);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 14;
            // 
            // frmAltaArticulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 473);
            Controls.Add(txtPrecio);
            Controls.Add(txtMarca);
            Controls.Add(txtCategoria);
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
            Text = "Alta Articulos";
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
        private TextBox txtCategoria;
        private TextBox txtMarca;
        private TextBox txtPrecio;
    }
}