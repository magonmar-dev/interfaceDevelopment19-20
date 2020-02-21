using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidades
{
    class Ptienea
    {
        public string Pack { get; set; }
        public string Articulo { get; set; }

        public Ptienea(string pack, string articulo)
        {
            Pack = pack;
            Articulo = articulo;
        }
    }
}
