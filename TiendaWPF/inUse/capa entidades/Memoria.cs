using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidades
{
    public class Memoria
    {
        public string MemoriaID { get; set; }
        public string Tipo { get; set; }

        public Memoria(string memoriaID, string tipo)
        {
            MemoriaID = memoriaID;
            Tipo = tipo;
        }
    }
}
