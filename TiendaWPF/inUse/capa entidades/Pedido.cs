using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidades
{
    public class Pedido
    {
        public string PedidoID { get; set; }
        public string UsuarioID { get; set; }
        public string Fecha { get; set; }

        public string UsuarioNombre { get; set; }

        public Pedido() {}

        public Pedido(string pedidoID, string usuarioID, string fecha)
        {
            PedidoID = pedidoID;
            UsuarioID = usuarioID;
            Fecha = fecha;
        }
    }
}
