namespace WinFormsApp1
{
    partial class frmCategoria
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
            dgvCategorias = new DataGridView();
            btnAgregarCategoria = new Button();
            btnEliminarCat = new Button();
            btnModificarCat = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(12, 35);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(299, 142);
            dgvCategorias.TabIndex = 0;
            // 
            // btnAgregarCategoria
            // 
            btnAgregarCategoria.Location = new Point(23, 220);
            btnAgregarCategoria.Name = "btnAgregarCategoria";
            btnAgregarCategoria.Size = new Size(70, 30);
            btnAgregarCategoria.TabIndex = 1;
            btnAgregarCategoria.Text = "Agregar";
            btnAgregarCategoria.UseVisualStyleBackColor = true;
            btnAgregarCategoria.Click += btnAgregarCategoria_Click;
            // 
            // btnEliminarCat
            // 
            btnEliminarCat.Location = new Point(114, 220);
            btnEliminarCat.Name = "btnEliminarCat";
            btnEliminarCat.Size = new Size(71, 30);
            btnEliminarCat.TabIndex = 2;
            btnEliminarCat.Text = "Eliminar";
            btnEliminarCat.UseVisualStyleBackColor = true;
            btnEliminarCat.Click += btnEliminarCat_Click;
            // 
            // btnModificarCat
            // 
            btnModificarCat.Location = new Point(203, 220);
            btnModificarCat.Name = "btnModificarCat";
            btnModificarCat.Size = new Size(75, 32);
            btnModificarCat.TabIndex = 3;
            btnModificarCat.Text = "Modificar";
            btnModificarCat.UseVisualStyleBackColor = true;
            btnModificarCat.Click += btnModificarCat_Click;
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 316);
            Controls.Add(btnModificarCat);
            Controls.Add(btnEliminarCat);
            Controls.Add(btnAgregarCategoria);
            Controls.Add(dgvCategorias);
            Name = "frmCategoria";
            Text = "Categorias";
            Load += frmCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCategorias;
        private Button btnAgregarCategoria;
        private Button btnEliminarCat;
        private Button btnModificarCat;
    }
}