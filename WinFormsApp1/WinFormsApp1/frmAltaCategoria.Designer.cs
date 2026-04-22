namespace WinFormsApp1
{
    partial class frmAltaCategoria
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
            lblDescripcionCategoria = new Label();
            txtDescripcionCategoria = new TextBox();
            btnAgregarCategoria = new Button();
            btnCancelarCategoria = new Button();
            SuspendLayout();
            // 
            // lblDescripcionCategoria
            // 
            lblDescripcionCategoria.AutoSize = true;
            lblDescripcionCategoria.Location = new Point(52, 68);
            lblDescripcionCategoria.Name = "lblDescripcionCategoria";
            lblDescripcionCategoria.Size = new Size(69, 15);
            lblDescripcionCategoria.TabIndex = 0;
            lblDescripcionCategoria.Text = "Descripcion";
            // 
            // txtDescripcionCategoria
            // 
            txtDescripcionCategoria.Location = new Point(137, 65);
            txtDescripcionCategoria.Name = "txtDescripcionCategoria";
            txtDescripcionCategoria.Size = new Size(134, 23);
            txtDescripcionCategoria.TabIndex = 1;
            // 
            // btnAgregarCategoria
            // 
            btnAgregarCategoria.Location = new Point(51, 163);
            btnAgregarCategoria.Name = "btnAgregarCategoria";
            btnAgregarCategoria.Size = new Size(70, 25);
            btnAgregarCategoria.TabIndex = 2;
            btnAgregarCategoria.Text = "Agregar";
            btnAgregarCategoria.UseVisualStyleBackColor = true;
            btnAgregarCategoria.Click += btnAgregarCategoria_Click;
            // 
            // btnCancelarCategoria
            // 
            btnCancelarCategoria.Location = new Point(173, 163);
            btnCancelarCategoria.Name = "btnCancelarCategoria";
            btnCancelarCategoria.Size = new Size(70, 25);
            btnCancelarCategoria.TabIndex = 3;
            btnCancelarCategoria.Text = "Cancelar";
            btnCancelarCategoria.UseVisualStyleBackColor = true;
            btnCancelarCategoria.Click += btnCancelarCategoria_Click;
            // 
            // frmAltaCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 225);
            Controls.Add(btnCancelarCategoria);
            Controls.Add(btnAgregarCategoria);
            Controls.Add(txtDescripcionCategoria);
            Controls.Add(lblDescripcionCategoria);
            Name = "frmAltaCategoria";
            Text = "Agregar Categoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDescripcionCategoria;
        private TextBox txtDescripcionCategoria;
        private Button btnAgregarCategoria;
        private Button btnCancelarCategoria;
    }
}