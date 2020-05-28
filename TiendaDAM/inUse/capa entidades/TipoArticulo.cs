using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidades
{
    public class TipoArticulo
    {
        public string TipoArticuloID { get; set; }
        public string Descripcion { get; set; }

        public TipoArticulo(string tipoArticuloID, string descripcion)
        {
            TipoArticuloID = tipoArticuloID;
            Descripcion = descripcion;
        }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
