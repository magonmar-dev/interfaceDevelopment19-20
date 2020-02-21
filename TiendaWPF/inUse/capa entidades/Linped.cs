using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidades
{
    class Linped
    {
        public int PedidoID { get; set; }
        public int Linea { get; set; }
        public string ArticuloID { get; set; }
        public int Importe { get; set; }
        public int Cantidad { get; set; }

        public Linped(int pedidoID, int linea, string articuloID, 
            int importe, int cantidad)
        {
            PedidoID = pedidoID;
            Linea = linea;
            ArticuloID = articuloID;
            Importe = importe;
            Cantidad = cantidad;
        }
    }
}
