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
            

            try
            {
                datos.setearConsulta(@"SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, M.Id AS IdMarca, M.Descripcion AS Marca,  C.Id AS IdCategoria,C.Descripcion AS Categoria FROM ARTICULOS A LEFT JOIN MARCAS M ON M.Id = A.IdMarca  LEFT JOIN CATEGORIAS C ON C.Id = A.IdCategoria");
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


                    if (!(datos.Lector["Marca"] is DBNull))
                    {
                        aux.Marca = new Marca();
                        aux.Marca.Id = (int)datos.Lector["IdMarca"];
                        aux.Marca.Descripcion = (string)datos.Lector["Marca"];

                    }


                    if (!(datos.Lector["Categoria"] is DBNull))
                    {
                        aux.Categoria = new Categoria();
                        aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                        aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];

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
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, Precio, IdCategoria, IdMarca) VALUES (@Codigo, @Nombre, @Descripcion, @Precio, @IdCategoria, @IdMarca)");

                datos.setearParametro("@Codigo", nuevo.Codigo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@Precio", nuevo.Precio);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.Id);
                datos.setearParametro("@IdMarca", nuevo.Marca.Id);

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
        public void modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE ARTICULOS SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, Precio = @Precio, IdCategoria = @IdCategoria, IdMarca = @IdMarca WHERE Id = @Id ");
                datos.setearParametro("@Codigo", articulo.Codigo);
                datos.setearParametro("@Nombre", articulo.Nombre);
                datos.setearParametro("@Descripcion", articulo.Descripcion);
                datos.setearParametro("@Precio", articulo.Precio);
                datos.setearParametro("@IdCategoria", articulo.Categoria.Id);
                datos.setearParametro("@IdMarca", articulo.Marca.Id);
                datos.setearParametro("@Id", articulo.Id);
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
        //implementar eliminado lógico cuando exista la columna Activo en DB
        public void eliminarLogico(int id)
        {
            /*
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE ARTICULOS set Activo = 0 WHERE Id = @Id");
                datos.setearParametro("@Id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }*/
        }

        public void eliminarFisico(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("DELETE FROM ARTICULOS WHERE Id = @Id");
                datos.setearParametro("@Id", id);
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

        public void eliminarPorCategoria(int idCategoria)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("DELETE FROM ARTICULOS WHERE IdCategoria = @id");
                datos.setearParametro("@id", idCategoria);
                datos.ejecutarAccion();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminarPorMarca(int idMarca)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("DELETE FROM ARTICULOS WHERE IdMarca = @id");
                datos.setearParametro("@id", idMarca);
                datos.ejecutarAccion();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public List<Articulo> BuscarArticulo(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = @"SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio,
                            M.Id AS IdMarca, M.Descripcion AS Marca,
                            C.Id AS IdCategoria, C.Descripcion AS Categoria
                            FROM ARTICULOS A
                            LEFT JOIN MARCAS M ON M.Id = A.IdMarca
                            LEFT JOIN CATEGORIAS C ON C.Id = A.IdCategoria WHERE 1=1  ";
                
                if (campo == "Nombre")
                {
                    if (criterio == "Contiene")
                        consulta += " AND A.Nombre LIKE '%" + filtro + "%'";
                    else if (criterio == "Comienza con")
                        consulta += " AND A.Nombre LIKE '" + filtro + "%'";
                }
                else if (campo == "Marca")
                {
                    consulta += " AND M.Descripcion LIKE '%" + filtro + "%'";
                }
                else if (campo == "Precio")
                {
                    if (criterio == "Mayor a")
                        consulta += " AND A.Precio > " + filtro;
                    else if (criterio == "Menor a")
                        consulta += " AND A.Precio < " + filtro;
                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (datos.Lector["Codigo"] is DBNull) ? "" : (string)datos.Lector["Codigo"];
                    aux.Nombre = (datos.Lector["Nombre"] is DBNull) ? "" : (string)datos.Lector["Nombre"];
                    aux.Descripcion = (datos.Lector["Descripcion"] is DBNull) ? "" : (string)datos.Lector["Descripcion"];
                    aux.Precio = (datos.Lector["Precio"] is DBNull) ? 0 : (decimal)datos.Lector["Precio"];


                    if (!(datos.Lector["Marca"] is DBNull))
                    {
                        aux.Marca = new Marca();
                        aux.Marca.Id = (int)datos.Lector["IdMarca"];
                        aux.Marca.Descripcion = (string)datos.Lector["Marca"];

                    }


                    if (!(datos.Lector["Categoria"] is DBNull))
                    {
                        aux.Categoria = new Categoria();
                        aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                        aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];

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
        
       
    }
}
