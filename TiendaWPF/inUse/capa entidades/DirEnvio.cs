using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidades
{
    public class DirEnvio
    {
        public string UsuarioID { get; set; }
        public string Calle { get; set; }
        public string Calle2 { get; set; }
        public string Codpos { get; set; }
        public string LocalidadID { get; set; }
        public string ProvinciaID { get; set; }

        public DirEnvio(string usuarioID, string calle, string calle2, 
            string codpos, string localidadID, string provinciaID)
        {
            UsuarioID = usuarioID;
            Calle = calle;
            Calle2 = calle2;
            Codpos = codpos;
            LocalidadID = localidadID;
            ProvinciaID = provinciaID;
        }
    }
}
