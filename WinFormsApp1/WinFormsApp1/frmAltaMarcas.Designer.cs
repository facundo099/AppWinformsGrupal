namespace WinFormsApp1
{
    partial class frmAltaMarcas
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
            lblDescMarca = new Label();
            btnCancelarMarca = new Button();
            btnAcepMarca = new Button();
            txtDescMarca = new TextBox();
            SuspendLayout();
            // 
            // lblDescMarca
            // 
            lblDescMarca.AutoSize = true;
            lblDescMarca.Location = new Point(68, 66);
            lblDescMarca.Name = "lblDescMarca";
            lblDescMarca.Size = new Size(69, 15);
            lblDescMarca.TabIndex = 1;
            lblDescMarca.Text = "Descripcion";
            // 
            // btnCancelarMarca
            // 
            btnCancelarMarca.Location = new Point(210, 169);
            btnCancelarMarca.Name = "btnCancelarMarca";
            btnCancelarMarca.Size = new Size(75, 23);
            btnCancelarMarca.TabIndex = 2;
            btnCancelarMarca.Text = "Cancelar";
            btnCancelarMarca.UseVisualStyleBackColor = true;
            btnCancelarMarca.Click += btnCancelarMarca_Click;
            // 
            // btnAcepMarca
            // 
            btnAcepMarca.Location = new Point(68, 169);
            btnAcepMarca.Name = "btnAcepMarca";
            btnAcepMarca.Size = new Size(75, 23);
            btnAcepMarca.TabIndex = 3;
            btnAcepMarca.Text = "Aceptar";
            btnAcepMarca.UseVisualStyleBackColor = true;
            btnAcepMarca.Click += btnAcepMarca_Click;
            // 
            // txtDescMarca
            // 
            txtDescMarca.Location = new Point(143, 66);
            txtDescMarca.Name = "txtDescMarca";
            txtDescMarca.Size = new Size(161, 23);
            txtDescMarca.TabIndex = 5;
            // 
            // frmAltaMarcas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 258);
            Controls.Add(txtDescMarca);
            Controls.Add(btnAcepMarca);
            Controls.Add(btnCancelarMarca);
            Controls.Add(lblDescMarca);
            Name = "frmAltaMarcas";
            Text = "Agregar Marca";
            Load += frmAltaMarcas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblDescMarca;
        private Button btnCancelarMarca;
        private Button btnAcepMarca;
        private TextBox txtDescMarca;
    }
}