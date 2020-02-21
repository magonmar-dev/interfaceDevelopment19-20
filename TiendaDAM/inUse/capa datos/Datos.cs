using capa_entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
                HttpResponseMessage response = client.GetAsync("api/Usuarios").Result;
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
                HttpResponseMessage response = client.GetAsync("api/Provincias").Result;
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
                HttpResponseMessage response = client.GetAsync("api/Localidades").Result;
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
        
        public bool Insertar(int id,string email, string contra, string nom, string ape, 
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
    }
}
