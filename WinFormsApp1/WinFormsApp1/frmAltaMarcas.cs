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
    public partial class frmAltaMarcas : Form
    {
        private Marca marca = null;
        public frmAltaMarcas()
        {
            InitializeComponent();
        }
        public frmAltaMarcas(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
            Text = "Modificar Marca";
        }

        private void btnCancelarMarca_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAcepMarca_Click(object sender, EventArgs e)
        {
            
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                if(marca == null)
                    marca = new Marca();
                marca.Descripcion = txtDescMarca.Text;

                if(marca.Id != 0)
                {
                    negocio.Modificar(marca);
                    MessageBox.Show("Marca modificada con exito");
                    Close();
                    return;
                }
                else
                {
                 negocio.agregar(marca);
                }
                MessageBox.Show("Marca agregada con exito");
                Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        

        private void frmAltaMarcas_Load(object sender, EventArgs e)
        {
            if (marca != null)
            {
                txtDescMarca.Text = marca.Descripcion;
            }
        }
    }
}
