using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidades
{
    class TipoArticulo
    {
        public int TipoArticuloID { get; set; }
        public string Descripcion { get; set; }

        public TipoArticulo(int tipoArticuloID, string descripcion)
        {
            TipoArticuloID = tipoArticuloID;
            Descripcion = descripcion;
        }
    }
}
