using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidades
{
    public class Linped
    {
        public string PedidoID { get; set; }
        public string Linea { get; set; }
        public string ArticuloID { get; set; }
        public int Importe { get; set; }
        public int Cantidad { get; set; }
        public string ArticuloNombre { get; set; }

        public Linped() { }

        public Linped(string pedidoID, string linea, string articuloID, 
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
