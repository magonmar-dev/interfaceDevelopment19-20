using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidades
{
    class Camara
    {
        public string CamaraID { get; set; }
        public string Resolucion { get; set; }
        public string Sensor { get; set; }
        public string Tipo { get; set; }
        public string Factor { get; set; }
        public string Objetivo { get; set; }
        public string Pantalla { get; set; }
        public string Zoom { get; set; }

        public Camara(string camaraID, string resolucion, string sensor, 
            string tipo, string factor, string objetivo, string pantalla, 
            string zoom)
        {
            CamaraID = camaraID;
            Resolucion = resolucion;
            Sensor = sensor;
            Tipo = tipo;
            Factor = factor;
            Objetivo = objetivo;
            Pantalla = pantalla;
            Zoom = zoom;
        }
    }
}
