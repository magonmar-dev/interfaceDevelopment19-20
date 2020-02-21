using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidades
{
    class Tv
    {
        public string TvID { get; set; }
        public string Panel { get; set; }
        public int Pantalla { get; set; }
        public string Resolucion { get; set; }
        public string HDReadyFullHD { get; set; }
        public int Tdt { get; set; }

        public Tv(string tvID, string panel, int pantalla, 
            string resolucion, string hDReadyFullHD, int tdt)
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
