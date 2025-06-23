using EspacioApis;
using EspacioClases;
using EspacioHelpers;
using System.Linq; //agregado desde .NET6
using System.Text.Json;
using System.IO; //agregado desde .NET6

/*EJERCICIO 1*/

//Deserializacion:
List<Tarea> tareas = await Api.GetTareasAsync();
TareaHelper.MostrarTareas(tareas);

List<Tarea> tareasOrdenadas = tareas.OrderBy(t => t.completed).ToList();
TareaHelper.MostrarTareas(tareasOrdenadas);

//Serializacion:
string jsonString = JsonSerializer.Serialize(tareas, new JsonSerializerOptions { WriteIndented = true });
string filePath = "tareas.json";

try
{
    await File.WriteAllTextAsync(filePath, jsonString);
    Console.WriteLine($"La lista de tareas ha sido serializada y guardada en {filePath}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocurrió un error al intentar guardar el archivo en {filePath}.");
    Console.WriteLine($"Detalles del error: {ex.Message}");
    Console.WriteLine($"Tipo de error (.Name): {ex.GetType().Name}"); // Para ver el tipo específico de excepción
}
