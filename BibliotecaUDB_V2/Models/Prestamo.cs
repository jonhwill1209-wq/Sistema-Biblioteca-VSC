using System;

namespace BibliotecaUDB_V2.Models
{
    public class Prestamo
    {
        public int IdLibro { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaSalida { get; set; }
        public string Estado { get; set; } // "Prestado" o "Devuelto"

        public Prestamo(int idLibro, int idUsuario, DateTime fechaSalida, string estado)
        {
            IdLibro = idLibro;
            IdUsuario = idUsuario;
            FechaSalida = fechaSalida;
            Estado = estado;
        }
    }
}