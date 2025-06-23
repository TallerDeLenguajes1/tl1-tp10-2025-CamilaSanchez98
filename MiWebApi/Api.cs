using System.Text.Json;
using EspacioClases;

namespace EspacioApis
{
    public class Api
    {
        private static readonly HttpClient client = new HttpClient();
        public static async Task<List<Root>> GetTareasAsync()
        {
            var url = "https://jsonplaceholder.typicode.com/posts";
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            List<Root>? lista = JsonSerializer.Deserialize<List<Root>>(responseBody);
            return lista ?? new List<Root>();
        }

    }
}