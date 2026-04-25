using dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace negocio
{
    public static class HelperImagen
    {
        public static string CargarImagen(List<Imagen> imagenes, int indice)
        {
            try
            {
                if (imagenes != null && imagenes.Count > 0)
                    return imagenes[indice].ImagenUrl;
                else
                    throw new Exception();
            }
            catch { 
                return "https://t4.ftcdn.net/jpg/06/57/37/01/360_F_657370150_pdNeG5pjI976ZasVbKN9VqH1rfoykdYU.jpg";
            }
        }
    }
}
