using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidades
{
    public class Cesta
    {
        public string ArticuloID { get; set; }
        public string UsuarioID { get; set; }
        public string Fecha { get; set; }

        public Cesta(string articuloID, string usuarioID, string fecha)
        {
            ArticuloID = articuloID;
            UsuarioID = usuarioID;
            Fecha = fecha;
        }
    }
}
