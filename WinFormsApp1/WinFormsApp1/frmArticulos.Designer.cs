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
            btnModificar = new Button();
            btnEliminarLogico = new Button();
            btnEliminarFisico = new Button();
            lblCampo = new Label();
            lblCriterio = new Label();
            lblFiltro = new Label();
            cboCampo = new ComboBox();
            cboCriterio = new ComboBox();
            txtFiltro = new TextBox();
            btnBuscar = new Button();
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
            pbArticulo.Location = new Point(846, 30);
            pbArticulo.Margin = new Padding(3, 2, 3, 2);
            pbArticulo.Name = "pbArticulo";
            pbArticulo.Size = new Size(314, 238);
            pbArticulo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbArticulo.TabIndex = 1;
            pbArticulo.TabStop = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 295);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(111, 32);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.BackColor = SystemColors.ActiveCaption;
            btnAnterior.Location = new Point(814, 145);
            btnAnterior.Margin = new Padding(3, 2, 3, 2);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(27, 28);
            btnAnterior.TabIndex = 4;
            btnAnterior.Text = "<";
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = SystemColors.ActiveCaption;
            btnSiguiente.Location = new Point(1166, 152);
            btnSiguiente.Margin = new Padding(3, 2, 3, 2);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(27, 28);
            btnSiguiente.TabIndex = 5;
            btnSiguiente.Text = ">";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(137, 295);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(111, 32);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminarLogico
            // 
            btnEliminarLogico.Location = new Point(370, 295);
            btnEliminarLogico.Name = "btnEliminarLogico";
            btnEliminarLogico.Size = new Size(111, 32);
            btnEliminarLogico.TabIndex = 3;
            btnEliminarLogico.Text = "Eliminar Logico";
            btnEliminarLogico.UseVisualStyleBackColor = true;
            btnEliminarLogico.Click += btnEliminarLogico_Click;
            // 
            // btnEliminarFisico
            // 
            btnEliminarFisico.Location = new Point(254, 295);
            btnEliminarFisico.Name = "btnEliminarFisico";
            btnEliminarFisico.Size = new Size(111, 32);
            btnEliminarFisico.TabIndex = 2;
            btnEliminarFisico.Text = "Eliminar Fisico";
            btnEliminarFisico.UseVisualStyleBackColor = true;
            btnEliminarFisico.Click += btnEliminarFisico_Click;
            // 
            // lblCampo
            // 
            lblCampo.AutoSize = true;
            lblCampo.Location = new Point(12, 354);
            lblCampo.Name = "lblCampo";
            lblCampo.Size = new Size(46, 15);
            lblCampo.TabIndex = 6;
            lblCampo.Text = "Campo";
            // 
            // lblCriterio
            // 
            lblCriterio.AutoSize = true;
            lblCriterio.Location = new Point(199, 354);
            lblCriterio.Name = "lblCriterio";
            lblCriterio.Size = new Size(46, 15);
            lblCriterio.TabIndex = 7;
            lblCriterio.Text = "Criterio";
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Location = new Point(402, 354);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(34, 15);
            lblFiltro.TabIndex = 8;
            lblFiltro.Text = "Filtro";
            // 
            // cboCampo
            // 
            cboCampo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCampo.FormattingEnabled = true;
            cboCampo.Location = new Point(67, 352);
            cboCampo.Margin = new Padding(3, 2, 3, 2);
            cboCampo.Name = "cboCampo";
            cboCampo.Size = new Size(107, 23);
            cboCampo.TabIndex = 9;
            cboCampo.SelectedIndexChanged += cboCampo_SelectedIndexChanged;
            // 
            // cboCriterio
            // 
            cboCriterio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCriterio.FormattingEnabled = true;
            cboCriterio.Location = new Point(254, 352);
            cboCriterio.Margin = new Padding(3, 2, 3, 2);
            cboCriterio.Name = "cboCriterio";
            cboCriterio.Size = new Size(107, 23);
            cboCriterio.TabIndex = 10;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(445, 352);
            txtFiltro.Margin = new Padding(3, 2, 3, 2);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(124, 23);
            txtFiltro.TabIndex = 11;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(609, 350);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(104, 24);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // frmArticulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 386);
            Controls.Add(btnBuscar);
            Controls.Add(txtFiltro);
            Controls.Add(cboCriterio);
            Controls.Add(cboCampo);
            Controls.Add(lblFiltro);
            Controls.Add(lblCriterio);
            Controls.Add(lblCampo);
            Controls.Add(btnEliminarFisico);
            Controls.Add(btnEliminarLogico);
            Controls.Add(btnModificar);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAnterior);
            Controls.Add(btnAgregar);
            Controls.Add(pbArticulo);
            Controls.Add(dgvArticulos);
            Name = "frmArticulos";
            Text = "Articulos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbArticulo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvArticulos;
        private PictureBox pbArticulo;
        private Button btnAgregar;
        private Button btnAnterior;
        private Button btnSiguiente;
        private Button btnModificar;
        private Button btnEliminarLogico;
        private Button btnEliminarFisico;
        private Label lblCampo;
        private Label lblCriterio;
        private Label lblFiltro;
        private ComboBox cboCampo;
        private ComboBox cboCriterio;
        private TextBox txtFiltro;
        private Button btnBuscar;
    }
}
