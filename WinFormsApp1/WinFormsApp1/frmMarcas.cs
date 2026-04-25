using dominio;
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
    public partial class frmMarcas : Form
    {
        public frmMarcas()
        {
            InitializeComponent();
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            frmAltaMarcas alta = new frmAltaMarcas();
            alta.ShowDialog();
            cargar();
        }
        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            Marca seleccionado;
            seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            frmAltaMarcas modificar = new frmAltaMarcas(seleccionado);
            modificar.ShowDialog();
            cargar();
        }
        private void cargar()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            dgvMarcas.DataSource = negocio.Listar();
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {

            MarcaNegocio negocio = new MarcaNegocio();
            Marca seleccionado;

            try
            {

                seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                int cantidad = negocio.contarArticulosPorMarca(seleccionado.Id);

                if (cantidad > 0)
                {
                    MessageBox.Show("No podés eliminar esta marca porque tiene " + cantidad + " artículos asociados.");
                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Confirma que desea eliminar la marca?",
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
