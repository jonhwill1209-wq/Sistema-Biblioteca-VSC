using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BibliotecaUDB_V2.Models;

namespace BibliotecaUDB_V2
{
    public partial class Form1 : Form
    {
        // ================================================================
        // 1. VARIABLES GLOBALES Y DICCIONARIOS (Requerimiento UDB)
        // ================================================================
        Dictionary<int, Libro> inventarioLibros = new Dictionary<int, Libro>();
        Dictionary<int, Usuario> registroUsuarios = new Dictionary<int, Usuario>();

        // Matriz para las estadísticas (Gráficas - Pendiente de implementar)
        int[,] matrizEstadisticas = new int[2, 100];

        public Form1()
        {
            InitializeComponent();
        }

        // ================================================================
        // 2. MÉTODOS DE APOYO (Actualización visual)
        // ================================================================
        private void ActualizarTablas()
        {
            // Refrescar tabla de Libros
            dgvLibros.Rows.Clear();
            foreach (var l in inventarioLibros.Values)
            {
                dgvLibros.Rows.Add(l.Id, l.Titulo, l.Autor, l.Anio);
            }

            // Refrescar tabla de Usuarios
            dgvUsuarios.Rows.Clear();
            foreach (var u in registroUsuarios.Values)
            {
                dgvUsuarios.Rows.Add(u.Id, u.Nombre, u.Correo);
            }
        }

        private void ActualizarGraficaLibros()
        {
            chartLibrosMasPrestados.Series.Clear();
            var serie = chartLibrosMasPrestados.Series.Add("Préstamos");
            serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie; // Tipo Pastel

            foreach (var libro in inventarioLibros.Values)
            {
                serie.Points.AddXY(libro.Titulo, libro.ContadorPrestamos);
            }
        }

        // ================================================================
        // 3. PESTAÑA 1: GESTIÓN DE LIBROS (Inventario)
        // ================================================================

        private void btnAnadirLibro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdLibro.Text) || string.IsNullOrWhiteSpace(txtTituloLibro.Text))
            {
                MessageBox.Show("Por favor, completa el ID y el Título."); return;
            }
            if (!int.TryParse(txtIdLibro.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número entero."); return;
            }
            if (!int.TryParse(txtAnioLibro.Text, out int anio))
            {
                MessageBox.Show("El Año debe ser un número válido."); return;
            }

            if (!inventarioLibros.ContainsKey(id))
            {
                Libro nuevo = new Libro(id, txtTituloLibro.Text, txtAutorLibro.Text, anio);
                inventarioLibros.Add(id, nuevo);

                ActualizarTablas();
                btnLimpiarLibro_Click(sender, e); // Limpia los campos automáticamente
                MessageBox.Show("Libro registrado con éxito.");
            }
            else { MessageBox.Show("Este ID ya existe en el inventario."); }
        }

        private void btnEditarLibro_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdLibro.Text, out int id) && inventarioLibros.ContainsKey(id))
            {
                if (int.TryParse(txtAnioLibro.Text, out int nuevoAnio))
                {
                    inventarioLibros[id].Titulo = txtTituloLibro.Text;
                    inventarioLibros[id].Autor = txtAutorLibro.Text;
                    inventarioLibros[id].Anio = nuevoAnio;

                    ActualizarTablas();
                    btnLimpiarLibro_Click(sender, e); // Limpia y desbloquea el ID
                    MessageBox.Show("Cambios guardados correctamente.");
                }
                else { MessageBox.Show("El año ingresado no es válido."); }
            }
            else { MessageBox.Show("Selecciona un libro de la tabla para editar."); }
        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            if (dgvLibros.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvLibros.CurrentRow.Cells[0].Value);
                DialogResult respuesta = MessageBox.Show("¿Seguro que quieres eliminar este libro?", "Confirmar", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                    inventarioLibros.Remove(id);
                    ActualizarTablas();
                    btnLimpiarLibro_Click(sender, e); // Limpia los campos si estaban llenos
                    MessageBox.Show("Libro eliminado.");
                }
            }
            else { MessageBox.Show("Selecciona un libro en la tabla primero."); }
        }

        private void btnLimpiarLibro_Click(object sender, EventArgs e)
        {
            txtIdLibro.Clear();
            txtTituloLibro.Clear();
            txtAutorLibro.Clear();
            txtAnioLibro.Clear();
            txtIdLibro.ReadOnly = false; // Desbloquea el ID
            txtIdLibro.Focus();
        }

        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvLibros.Rows[e.RowIndex];
                txtIdLibro.Text = fila.Cells[0].Value.ToString();
                txtTituloLibro.Text = fila.Cells[1].Value.ToString();
                txtAutorLibro.Text = fila.Cells[2].Value.ToString();
                txtAnioLibro.Text = fila.Cells[3].Value.ToString();
                txtIdLibro.ReadOnly = true; // Bloquea el ID
            }
        }

        // ================================================================
        // 4. PESTAÑA 2: GESTIÓN DE USUARIOS (Alumnos)
        // ================================================================

        private void btnAnadirUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdUsuario.Text) || string.IsNullOrWhiteSpace(txtNombreUsuario.Text))
            {
                MessageBox.Show("Por favor, completa el ID y el Nombre."); return;
            }
            if (!int.TryParse(txtIdUsuario.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número entero."); return;
            }

            if (!registroUsuarios.ContainsKey(id))
            {
                Usuario nuevo = new Usuario(id, txtNombreUsuario.Text, txtCorreoUsuario.Text);
                registroUsuarios.Add(id, nuevo);

                ActualizarTablas();
                btnLimpiarUsuario_Click(sender, e); // Limpia los campos automáticamente
                MessageBox.Show("Usuario registrado con éxito.");
            }
            else { MessageBox.Show("Este ID de usuario ya existe."); }
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdUsuario.Text, out int id) && registroUsuarios.ContainsKey(id))
            {
                registroUsuarios[id].Nombre = txtNombreUsuario.Text;
                registroUsuarios[id].Correo = txtCorreoUsuario.Text;

                ActualizarTablas();
                btnLimpiarUsuario_Click(sender, e); // Limpia y desbloquea el ID
                MessageBox.Show("Datos del alumno actualizados correctamente.");
            }
            else { MessageBox.Show("Selecciona un usuario de la tabla para editar."); }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value);
                DialogResult confirmacion = MessageBox.Show("¿Eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo);

                if (confirmacion == DialogResult.Yes)
                {
                    registroUsuarios.Remove(id);
                    ActualizarTablas();
                    btnLimpiarUsuario_Click(sender, e); // Limpia los campos si estaban llenos
                    MessageBox.Show("Usuario eliminado.");
                }
            }
            else { MessageBox.Show("Selecciona un usuario en la tabla primero."); }
        }

        private void btnLimpiarUsuario_Click(object sender, EventArgs e)
        {
            txtIdUsuario.Clear();
            txtNombreUsuario.Clear();
            txtCorreoUsuario.Clear();
            txtIdUsuario.ReadOnly = false; // Desbloquea el ID
            txtIdUsuario.Focus();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];
                txtIdUsuario.Text = fila.Cells[0].Value.ToString();
                txtNombreUsuario.Text = fila.Cells[1].Value.ToString();
                txtCorreoUsuario.Text = fila.Cells[2].Value.ToString();
                txtIdUsuario.ReadOnly = true; // Bloquea el ID
            }
        }

    }
}