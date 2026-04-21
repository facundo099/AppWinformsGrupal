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
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulo = negocio.Listar();
            dgvArticulos.DataSource = listaArticulo;

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


    }
}
