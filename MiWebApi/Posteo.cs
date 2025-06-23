namespace EspacioClases
{
    public class Root
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }


        public override string ToString()
        {
            return $"USUARIO: ID #{userId} ,  ID DEL POSTEO #{id} , \n TITULO: {title} \n CONTENIDO: {body}";
        }
    }
}

