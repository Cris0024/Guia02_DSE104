namespace MVCPelicula.Models
{
    public class Película
    {
        public int ID { get; set; }
        public string Título { get; set; } 
        public DateTime FechaLanzamiento { get; set; }
        public string Genero { get; set; }
        public decimal Precio { get; set; }
        public string Director { get; set; }
        public string Sala { get; set; }
    }
}
