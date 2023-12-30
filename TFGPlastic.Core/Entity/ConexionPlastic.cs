using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace TFGPlastic.Core.Entity
{
    public class ConexionPlastic : ControllerBase
    {
        public static HttpClient GetHttpClient()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:9090/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }
        public static async Task<List<WorkSpace>> mostrarWorkSpaces()
        {
            HttpClient client = GetHttpClient();

            
            var httpClient = GetHttpClient();
            HttpResponseMessage response = await httpClient.GetAsync("/api/v1/wkspaces");

            if (response.IsSuccessStatusCode)
            {
                // Deserializa la respuesta en una lista de WorkSpaces
                var workspaces = await response.Content.ReadAsAsync<List<WorkSpace>>();
                return workspaces;
            }
            else
            {
                // Manejar el error de la solicitud HTTP según sea necesario 
                return new List<WorkSpace>();
            }
        }

        [HttpPost]
        public static async void WorkSpaceCreate(string nombre, string ruta)
        {
            HttpClient httpClient = GetHttpClient();

            // Create a WorkSpace object with the provided name and path
            var newWorkspace = new WorkSpace { Name = nombre, Path = ruta };

            // Convert WorkSpace object to JSON
            var jsonPayload = JsonConvert.SerializeObject(newWorkspace);

            // Create StringContent with JSON payload
            var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            // Make a POST request to create a new workspace
            HttpResponseMessage response = await httpClient.PostAsync("/api/v1/wkspaces/", content);

            if (response.IsSuccessStatusCode)
            {
                // Deserializa la respuesta en una lista de WorkSpaces
                await response.Content.ReadAsAsync<List<WorkSpace>>();
                
            }
            else
            {
                 // Manejar el error de la solicitud HTTP según sea necesario 
              
            }
        }

        public static async void Eliminar(string nombre)
        {
            HttpClient httpClient = GetHttpClient();

            // Make a POST request to create a new workspace
            HttpResponseMessage response = await httpClient.DeleteAsync("/api/v1/wkspaces/" + nombre);

            if (response.IsSuccessStatusCode)
            {
                // Deserializa la respuesta en una lista de WorkSpaces
                await response.Content.ReadAsAsync<List<WorkSpace>>();

            }
            else
            {
                // Manejar el error de la solicitud HTTP según sea necesario 

            }
        }


        public static async Task<List<TaskEntityPlastic>> ListarTareas(string nombre)
        {
            HttpClient client = GetHttpClient();

            var httpClient = GetHttpClient();
            HttpResponseMessage response = await httpClient.GetAsync("/api/v1/wkspaces/"+nombre+"/changes");

            if (response.IsSuccessStatusCode)
            {
                // Deserializa la respuesta en una lista de WorkSpaces
                var tasks = await response.Content.ReadAsAsync<List<TaskEntityPlastic>>();
                return tasks;
            }
            else
            {
                // Manejar el error de la solicitud HTTP según sea necesario 
                return new List<TaskEntityPlastic>();
            }
        }

    }
}
