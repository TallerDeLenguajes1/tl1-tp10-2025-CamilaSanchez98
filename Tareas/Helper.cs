using EspacioClases;

namespace EspacioHelpers
{
    public static class TareaHelper
    {
        public static void MostrarTareas(List<Tarea> lista)
        {
            if (lista != null)
            {
                foreach (Tarea tarea in lista)
                {
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine($"ID Usuario: {tarea.userId}");
                    Console.WriteLine($"ID Tarea: {tarea.id}");
                    Console.WriteLine($"Título: {tarea.title}");
                    Console.WriteLine($"Completada: {tarea.completed}");
                    Console.WriteLine("----------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("La lista esta vacía.");
            }
        }
    }
}