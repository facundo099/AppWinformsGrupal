using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion = null!;
        private SqlCommand comando = null!;
        private SqlDataReader lector;
        public SqlDataReader Lector
        {
            get {  return lector; }
        }

        public AccesoDatos()
        {

           // conexion = new SqlConnection("server=localhost,1433;database=CATALOGO_P3_DB;User Id=sa;Password=BaseDatos#2;TrustServerCertificate=True;Encrypt=True");
           // conexion = new SqlConnection("server=localhost\\SQLEXPRESS;database=CATALOGO_P3_DB;integrated security=true;TrustServerCertificate=true");
           //conexion = new SqlConnection("server=(localdb)\\MSSQLLocalDB;database=CATALOGO_P3_DB;integrated security=true;TrustServerCertificate=true");

            //conexion = new SqlConnection("server=localhost,1433;database=CATALOGO_P3_DB;User Id=sa;Password=BaseDatos#2;TrustServerCertificate=True;Encrypt=True");
            conexion = new SqlConnection("server=localhost\\SQLEXPRESS;database=CATALOGO_P3_DB;integrated security=true;TrustServerCertificate=true");
           //conexion = new SqlConnection("server=(localdb)\\MSSQLLocalDB;database=CATALOGO_P3_DB;integrated security=true;TrustServerCertificate=true");
            comando = new SqlCommand();
        }
        public void setearConsulta(string consulta)
        {
            comando.Parameters.Clear();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;

        }
        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //throw ex;
            }
        }
        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        }
        public void setearParametro(string nombre, object valor)
        {
            
            comando.Parameters.AddWithValue(nombre, valor);
        }
        

    }
}
