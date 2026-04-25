namespace WinFormsApp1
{
    partial class frmInicio
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
            menuStrip1 = new MenuStrip();
            btnSalir = new Button();
            btnArticulos = new Button();
            btnListarMarcas = new Button();
            btnListarCategorias = new Button();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(737, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(329, 245);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 31);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnArticulos
            // 
            btnArticulos.Location = new Point(312, 162);
            btnArticulos.Margin = new Padding(3, 4, 3, 4);
            btnArticulos.Name = "btnArticulos";
            btnArticulos.Size = new Size(107, 31);
            btnArticulos.TabIndex = 2;
            btnArticulos.Text = "Articulos";
            btnArticulos.UseVisualStyleBackColor = true;
            btnArticulos.Click += btnArticulos_Click;
            // 
            // btnListarMarcas
            // 
            btnListarMarcas.Location = new Point(116, 162);
            btnListarMarcas.Margin = new Padding(3, 4, 3, 4);
            btnListarMarcas.Name = "btnListarMarcas";
            btnListarMarcas.Size = new Size(178, 31);
            btnListarMarcas.TabIndex = 4;
            btnListarMarcas.Text = "Listar Marcas";
            btnListarMarcas.UseVisualStyleBackColor = true;
            btnListarMarcas.Click += btnListarMarcas_Click;
            // 
            // btnListarCategorias
            // 
            btnListarCategorias.Location = new Point(436, 162);
            btnListarCategorias.Margin = new Padding(3, 4, 3, 4);
            btnListarCategorias.Name = "btnListarCategorias";
            btnListarCategorias.Size = new Size(178, 31);
            btnListarCategorias.TabIndex = 5;
            btnListarCategorias.Text = "Listar Categorias";
            btnListarCategorias.UseVisualStyleBackColor = true;
            btnListarCategorias.Click += btnListarCategorias_Click;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 340);
            Controls.Add(btnListarCategorias);
            Controls.Add(btnListarMarcas);
            Controls.Add(btnArticulos);
            Controls.Add(btnSalir);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmInicio";
            Text = "frmInicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Button btnSalir;
        private Button btnArticulos;
        private Button btnListarMarcas;
        private Button btnListarCategorias;
    }
}