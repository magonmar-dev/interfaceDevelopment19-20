using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidades
{
    class Objetivo
    {
        public string ObjetivoID { get; set; }
        public string Tipo { get; set; }
        public string Montura { get; set; }
        public string Focal { get; set; }
        public string Apertura { get; set; }
        public string Especiales { get; set; }

        public Objetivo(string objetivoID, string tipo, string montura, 
            string focal, string apertura, string especiales)
        {
            ObjetivoID = objetivoID;
            Tipo = tipo;
            Montura = montura;
            Focal = focal;
            Apertura = apertura;
            Especiales = especiales;
        }
    }
}
