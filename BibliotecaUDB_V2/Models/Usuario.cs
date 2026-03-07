using System.Collections.Generic;

namespace BibliotecaUDB_V2.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public List<Libro> LibrosPrestados { get; set; }

        public Usuario(int id, string nombre, string correo)
        {
            Id = id;
            Nombre = nombre;
            Correo = correo;
            LibrosPrestados = new List<Libro>();
        }
    }
}