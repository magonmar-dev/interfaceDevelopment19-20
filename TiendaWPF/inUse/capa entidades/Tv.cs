using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidades
{
    public class Tv
    {
        public string TvID { get; set; }
        public string Panel { get; set; }
        public string Pantalla { get; set; }
        public string Resolucion { get; set; }
        public string HDReadyFullHD { get; set; }
        public bool Tdt { get; set; }

        public Tv(string tvID, string panel, string pantalla, 
            string resolucion, string hDReadyFullHD, bool tdt)
        {
            TvID = tvID;
            Panel = panel;
            Pantalla = pantalla;
            Resolucion = resolucion;
            HDReadyFullHD = hDReadyFullHD;
            Tdt = tdt;
        }
    }
}
