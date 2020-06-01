using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidades
{
    public class Usuario
    {
        public string UsuarioID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        public string Telefono { get; set; }
        public string Calle { get; set; }
        public string Calle2 { get; set; }
        public string Codpos { get; set; }
        public string PuebloID { get; set; }
        public string ProvinciaID { get; set; }
        public string Nacido { get; set; }

        public Usuario(string usuarioID, string email, string contra, string nombre, string apellidos, string dni, string telefono, string calle, string calle2, string codpos, string puebloID, string provinciaID, string nacido)
        {
            UsuarioID = usuarioID;
            Email = email;
            Password = contra;
            Nombre = nombre;
            Apellidos = apellidos;
            Dni = dni;
            Telefono = telefono;
            Calle = calle;
            Calle2 = calle2;
            Codpos = codpos;
            PuebloID = puebloID;
            ProvinciaID = provinciaID;
            Nacido = nacido;
        }

        public override string ToString()
        {
            return Nombre + " (" + Dni + ")";
        }
    }
}
