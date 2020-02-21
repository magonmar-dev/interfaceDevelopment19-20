using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidades
{
    public class Provincia
    {
        public string ProvinciaID { get; set; }
        public string Nombre { get; set; }

        public Provincia(string provinciaID, string nombre)
        {
            ProvinciaID = provinciaID;
            Nombre = nombre;
        }
    }
}
