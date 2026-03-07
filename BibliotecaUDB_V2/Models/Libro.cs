namespace BibliotecaApp.Models
{
    public class Libro : Recurso
    {
        public string Autor { get; set; }

        public Libro(int id, string titulo, string autor) : base(id, titulo)
        {
            Autor = autor;
        }

        // Implementación del Polimorfismo
        public override string ObtenerTipo()
        {
            return "Libro Físico";
        }
    }
}