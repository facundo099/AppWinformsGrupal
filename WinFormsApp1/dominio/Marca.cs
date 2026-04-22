using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace dominio
{
    public class Marca
    {
        public int Id { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
