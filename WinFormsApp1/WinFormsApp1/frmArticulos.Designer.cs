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
            btnAgregar.TabIndex = 0;
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
            btnAnterior.TabIndex = 4;
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
            btnSiguiente.TabIndex = 5;
            btnSiguiente.Text = ">";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(157, 393);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(127, 43);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminarLogico
            // 
            btnEliminarLogico.Location = new Point(423, 393);
            btnEliminarLogico.Margin = new Padding(3, 4, 3, 4);
            btnEliminarLogico.Name = "btnEliminarLogico";
            btnEliminarLogico.Size = new Size(127, 43);
            btnEliminarLogico.TabIndex = 3;
            btnEliminarLogico.Text = "Eliminar Logico";
            btnEliminarLogico.UseVisualStyleBackColor = true;
            btnEliminarLogico.Click += btnEliminarLogico_Click;
            // 
            // btnEliminarFisico
            // 
            btnEliminarFisico.Location = new Point(290, 393);
            btnEliminarFisico.Margin = new Padding(3, 4, 3, 4);
            btnEliminarFisico.Name = "btnEliminarFisico";
            btnEliminarFisico.Size = new Size(127, 43);
            btnEliminarFisico.TabIndex = 2;
            btnEliminarFisico.Text = "Eliminar Fisico";
            btnEliminarFisico.UseVisualStyleBackColor = true;
            btnEliminarFisico.Click += btnEliminarFisico_Click;
            // 
            // lblCampo
            // 
            lblCampo.AutoSize = true;
            lblCampo.Location = new Point(14, 472);
            lblCampo.Name = "lblCampo";
            lblCampo.Size = new Size(57, 20);
            lblCampo.TabIndex = 6;
            lblCampo.Text = "Campo";
            // 
            // lblCriterio
            // 
            lblCriterio.AutoSize = true;
            lblCriterio.Location = new Point(227, 472);
            lblCriterio.Name = "lblCriterio";
            lblCriterio.Size = new Size(58, 20);
            lblCriterio.TabIndex = 7;
            lblCriterio.Text = "Criterio";
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Location = new Point(460, 472);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(43, 20);
            lblFiltro.TabIndex = 8;
            lblFiltro.Text = "Filtro";
            // 
            // cboCampo
            // 
            cboCampo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCampo.FormattingEnabled = true;
            cboCampo.Location = new Point(77, 469);
            cboCampo.Name = "cboCampo";
            cboCampo.Size = new Size(122, 28);
            cboCampo.TabIndex = 9;
            cboCampo.SelectedIndexChanged += cboCampo_SelectedIndexChanged;
            // 
            // cboCriterio
            // 
            cboCriterio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCriterio.FormattingEnabled = true;
            cboCriterio.Location = new Point(290, 469);
            cboCriterio.Name = "cboCriterio";
            cboCriterio.Size = new Size(122, 28);
            cboCriterio.TabIndex = 10;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(509, 469);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(141, 27);
            txtFiltro.TabIndex = 11;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(696, 466);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(119, 32);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // frmArticulos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1393, 514);
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
            Margin = new Padding(3, 4, 3, 4);
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
