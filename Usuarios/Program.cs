using EspacioApis;
using EspacioClases;
using EspacioHelpers;
using System.Text.Json;

/*EJERCICIO 2*/

//Deserializacion:
List<Root> usuarios = await Api.GetTareasAsync();
UsuarioHelper.MostrarTareas(usuarios);

//para mostrar solo las primeras 5:
foreach (var usuario in usuarios.Take(5))
{
    Console.WriteLine($"USUARIO: {usuario.ToString()}");
    Console.WriteLine("---------------------------");
}


//Serializacion:
string jsonString = JsonSerializer.Serialize(usuarios, new JsonSerializerOptions { WriteIndented = true });
string filePath = "usuarios.json";

try
{
    await File.WriteAllTextAsync(filePath, jsonString);
    Console.WriteLine($"La lista de tareas ha sido serializada y guardada en {filePath}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocurrió un error al intentar guardar el archivo en {filePath}.");
    Console.WriteLine($"Detalles del error: {ex.Message}");
    Console.WriteLine($"Tipo de error (.Name): {ex.GetType().Name}"); 
}
