using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidades
{
    class Articulo
    {
        public string ArticuloID { get; set; }
        public string Nombre { get; set; }
        public int Pvp { get; set; }
        public string MarcaID { get; set; }
        public string Imagen { get; set; }
        public string UrlImagen { get; set; }
        public string Especificaciones { get; set; }
        public int TipoArticuloID { get; set; }

        public Articulo(string articuloID, string nombre, int pvp, 
            string marcaID, string imagen, string urlImagen, 
            string especificaciones, int tipoArticuloID)
        {
            ArticuloID = articuloID;
            Nombre = nombre;
            Pvp = pvp;
            MarcaID = marcaID;
            Imagen = imagen;
            UrlImagen = urlImagen;
            Especificaciones = especificaciones;
            TipoArticuloID = tipoArticuloID;
        }
    }
}
