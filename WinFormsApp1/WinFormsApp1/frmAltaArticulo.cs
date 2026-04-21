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
    public partial class frmAltaArticulo : Form
    {
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo art = new Articulo();
            ArticuloNegocio artNegocio = new ArticuloNegocio();

            try
            {
                art.Codigo = txtCodigo.Text;
                art.Nombre = txtNombre.Text;
                art.Descripcion = txtDescripcion.Text;
                art.Categoria = (Categoria)cboCategoria.SelectedItem;
                art.Marca = (Marca)cboMarca.SelectedItem;
                art.Precio = decimal.Parse(txtPrecio.Text);
                artNegocio.agregar(art);
                MessageBox.Show("Agregado correctamente");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                cboCategoria.DataSource = categoriaNegocio.Listar();
                cboMarca.DataSource = marcaNegocio.Listar();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
