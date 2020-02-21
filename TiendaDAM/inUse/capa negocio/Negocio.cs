using capa_datos;
using capa_entidades;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace capa_negocio
{
    public class Negocio
    {
        private Datos bd;
        private List<Usuario> listaUsuarios;
        private List<Provincia> listaProvincias;
        private List<Localidad> listaLocalidades;

        public Negocio()
        {
            bd = new Datos();
            listaUsuarios = bd.LeerUsuarios();
            listaProvincias = bd.LeerProvincias();
            listaLocalidades = bd.LeerLocalidades();
        }

        public List<Usuario> GetUsuarios() { return bd.LeerUsuarios(); }

        public List<Provincia> GetProvincias() { return listaProvincias; }

        public List<Localidad> GetLocalidades() { return listaLocalidades; }

        public bool Validar(string us, string ps)
        {
            if (listaUsuarios != null)
            {
                for (int i = 0; i < listaUsuarios.Count; i++)
                {
                    if ((listaUsuarios[i].Nombre == us) &&
                        (listaUsuarios[i].Password == codifica_MD5(ps)))
                        return (true);
                }
            }
            return (false);
        }
        
        public bool Insertar(int id, string email, string contra, string nom, string ape,
            string dni, string tel, string calle, string calle2, string cod, string pueID,
            string proID, string nac)
        {
            string contraCod = codifica_MD5(contra);
            return (bd.Insertar(id, email, contraCod, nom, ape, dni, tel, calle, calle2, cod, pueID, proID, nac));
        }

        public string codifica_MD5(string pas)
        {
            int i;
            MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(pas));

            pas = "";
            for (i = 0; i < data.Length; i++)
            {
                pas = pas + data[i];
            }

            return pas;
        }
    }
}
