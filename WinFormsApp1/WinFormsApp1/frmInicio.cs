using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            frmArticulos negocio = new frmArticulos();
            negocio.ShowDialog();
        }

        private void btnListarMarcas_Click(object sender, EventArgs e)
        {
            frmMarcas negocio = new frmMarcas();
            negocio.ShowDialog();
        }

        private void btnListarCategorias_Click(object sender, EventArgs e)
        {
            frmCategoria categoria = new frmCategoria();
            categoria.ShowDialog();
        }
    }
}
