using capa_entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

namespace capa_datos
{
    public class Datos
    {
        HttpClient client = new HttpClient();

        public Datos()
        {
            client.BaseAddress = new Uri("https://localhost:44384/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = TimeSpan.FromMinutes(10);
        }

        public List<Usuario> LeerUsuarios()
        {
            List<Usuario> listaUsuarios = null;
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/usuarios").Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;
                    listaUsuarios = JsonConvert.DeserializeObject<List<Usuario>>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return listaUsuarios;
        }

        public List<Provincia> LeerProvincias()
        {
            List<Provincia> listaProvincias = null;
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/provincias").Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;
                    listaProvincias = JsonConvert.DeserializeObject<List<Provincia>>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return listaProvincias;
        }

        public List<Localidad> LeerLocalidades()
        {
            List<Localidad> listaLocalidades = null;
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/localidades").Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;
                    listaLocalidades = JsonConvert.DeserializeObject<List<Localidad>>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return listaLocalidades;
        }

        // Leer todas las localidades de una provincia
        public List<Localidad> LeerLocalidades(string provinciaID)
        {
            List<Localidad> listaLocalidades = null;

            listaLocalidades = (from localidad in LeerLocalidades().AsParallel()
                                where localidad.ProvinciaID.Equals(provinciaID)
                                select localidad).ToList<Localidad>();

            return listaLocalidades;
        }

        public List<Articulo> LeerProductos()
        {
            List<Articulo> listaProductos = null;
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/articulos").Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;
                    listaProductos = JsonConvert.DeserializeObject<List<Articulo>>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return listaProductos;
        }

        public List<TipoArticulo> LeerTiposArticulo()
        {
            List<TipoArticulo> listaTipos = null;
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/tipoArticulos").Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;
                    listaTipos = JsonConvert.DeserializeObject<List<TipoArticulo>>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return listaTipos;
        }

        public List<Pedido> LeerPedidos()
        {
            List<Pedido> listaPedidos = null;
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/pedidos").Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;
                    listaPedidos = JsonConvert.DeserializeObject<List<Pedido>>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return listaPedidos;
        }

        public List<Marca> LeerMarcas()
        {
            List<Marca> listaMarcas = null;
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/marcas").Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;
                    listaMarcas = JsonConvert.DeserializeObject<List<Marca>>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return listaMarcas;
        }

        public List<Memoria> LeerMemorias()
        {
            List<Memoria> listaMemorias = null;
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/memorias").Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;
                    listaMemorias = JsonConvert.DeserializeObject<List<Memoria>>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return listaMemorias;
        }

        public List<Tv> LeerTVs()
        {
            List<Tv> listaTVs = null;
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/tvs").Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;
                    listaTVs = JsonConvert.DeserializeObject<List<Tv>>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return listaTVs;
        }

        public List<Objetivo> LeerObjetivos()
        {
            List<Objetivo> listaObjetivos = null;
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/objetivos").Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;
                    listaObjetivos = JsonConvert.DeserializeObject<List<Objetivo>>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return listaObjetivos;
        }

        public List<Camara> LeerCamaras()
        {
            List<Camara> listaCamaras = null;
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/camaras").Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;
                    listaCamaras = JsonConvert.DeserializeObject<List<Camara>>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return listaCamaras;
        }

        public List<Linped> LeerLinped()
        {
            List<Linped> lineasPedido = null;
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/linped").Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    lineasPedido = JsonConvert.DeserializeObject<List<Linped>>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return lineasPedido;
        }

        public Usuario GetUsuario(string id)
        {
            Usuario usuario = null;
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/usuarios/" + id).Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    usuario = JsonConvert.DeserializeObject<Usuario>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return usuario;
        }

        public Articulo GetArticulo(string id)
        {
            Articulo articulo = null;
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/articulos/" + id).Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    articulo = JsonConvert.DeserializeObject<Articulo>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return articulo;
        }

        public TipoArticulo GetTipo(string id)
        {
            TipoArticulo tipo = null;
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/tipoArticulos/" + id).Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    tipo = JsonConvert.DeserializeObject<TipoArticulo>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return tipo;
        }

        public Pedido GetPedido(string id)
        {
            Pedido pedido = null;
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/pedidos/" + id).Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    pedido = JsonConvert.DeserializeObject<Pedido>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return pedido;
        }

        public Linped GetLinped(string pedidoId, string linea)
        {
            Linped linped = null;
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/linped/" + pedidoId + ":" + linea).Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    linped = JsonConvert.DeserializeObject<Linped>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return linped;
        }

        public bool InsertarUsuario(string id, string email, string contra, string nom, string ape,
            string dni, string tel, string calle, string calle2, string cod, string pueID,
            string proID, string nac)
        {
            try
            {
                Usuario usu = new Usuario(id, email, contra, nom, ape, dni, tel, calle, calle2, cod, pueID, proID, nac);

                HttpResponseMessage response = client.PostAsJsonAsync("api/usuarios", usu).Result;

                if (response.IsSuccessStatusCode)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return true;
        }

        public bool ModificarUsuario(string id, string email, string contra, string nom, string ape,
            string dni, string tel, string calle, string calle2, string cod, string pueID,
            string proID, string nac)
        {
            try
            {
                Usuario usu = new Usuario(id, email, contra, nom, ape, dni, tel, calle, calle2, cod, pueID, proID, nac);
                HttpResponseMessage response = client.PutAsJsonAsync($"api/usuarios/{id}", usu).Result;

                if (response.IsSuccessStatusCode)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return true;
        }

        public bool EliminarUsuario(string id)
        {
            try
            {
                HttpResponseMessage response = client.DeleteAsync($"api/usuarios/{id}").Result;

                if (response.IsSuccessStatusCode)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return true;
        }

        public bool ModificarArticulo(string id, string nom, string pvp,
            string marca, string img, string urlImg,
            string especs, string tipo)
        {
            try
            {
                Articulo articulo = new Articulo(id, nom, pvp, marca, img, urlImg, especs, tipo);
                HttpResponseMessage response = client.PutAsJsonAsync($"api/articulos/{id}", articulo).Result;

                if (response.IsSuccessStatusCode)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return true;
        }

        public bool InsertarPedido(string pedidoId, string usuarioId, string fecha)
        {
            try
            {
                Pedido ped = new Pedido(pedidoId, usuarioId, fecha);

                HttpResponseMessage response = client.PostAsJsonAsync("api/pedidos", ped).Result;

                if (response.IsSuccessStatusCode)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return true;
        }

        public bool EliminarPedido(string pedidoId)
        {
            try
            {
                HttpResponseMessage response = client.DeleteAsync("api/pedidos/" + pedidoId).Result;

                if (response.IsSuccessStatusCode)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return true;
        }

        public bool InsertarLinped(string pedidoId, string linea, string productoId,
            int importe, int cantidad)
        {
            try
            {
                Linped lp = new Linped(pedidoId, linea, productoId, importe, cantidad);

                HttpResponseMessage response = client.PostAsJsonAsync("api/linped", lp).Result;

                if (response.IsSuccessStatusCode)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return true;
        }

        public bool EliminarLinped(string pedidoId, string linea)
        {
            try
            {
                HttpResponseMessage response = client.DeleteAsync("api/linped/" + pedidoId + ":" + linea).Result;

                if (response.IsSuccessStatusCode)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return true;
        }
    }
}
