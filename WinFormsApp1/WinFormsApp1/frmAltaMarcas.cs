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
        }

        private void btnCancelarMarca_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAcepMarca_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                marca.Descripcion = txtDescMarca.Text;
                negocio.agregar(marca);
                MessageBox.Show("Marca agregada con exito");
                Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

    }
}
