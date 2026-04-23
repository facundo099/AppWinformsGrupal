namespace WinFormsApp1
{
    partial class frmMarcas
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
            dgvMarcas = new DataGridView();
            btnAgregarMarca = new Button();
            btnEliminarMarca = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMarcas).BeginInit();
            SuspendLayout();
            // 
            // dgvMarcas
            // 
            dgvMarcas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMarcas.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvMarcas.Location = new Point(12, 40);
            dgvMarcas.MultiSelect = false;
            dgvMarcas.Name = "dgvMarcas";
            dgvMarcas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMarcas.Size = new Size(289, 172);
            dgvMarcas.TabIndex = 0;
            // 
            // btnAgregarMarca
            // 
            btnAgregarMarca.Location = new Point(19, 240);
            btnAgregarMarca.Name = "btnAgregarMarca";
            btnAgregarMarca.Size = new Size(75, 23);
            btnAgregarMarca.TabIndex = 1;
            btnAgregarMarca.Text = "Agregar";
            btnAgregarMarca.UseVisualStyleBackColor = true;
            btnAgregarMarca.Click += btnAgregarMarca_Click;
            // 
            // btnEliminarMarca
            // 
            btnEliminarMarca.Location = new Point(120, 240);
            btnEliminarMarca.Name = "btnEliminarMarca";
            btnEliminarMarca.Size = new Size(75, 23);
            btnEliminarMarca.TabIndex = 2;
            btnEliminarMarca.Text = "Eliminar";
            btnEliminarMarca.UseVisualStyleBackColor = true;
            btnEliminarMarca.Click += btnEliminarMarca_Click;
            // 
            // frmMarcas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 314);
            Controls.Add(btnEliminarMarca);
            Controls.Add(btnAgregarMarca);
            Controls.Add(dgvMarcas);
            Name = "frmMarcas";
            Text = "Marcas";
            Load += frmMarcas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMarcas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMarcas;
        private Button btnAgregarMarca;
        private Button btnEliminarMarca;
    }
}