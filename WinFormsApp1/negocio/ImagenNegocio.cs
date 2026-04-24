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
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setearConsulta("Select id, idArticulo, ImagenUrl FROM IMAGENES WHERE idArticulo = @idArticulo");
                datos.setearParametro("@idArticulo", idArticulo);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {



                    Imagen aux = new Imagen();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.IdArticulo = (int)datos.Lector["IdArticulo"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
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
                datos.cerrarConexion();
            }
        }
        public void agregar(Imagen nueva)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@idArticulo, @imagenUrl)");
                datos.setearParametro("@idArticulo", nueva.IdArticulo);
                datos.setearParametro("@imagenUrl", nueva.ImagenUrl);
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
        public void modificar(Imagen img)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("UPDATE IMAGENES SET ImagenUrl = @url WHERE IdArticulo = @idArticulo");
                datos.setearParametro("@url", img.ImagenUrl);
                datos.setearParametro("@idArticulo", img.IdArticulo);
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