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

                datos.setearConsulta("Select id, idArticulo, ImagenUrl FROM IMAGENES");
                
                datos.ejecutarLectura();
          
                while (datos.Lector.Read())
                {
                    int idArt = (int)datos.Lector["IdArticulo"];

                    if (idArt == idArticulo)
                    {

                        Imagen aux = new Imagen();

                        aux.Id = (int)datos.Lector["Id"];
                        aux.IdArticulo = (int)datos.Lector["IdArticulo"];
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                        lista.Add(aux);
                    }
                }

                return lista;
            }
          
            finally
            {
                datos.cerrarConexion();
            }


        }
    }
}