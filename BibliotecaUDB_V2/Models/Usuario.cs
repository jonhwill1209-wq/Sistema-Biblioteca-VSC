using System;
using System.Collections.Generic;

namespace BibliotecaApp.Models
{
    public class Usuario
    {
        // Propiedades (Encapsulamiento)
        public int Id { get; set; }
        public string Nombre { get; set; }

        // Uso de Listas para el historial
        public List<string> LibrosPrestados { get; set; }

        // CONSTRUCTOR  (con 2 argumentos)
        public Usuario(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
            LibrosPrestados = new List<string>();
        }
    }
}