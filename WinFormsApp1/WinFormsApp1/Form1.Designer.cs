namespace WinFormsApp1
{
    partial class Form1
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
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbArticulo).BeginInit();
            SuspendLayout();
            // 
            // dgvArticulos
            // 
            dgvArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticulos.Location = new Point(12, 13);
            dgvArticulos.Margin = new Padding(3, 4, 3, 4);
            dgvArticulos.Name = "dgvArticulos";
            dgvArticulos.RowHeadersWidth = 51;
            dgvArticulos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvArticulos.Size = new Size(713, 372);
            dgvArticulos.TabIndex = 0;
            dgvArticulos.SelectionChanged += dgvArticulos_SelectionChanged;
            // 
            // pbArticulo
            // 
            pbArticulo.Location = new Point(752, 24);
            pbArticulo.Name = "pbArticulo";
            pbArticulo.Size = new Size(464, 314);
            pbArticulo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbArticulo.TabIndex = 1;
            pbArticulo.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 398);
            Controls.Add(pbArticulo);
            Controls.Add(dgvArticulos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbArticulo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvArticulos;
        private PictureBox pbArticulo;
    }
}
