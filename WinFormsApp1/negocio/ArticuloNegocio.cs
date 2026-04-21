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
            AccesoDatos datos = new AccesoDatos();
           // ImagenNegocio imgNegocio = new ImagenNegocio();
            
            try
            {
                datos.setearConsulta("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Id AS IdMarca, M.Descripcion AS Marca,  C.Id AS IdCategoria,C.Descripcion AS Categoria,  A.Precio     FROM ARTICULOS A LEFT JOIN MARCAS M ON M.Id = A.IdMarca  LEFT JOIN CATEGORIAS C ON C.Id = A.IdCategoria");
                // datos.setearConsulta("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion,\r\n    M.Id AS IdMarca, M.Descripcion AS Marca, \r\n    C.Id AS IdCategoria, C.Descripcion AS Categoria \r\n    FROM ARTICULOS A \r\n    LEFT JOIN MARCAS M ON M.Id = A.IdMarca \r\n    LEFT JOIN CATEGORIAS C ON C.Id = A.IdCategoria");
               // datos.setearConsulta("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion,\r\n       M.Id AS IdMarca, M.Descripcion AS Marca,\r\n       C.Id AS IdCategoria, C.Descripcion AS Categoria\r\nFROM ARTICULOS A\r\nINNER JOIN MARCAS M ON M.Id = A.IdMarca\r\nINNER JOIN CATEGORIAS C ON C.Id = A.IdCategoria");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (datos.Lector["Codigo"] is DBNull) ? "" : (string)datos.Lector["Codigo"];
                    aux.Nombre = (datos.Lector["Nombre"] is DBNull) ? "" : (string)datos.Lector["Nombre"];
                    aux.Descripcion = (datos.Lector["Descripcion"] is DBNull) ? "" : (string)datos.Lector["Descripcion"];
                    aux.Precio = (datos.Lector["Precio"] is DBNull) ? 0 : (decimal)datos.Lector["Precio"];

                    aux.Marca = new Marca();
                    if (!(datos.Lector["Marca"] is DBNull))
                    {
                        aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                        aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    }
                    
                    aux.Categoria = new Categoria();
                    if (!(datos.Lector["Categoria"] is DBNull))
                    {
                        aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                        aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    }
                   

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
        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, Precio, IdCategoria, IdMarca) " + "VALUES ('" + nuevo.Codigo + "', '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "', " + nuevo.Precio + ", " + nuevo.Categoria.Id + ", " + nuevo.Marca.Id + ")");
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
