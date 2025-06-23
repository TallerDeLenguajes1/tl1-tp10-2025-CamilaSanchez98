using EspacioApis;
using EspacioClases;
using EspacioHelpers;
using System.Text.Json;

/*EJERCICIO 2*/

//Deserializacion:
List<Root> posteos = await Api.GetTareasAsync();
MiHelper.MostrarPosteos(posteos);

//Serializacion:
string jsonString = JsonSerializer.Serialize(posteos, new JsonSerializerOptions { WriteIndented = true });
string filePath = "posteos.json";

try
{
    await File.WriteAllTextAsync(filePath, jsonString);
    Console.WriteLine($"La lista de posteos ha sido serializada y guardada en {filePath}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocurrió un error al intentar guardar el archivo en {filePath}.");
    Console.WriteLine($"Detalles del error: {ex.Message}");
    Console.WriteLine($"Tipo de error (.Name): {ex.GetType().Name}"); 
}

