using EspacioClases;

namespace EspacioHelpers
{
    public static class MiHelper
    {
        public static void MostrarPosteos(List<Root> lista)
        {
            if (lista != null)
            {
                foreach (Root elemento in lista)
                {
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine(elemento.ToString());
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