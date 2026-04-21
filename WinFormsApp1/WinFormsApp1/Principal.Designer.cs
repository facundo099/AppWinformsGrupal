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
            btnAnterior = new Button();
            btnSiguiente = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbArticulo).BeginInit();
            SuspendLayout();
            // 
            // dgvArticulos
            // 
            dgvArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticulos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvArticulos.Location = new Point(11, 13);
            dgvArticulos.Margin = new Padding(3, 4, 3, 4);
            dgvArticulos.MultiSelect = false;
            dgvArticulos.Name = "dgvArticulos";
            dgvArticulos.RowHeadersWidth = 51;
            dgvArticulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArticulos.Size = new Size(901, 372);
            dgvArticulos.TabIndex = 0;
            dgvArticulos.SelectionChanged += dgvArticulos_SelectionChanged;
            // 
            // pbArticulo
            // 
            pbArticulo.Location = new Point(967, 40);
            pbArticulo.Name = "pbArticulo";
            pbArticulo.Size = new Size(359, 317);
            pbArticulo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbArticulo.TabIndex = 1;
            pbArticulo.TabStop = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(14, 393);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(127, 43);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.BackColor = SystemColors.ActiveCaption;
            btnAnterior.Location = new Point(930, 193);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(31, 38);
            btnAnterior.TabIndex = 3;
            btnAnterior.Text = "<";
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = SystemColors.ActiveCaption;
            btnSiguiente.Location = new Point(1332, 203);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(31, 38);
            btnSiguiente.TabIndex = 4;
            btnSiguiente.Text = ">";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // frmArticulos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1393, 453);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAnterior);
            Controls.Add(btnAgregar);
            Controls.Add(pbArticulo);
            Controls.Add(dgvArticulos);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btnAnterior;
        private Button btnSiguiente;
    }
}
