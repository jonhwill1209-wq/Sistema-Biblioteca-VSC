namespace BibliotecaUDB_V2.Models
{
    public class Libro
    {
        public int Id { get; set; } // Asegúrate que sea Id, no ISBN
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Anio { get; set; }
        public bool EstaPrestado { get; set; } // Agregamos esto para el control de disponibilidad

        public int ContadorPrestamos { get; set; } = 0;

        public Libro(int id, string titulo, string autor, int anio)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            Anio = anio;
            EstaPrestado = false; // Por defecto inicia disponible
        }
    }
}