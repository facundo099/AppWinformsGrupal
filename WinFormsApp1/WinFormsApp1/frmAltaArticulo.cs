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
        private Articulo articulo = null;
        private List<string> urlsImagenes = new List<string>();

        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Artículo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            ImagenNegocio imgNegocio = new ImagenNegocio();

            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecio.Text);

                if (articulo.Id != 0)
                {
                    artNegocio.modificar(articulo);

                    foreach (string url in urlsImagenes)
                    {
                        Imagen nueva = new Imagen();
                        nueva.IdArticulo = articulo.Id;
                        nueva.ImagenUrl = url;

                        imgNegocio.agregar(nueva);
                    }
                }
                else
                {
                    artNegocio.agregar(articulo);

                    List<Articulo> lista = artNegocio.Listar();
                    Articulo ultimo = lista[lista.Count - 1];

                    foreach (string url in urlsImagenes)
                    {
                        Imagen nueva = new Imagen();
                        nueva.IdArticulo = ultimo.Id;
                        nueva.ImagenUrl = url;

                        imgNegocio.agregar(nueva);
                    }
                }

                MessageBox.Show("Guardado correctamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Debe ingresar un código.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un nombre.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Debe ingresar una descripción.");
                return false;
            }

            if (cboMarca.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una marca.");
                return false;
            }

            if (cboCategoria.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una categoría.");
                return false;
            }

            decimal precio;
            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("Debe ingresar un precio válido.");
                return false;
            }

            if (precio <= 0)
            {
                MessageBox.Show("El precio debe ser mayor a 0.");
                return false;
            }

            return true;
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                cboCategoria.DataSource = categoriaNegocio.Listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";
                cboMarca.DataSource = marcaNegocio.Listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;

                    if (articulo.Categoria != null)
                        cboCategoria.SelectedValue = articulo.Categoria.Id;

                    if (articulo.Marca != null)
                        cboMarca.SelectedValue = articulo.Marca.Id;

                    txtPrecio.Text = articulo.Precio.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            try
            {
                pbImagen.Load(txtUrlImagen.Text);

                urlsImagenes.Add(txtUrlImagen.Text);
            }
            catch
            {
                pbImagen.Load("https://t4.ftcdn.net/jpg/06/57/37/01/360_F_657370150_pdNeG5pjI976ZasVbKN9VqH1rfoykdYU.jpg");
            }
        }


        private void btnAltaImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg|png|*.png";

            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrlImagen.Text = archivo.FileName;
                pbImagen.Load(archivo.FileName);
                urlsImagenes.Add(archivo.FileName);

            }
        }

        private void btnAgregarUrl_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUrlImagen.Text))
            {
                urlsImagenes.Add(txtUrlImagen.Text);
                txtUrlImagen.Clear();
            }
        }
    }
}
