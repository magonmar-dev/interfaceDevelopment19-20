using capa_datos;
using capa_entidades;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace capa_negocio
{
    public class Negocio
    {
        private Datos bd;

        private List<Usuario> listaUsuarios;

        public Negocio()
        {
            bd = new Datos();
            listaUsuarios = GetUsuarios();
        }

        public Usuario GetUsuario(string id) { return bd.GetUsuario(id); }
        public Articulo GetArticulo(string id) { return bd.GetArticulo(id); }
        public TipoArticulo GetTipo(string id) { return bd.GetTipo(id); }
        public Pedido GetPedido(string id) { return bd.GetPedido(id); }

        public List<Usuario> GetUsuarios() { return bd.LeerUsuarios(); }
        public List<Provincia> GetProvincias() { return bd.LeerProvincias(); }
        public List<Localidad> GetLocalidades() { return bd.LeerLocalidades(); }
        public List<Localidad> GetLocalidades(string provinciaID) { return bd.LeerLocalidades(provinciaID); }
        public List<Articulo> GetProductos() { return bd.LeerProductos(); }
        public List<TipoArticulo> GetTiposArticulo() { return bd.LeerTiposArticulo(); }
        public List<Pedido> GetPedidos() { return bd.LeerPedidos(); }
        public List<Marca> GetMarcas() { return bd.LeerMarcas(); }
        public List<Memoria> GetMemorias() { return bd.LeerMemorias(); }
        public List<Tv> GetTVs() { return bd.LeerTVs(); }
        public List<Objetivo> GetObjetivos() { return bd.LeerObjetivos(); }
        public List<Camara> GetCamaras() { return bd.LeerCamaras(); }

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
        
        public bool InsertarUsuario(string id, string email, string contra, string nom, string ape,
            string dni, string tel, string calle, string calle2, string cod, string pueID,
            string proID, string nac)
        {
            string contraCod = codifica_MD5(contra);
            return (bd.InsertarUsuario(id, email, contraCod, nom, ape, dni, tel, calle, calle2, cod, pueID, proID, nac));
        }

        public bool ModificarUsuario(string id, string email, string contra, string nom, string ape,
            string dni, string tel, string calle, string calle2, string cod, string pueID,
            string proID, string nac)
        {
            return (bd.ModificarUsuario(id, email, contra, nom, ape, dni, tel, calle, calle2, cod, pueID, proID, nac));
        }

        public bool EliminarUsuario(string id)
        {
            return (bd.EliminarUsuario(id));
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

        public bool ModificarArticulo(string id, string nom, string pvp,
            string marca, string img, string urlImg,
            string especs, string tipo)
        {
            return (bd.ModificarArticulo(id, nom, pvp, marca, img, urlImg, especs, tipo));
        }

        public List<Linped> GetLinpeds(string idPedido)
        {
            List<Linped> aux = new List<Linped>();
            foreach (Linped l in bd.LeerLinped())
            {
                if (l.PedidoID == idPedido)
                    aux.Add(l);
            }
            return aux;
        }

        public float[] CalcFactura(float[] importes, int[] cantidades)
        {
            float totalSinIva = 0;
            float iva, total;

            for (int i=0; i < cantidades.Length; i++)
            {
                float totalLinea = importes[i] * cantidades[i];
                totalSinIva += totalLinea;
            }

            iva = totalSinIva * 0.21f;
            total = totalSinIva + iva;

            return new float[] { totalSinIva, iva, total };
        }

        public bool InsertarPedido(string pedidoId, string usuarioId, string fecha)
        {
            return (bd.InsertarPedido(pedidoId,usuarioId,fecha));
        }

        public bool EliminarPedido(string pedidoId)
        {
            return (bd.EliminarPedido(pedidoId));
        }

        public bool InsertarLinped(string pedidoId, string linea, string productoId,
            int importe, int cantidad)
        {
            return (bd.InsertarLinped(pedidoId,linea,productoId,importe,cantidad));
        }

        public bool EliminarLinpeds(string pedidoId)
        {
            bool errores = false;
            foreach (Linped l in GetLinpeds(pedidoId))
            {
                if (l.PedidoID == pedidoId)
                    if (!bd.EliminarLinped(pedidoId,l.Linea))
                        errores = true;
            }

            return errores;
        }
    }
}