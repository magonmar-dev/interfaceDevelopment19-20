using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidades
{
    class Memoria
    {
        public string MemorioID { get; set; }
        public string Tipo { get; set; }

        public Memoria(string memorioID, string tipo)
        {
            MemorioID = memorioID;
            Tipo = tipo;
        }
    }
}
