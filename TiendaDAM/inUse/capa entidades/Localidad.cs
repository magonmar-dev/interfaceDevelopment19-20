using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidades
{
    public class Localidad
    {
        public string LocalidadID { get; set; }
        public string Nombre { get; set; }
        public string ProvinciaID { get; set; }

        public Localidad(string localidadID, string nombre, string provinciaID)
        {
            LocalidadID = localidadID;
            Nombre = nombre;
            ProvinciaID = provinciaID;
        }
    }
}
