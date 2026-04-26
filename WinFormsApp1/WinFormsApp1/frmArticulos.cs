using static System.Net.Mime.MediaTypeNames;
using dominio;
using negocio;

namespace WinFormsApp1
{
    public partial class frmArticulos : Form
    {
        private List<Articulo> listaArticulo;
        private List<Imagen> imagenesSeleccionadas;
        private int indiceImagen = 0;

        public frmArticulos()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
            btnEliminarLogico.Visible = false; // activar cuando exista columna Activo en DB
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Precio");


        }
        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulo = negocio.Listar();
            dgvArticulos.DataSource = listaArticulo;
            dgvArticulos.Columns["Id"].Visible = false;

        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null || dgvArticulos.CurrentRow.DataBoundItem == null)
                return;

            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            ImagenNegocio imgNegocio = new ImagenNegocio();


            imagenesSeleccionadas = imgNegocio.ListarImagenPorArticulo(seleccionado.Id);
            indiceImagen = 0;

            try
            {
                pbArticulo.Load(HelperImagen.CargarImagen(imagenesSeleccionadas, indiceImagen));
            }
            catch
            {
                pbArticulo.LoadAsync("https://via.placeholder.com/150");
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargar();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (imagenesSeleccionadas != null && indiceImagen > 0)
            {
                indiceImagen--;
                try
                {
                    pbArticulo.Load(HelperImagen.CargarImagen(imagenesSeleccionadas, indiceImagen));
                }
                catch
                {
                    pbArticulo.Load("https://t4.ftcdn.net/jpg/06/57/37/01/360_F_657370150_pdNeG5pjI976ZasVbKN9VqH1rfoykdYU.jpg");
                }
            }

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (imagenesSeleccionadas != null && indiceImagen < imagenesSeleccionadas.Count - 1)
            {
                indiceImagen++;
                try
                {
                    pbArticulo.Load(HelperImagen.CargarImagen(imagenesSeleccionadas, indiceImagen));
                }
                catch
                {
                    pbArticulo.Load("https://t4.ftcdn.net/jpg/06/57/37/01/360_F_657370150_pdNeG5pjI976ZasVbKN9VqH1rfoykdYU.jpg");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un artículo para modificar.");
                return;
            }
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            cargar();

        }

        // implementar eliminación lógica cuando exista la columna Activo en DB.
        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
          //  eliminar(true);
        }
        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            eliminar();
        }
        private void eliminar(bool logico = false)
        {
            if (dgvArticulos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un artículo.");
                return;
            }
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar el artículo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    if (logico)
                        negocio.eliminarLogico(seleccionado.Id);
                    else
                        negocio.eliminarFisico(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private bool validarBuscar()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un campo.");
                return true;
            }

            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un criterio.");
                return true;
            }

            if (txtFiltro.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un filtro.");
                return true;
            }

            if (cboCampo.SelectedItem.ToString() == "Precio")
            {
                decimal valorPrecio;
                string filtroValidado = txtFiltro.Text.Replace(",", ".");

                if (!decimal.TryParse(filtroValidado,
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                    out valorPrecio))
                {
                    MessageBox.Show("Debe ingresar un valor numérico válido para el precio.");
                    return true;
                }
            }

            return false;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarBuscar())
                    return;

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltro.Text;
                dgvArticulos.DataSource = negocio.BuscarArticulo(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            cboCriterio.Items.Clear();

            if (opcion == "Precio")
            {
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");

            }
            else
            {
                cboCriterio.Items.Add("Contiene");
                cboCriterio.Items.Add("Comienza con");

            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
