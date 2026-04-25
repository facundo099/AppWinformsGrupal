using dominio;
using dominio;
using negocio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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
            Text = "Modificar Categoria";
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                if(categoria == null)
                    categoria = new Categoria();

                categoria.Descripcion = txtDescripcionCategoria.Text;
                if (categoria.Id != 0)
                {
                    negocio.Modificar(categoria);
                    MessageBox.Show("Categoria modificada con exito");
                }
                else
                {
                    negocio.agregar(categoria);
                    MessageBox.Show("Categoria agregada con exito");

                }
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

        private void frmAltaCategoria_Load(object sender, EventArgs e)
        {
            if (categoria != null)
            {
                txtDescripcionCategoria.Text = categoria.Descripcion;
            }
        }
    }
}
