using static System.Net.Mime.MediaTypeNames;
using dominio;
using negocio;

namespace WinFormsApp1
{
    public partial class frmArticulos : Form
    {
        private List<Articulo> listaArticulo;

        public frmArticulos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulo = negocio.Listar();
            dgvArticulos.DataSource = listaArticulo;

        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null)
                return;

            Articulo seleccionado = dgvArticulos.CurrentRow.DataBoundItem as Articulo;

            if (seleccionado == null)
                return;

            ImagenNegocio imgNegocio = new ImagenNegocio();
            List<Imagen> imagenes = imgNegocio.ListarImagenPorArticulo(seleccionado.Id);

            if (imagenes != null && imagenes.Count > 0)
                cargarImagen(imagenes[0].ImagenUrl);
            else
                cargarImagen("https://via.placeholder.com/150");
        }
        /*private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            ImagenNegocio imgNegocio = new ImagenNegocio();
            List<Imagen> imagenes = imgNegocio.ListarImagenPorArticulo(seleccionado.Id);
            cargarImagen(imagenes[0].ImagenUrl);
        }*/
        private void cargarImagen(string url)
        {
            try
            {
                pbArticulo.Load(url);
            }
            catch (Exception ex)
            {
                pbArticulo.Load("https://t4.ftcdn.net/jpg/06/57/37/01/360_F_657370150_pdNeG5pjI976ZasVbKN9VqH1rfoykdYU.jpg");

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
        }
    }
}
