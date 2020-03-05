using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidades
{
    public class Pedido
    {
        public int PedidoID { get; set; }
        public int UsuarioID { get; set; }
        public string Fecha { get; set; }

        public Pedido(int pedidoID, int usuarioID, string fecha)
        {
            PedidoID = pedidoID;
            UsuarioID = usuarioID;
            Fecha = fecha;
        }
    }
}
