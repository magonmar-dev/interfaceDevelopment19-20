using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidades
{
    public class Stock
    {
        public string ArticuloID { get; set; }
        public int Disponible { get; set; }
        public string Entrega { get; set; }

        public Stock(string articuloID, int disponible, string entrega)
        {
            ArticuloID = articuloID;
            Disponible = disponible;
            Entrega = entrega;
        }
    }
}
