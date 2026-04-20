using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using dominio;

namespace negocio
{
    public class ImagenNegocio
    {
        public List<Imagen> ListarImagenPorArticulo(int idArticulo)
        {
            List<Imagen> lista = new List<Imagen>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                //conexion.ConnectionString = "server=localhost,1433;database=CATALOGO_P3_DB;User Id=sa;Password=BaseDatos#2;TrustServerCertificate=True;Encrypt=True";
                //conexion.ConnectionString = "server=localhost\\SQLEXPRESS;database=CATALOGO_P3_DB;integrated security=true;TrustServerCertificate=true";
                conexion.ConnectionString = "server=(localdb)\\MSSQLLocalDB;database=CATALOGO_P3_DB;integrated security=true;TrustServerCertificate=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT id, idArticulo, ImagenUrl FROM dbo.IMAGENES WHERE IdArticulo = @id";
                comando.Parameters.AddWithValue("@id", idArticulo);
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Imagen aux = new Imagen();

                    aux.Id = (int)lector["Id"];
                    aux.IdArticulo = (int)lector["IdArticulo"];
                    aux.ImagenUrl = (string)lector["ImagenUrl"];


                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }


        }
    }
}