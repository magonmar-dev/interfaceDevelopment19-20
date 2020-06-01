using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidades
{
    public class Marca
    {
        public string MarcaID { get; set; }
        public string Empresa { get; set; }
        public string Logo { get; set; }

        public Marca(string marcaID, string empresa, string logo)
        {
            MarcaID = marcaID;
            Empresa = empresa;
            Logo = logo;
        }
    }
}
