namespace BibliotecaApp.Models
{
    public abstract class Recurso
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public bool EstaDisponible { get; set; }

        public Recurso(int id, string titulo)
        {
            Id = id;
            Titulo = titulo;
            EstaDisponible = true;
        }

        // Método abstracto para Polimorfismo
        public abstract string ObtenerTipo();
    }
}