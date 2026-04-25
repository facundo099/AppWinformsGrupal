using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using dominio;
using negocio;

namespace WinFormsApp1
{
    public partial class frmAltaCategoria : Form
    {
        private Categoria categoria = null;
        public frmAltaCategoria()
        {
            InitializeComponent();
        }
        public frmAltaCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                categoria.Descripcion = txtDescripcionCategoria.Text;
                negocio.agregar(categoria);
                MessageBox.Show("Categoria agregada con exito");
                Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelarCategoria_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
