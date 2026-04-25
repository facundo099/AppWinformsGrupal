using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select Id, Descripcion from CATEGORIAS");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
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

        public void agregar(Categoria nueva)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT INTO CATEGORIAS (Descripcion) VALUES (@descripcion)");
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
        public void eliminarLogicaCategoria(int id)
        {
            //try
            //{
            //    AccesoDatos datos = new AccesoDatos();
            //    datos.setearConsulta("UPDATE CATEGORIAS SET Estado = 0 WHERE Id = @id");
            //    datos.setearParametro("@id", id);
            //    datos.ejecutarAccion();
            //}
            //catch (Exception ex)
            //{

            //    throw ex;
            //}
        }
        public void eliminarFisico(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("DELETE FROM CATEGORIAS WHERE Id = @Id");
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

        public void Modificar(Categoria modificado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update CATEGORIAS set Descripcion = @descripcion WHERE Id = @id");
                datos.setearParametro("@descripcion", modificado.Descripcion);
                datos.setearParametro("@id", modificado.Id);
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

        public int contarArticulosPorCategoria(int idCategoria)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT COUNT(*) FROM ARTICULOS WHERE IdCategoria = @id");
                datos.setearParametro("@id", idCategoria);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                    return (int)datos.Lector[0];

                return 0;
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


    }
}