namespace WinFormsApp1
{
    partial class frmArticulos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvArticulos = new DataGridView();
            pbArticulo = new PictureBox();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbArticulo).BeginInit();
            SuspendLayout();
            // 
            // dgvArticulos
            // 
            dgvArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticulos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvArticulos.Location = new Point(10, 10);
            dgvArticulos.MultiSelect = false;
            dgvArticulos.Name = "dgvArticulos";
            dgvArticulos.RowHeadersWidth = 51;
            dgvArticulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArticulos.Size = new Size(788, 279);
            dgvArticulos.TabIndex = 0;
            dgvArticulos.SelectionChanged += dgvArticulos_SelectionChanged;
            // 
            // pbArticulo
            // 
            pbArticulo.Location = new Point(802, 30);
            pbArticulo.Margin = new Padding(3, 2, 3, 2);
            pbArticulo.Name = "pbArticulo";
            pbArticulo.Size = new Size(406, 236);
            pbArticulo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbArticulo.TabIndex = 1;
            pbArticulo.TabStop = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 295);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(111, 32);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // frmArticulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 340);
            Controls.Add(btnAgregar);
            Controls.Add(pbArticulo);
            Controls.Add(dgvArticulos);
            Name = "frmArticulos";
            Text = "Articulos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbArticulo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvArticulos;
        private PictureBox pbArticulo;
        private Button btnAgregar;
    }
}
