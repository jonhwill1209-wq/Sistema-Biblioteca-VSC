using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BibliotecaUDB_V2.Models;

namespace BibliotecaUDB_V2
{
    public partial class Form1 : Form
    {
        // Diccionarios para cumplir con la UDB
        Dictionary<int, Libro> inventarioLibros = new Dictionary<int, Libro>();
        Dictionary<int, Usuario> registroUsuarios = new Dictionary<int, Usuario>();

        // Matriz para las estadísticas (Gráficas)
        int[,] matrizEstadisticas = new int[2, 100];

        public Form1()
        {
            InitializeComponent();
        }

        // --- MÉTODOS DE APOYO ---
        private void ActualizarTablas()
        {
            dgvLibros.Rows.Clear();
            foreach (var l in inventarioLibros.Values)
                dgvLibros.Rows.Add(l.Id, l.Titulo, l.Autor, l.Anio);

            dgvUsuarios.Rows.Clear();
            foreach (var u in registroUsuarios.Values)
                dgvUsuarios.Rows.Add(u.Id, u.Nombre, u.Correo);
        }

        // --- EVENTOS ---
        private void btnAnadirLibro_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdLibro.Text, out int id))
            {
                if (!inventarioLibros.ContainsKey(id))
                {
                    Libro nuevo = new Libro(id, txtTituloLibro.Text, txtAutorLibro.Text, int.Parse(txtAnioLibro.Text));
                    inventarioLibros.Add(id, nuevo);
                    ActualizarTablas();
                }
                else { MessageBox.Show("ID duplicado"); }
            }
        }

        private void btnAnadirUsuario_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdUsuario.Text, out int id))
            {
                if (!registroUsuarios.ContainsKey(id))
                {
                    Usuario nuevo = new Usuario(id, txtNombreUsuario.Text, txtCorreoUsuario.Text);
                    registroUsuarios.Add(id, nuevo);
                    ActualizarTablas();
                }
                else { MessageBox.Show("ID duplicado"); }
            }
        }
    }
}