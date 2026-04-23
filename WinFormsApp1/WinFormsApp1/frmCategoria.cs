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

        private void btnEliminarLogicoCat_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }
        private void eliminar(bool logico = false)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria categoria;
            try
            {
                //DialogResult respuesta = MessageBox.Show("Quieres Eliminar la categoria?");
                //if(respuesta == DialogResult.Yes)
                //{
                    categoria = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                    if (logico)
                         negocio.eliminarLogicaCategoria(categoria.Id);
                    else
                    {
                        negocio.eliminarFisicaCategoria(categoria.Id);
                    }
                    cargar();
                //}
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
         
        
        
    }
}
