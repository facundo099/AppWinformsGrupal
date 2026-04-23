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

            cargarImagen();


        }

        private void cargarImagen()
        {
            try
            {
                if (imagenesSeleccionadas != null && imagenesSeleccionadas.Count > 0)
                {

                    pbArticulo.Load(imagenesSeleccionadas[indiceImagen].ImagenUrl);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {

                pbArticulo.Load("https://t4.ftcdn.net/jpg/06/57/37/01/360_F_657370150_pdNeG5pjI976ZasVbKN9VqH1rfoykdYU.jpg");
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
                cargarImagen();
            }

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (imagenesSeleccionadas != null && indiceImagen < imagenesSeleccionadas.Count - 1)
            {
                indiceImagen++;
                cargarImagen();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            cargar();

        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }
        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            eliminar();
        }
        private void eliminar(bool logico = false)
        {
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

       
    }
}
