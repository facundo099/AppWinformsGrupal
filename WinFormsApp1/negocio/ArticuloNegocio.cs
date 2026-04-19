using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=localhost,1433;database=CATALOGO_P3_DB;User Id=sa;Password=BaseDatos#2;TrustServerCertificate=True;Encrypt=True";
                //conexion.ConnectionString = "server=localhost\\SQLEXPRESS;database=CATALOGO_P3_DB;integrated security=true;TrustServerCertificate=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Id, Codigo, Nombre, Descripcion From ARTICULOS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    

                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT A.Id, Codigo, Nombre, A.Descripcion, Precio, M.Descripcion Marca, C.Descripcion Categoria,a.IdMarca,a.IdCategoria FROM ARTICULOS A, MARCAS M, CATEGORIAS C WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id");
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

    }
}
