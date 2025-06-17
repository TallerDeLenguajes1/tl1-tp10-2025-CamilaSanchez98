using System.Text.Json;
using EspacioClases;

namespace EspacioApis
{
    public class Api
    {
        private static readonly HttpClient client = new HttpClient();

        //este metodo estático no retornaa nada, me deserealiza las tareas y las muestra
        public static async Task GetTask()
        {
            var url = "https://jsonplaceholder.typicode.com/todos/";
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode(); //lanza un error
            string responseBody = await response.Content.ReadAsStringAsync();
            List<Tarea>? tareas = JsonSerializer.Deserialize<List<Tarea>>(responseBody); //puede ser null por eso el '?'

            if (tareas != null)
            {
                foreach (var tarea in tareas)
                {
                    Console.WriteLine("ID DE USUARIO: " + tarea.userId);
                    Console.WriteLine("ID DE Tarea: " + tarea.id);
                    Console.WriteLine("Contenido: " + tarea.title);
                    Console.WriteLine("Estado (TRUE = Realizada): " + tarea.completed);
                    Console.WriteLine("---------------------------------");
                }
            }
        }

        //metodo estatico que retorna una lista de tareas
        public static async Task<List<Tarea>> GetTareasAsync()
        {
            var url = "https://jsonplaceholder.typicode.com/todos/";
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            List<Tarea>? tareas = JsonSerializer.Deserialize<List<Tarea>>(responseBody);
            return tareas ?? new List<Tarea>();
        }

    }
}