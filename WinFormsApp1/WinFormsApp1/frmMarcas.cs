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
        private void cargar()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            dgvMarcas.DataSource = negocio.Listar();
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }
        private void eliminar(bool logico = false)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marca marca;
            try
            {
                //DialogResult respuesta = MessageBox.Show("Quieres Eliminar la categoria?");
                //if(respuesta == DialogResult.Yes)
                //{
                marca = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                if (logico)
                    negocio.EliminarLogicaMarca(marca.Id);
                else
                {
                    negocio.EliminarFisicaMarca(marca.Id);
                }
                cargar();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
