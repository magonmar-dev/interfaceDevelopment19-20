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
            List<Usuario> listaUsuarios=null;
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

        // Leer un usuario de la BD
        public Usuario GetUsuario(string id)
        {
            Usuario usuarios = null;
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/usuarios/" + id).Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    usuarios = JsonConvert.DeserializeObject<Usuario>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return usuarios;
        }

        public bool InsertarUsuario(int id,string email, string contra, string nom, string ape, 
            string dni, string tel, string calle, string calle2, string cod, string pueID, 
            string proID, string nac)
        {

            try
            {
                Usuario usu = new Usuario(id,email,contra,nom,ape,dni,tel,calle,calle2,cod,pueID,proID,nac);

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

        public bool ModificarUsuario(int id, string email, string contra, string nom, string ape,
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

        public bool EliminarUsuario(int id)
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
    }
}
