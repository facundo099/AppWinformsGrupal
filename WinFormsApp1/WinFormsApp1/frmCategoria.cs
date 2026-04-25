using dominio;
using Microsoft.Data.SqlClient;
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
    public partial class frmCategoria : Form
    {
 
        public frmCategoria()
        {
            InitializeComponent();
        }



        private void frmCategoria_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            dgvCategorias.DataSource = negocio.Listar();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            frmAltaCategoria alta = new frmAltaCategoria();
            alta.ShowDialog();
            cargar();
        }


        private void btnModificarCat_Click(object sender, EventArgs e)
        {
            Categoria seleccionado;
            seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            frmAltaCategoria modificar = new frmAltaCategoria(seleccionado);
            modificar.ShowDialog();
            cargar();
        }
        private void btnEliminarCat_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria seleccionado;

            try
            {

                seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                int cantidad = negocio.contarArticulosPorCategoria(seleccionado.Id);

                if (cantidad > 0)
                {
                    MessageBox.Show("No podés eliminar esta categoria porque tiene " + cantidad + " artículos asociados.");
                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Confirma que desea eliminar la categoria?",
                    "Eliminando",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    negocio.eliminarFisico(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
