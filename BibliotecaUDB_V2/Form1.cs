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


            private void ActualizarGraficaLibros()
        {
            chartLibrosMasPrestados.Series.Clear();
            var serie = chartLibrosMasPrestados.Series.Add("Préstamos");
            serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie; // Tipo Pastel

            foreach (var libro in inventarioLibros.Values)
            {
                // Añadimos el título del libro y cuántas veces se ha prestado
                // (Para esto usaremos el contador que mencionamos ayer)
                serie.Points.AddXY(libro.Titulo, libro.ContadorPrestamos);
            }
        
        }

        // --- EVENTOS ---
        private void btnAnadirLibro_Click(object sender, EventArgs e)
        {
            // 1. Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtIdLibro.Text) || string.IsNullOrWhiteSpace(txtTituloLibro.Text))
            {
                MessageBox.Show("Por favor, completa el ID y el Título.");
                return;
            }

            // 2. Validar que el ID sea un número
            if (!int.TryParse(txtIdLibro.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número entero.");
                return;
            }

            // 3. Validar que el Año sea un número
            if (!int.TryParse(txtAnioLibro.Text, out int anio))
            {
                MessageBox.Show("El Año debe ser un número válido.");
                return;
            }

            // 4. Si todo está bien, procedemos a guardar
            if (!inventarioLibros.ContainsKey(id))
            {
                Libro nuevo = new Libro(id, txtTituloLibro.Text, txtAutorLibro.Text, anio);
                inventarioLibros.Add(id, nuevo);
                ActualizarTablas();

                // Opcional: Limpiar campos después de añadir
                txtIdLibro.Clear();
                txtTituloLibro.Clear();
                txtAutorLibro.Clear();
                txtAnioLibro.Clear();
            }
            else
            {
                MessageBox.Show("Este ID ya existe en el inventario.");
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

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            if (dgvLibros.CurrentRow != null)
            {
                // Obtenemos el ID de la primera columna de la fila seleccionada
                int id = Convert.ToInt32(dgvLibros.CurrentRow.Cells[0].Value);

                DialogResult respuesta = MessageBox.Show("¿Seguro que quieres eliminar este libro?", "Confirmar", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                    inventarioLibros.Remove(id);
                    ActualizarTablas();
                    MessageBox.Show("Libro eliminado.");
                }
            }
            else { MessageBox.Show("Selecciona un libro en la tabla primero."); }
        }

        private void btnEditarLibro_Click(object sender, EventArgs e)
        {
            // Validamos que el ID sea numérico para buscarlo en el diccionario
            if (int.TryParse(txtIdLibro.Text, out int id))
            {
                if (inventarioLibros.ContainsKey(id))
                {
                    // Validamos que el nuevo año ingresado sea un número
                    if (int.TryParse(txtAnioLibro.Text, out int nuevoAnio))
                    {
                        inventarioLibros[id].Titulo = txtTituloLibro.Text;
                        inventarioLibros[id].Autor = txtAutorLibro.Text;
                        inventarioLibros[id].Anio = nuevoAnio;

                        ActualizarTablas();
                        MessageBox.Show("Cambios guardados correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("El año ingresado no es válido.");
                    }
                }
            }
        }

        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Evita error si hace clic en el encabezado
            {
                DataGridViewRow fila = dgvLibros.Rows[e.RowIndex];
                txtIdLibro.Text = fila.Cells[0].Value.ToString();
                txtTituloLibro.Text = fila.Cells[1].Value.ToString();
                txtAutorLibro.Text = fila.Cells[2].Value.ToString();
                txtAnioLibro.Text = fila.Cells[3].Value.ToString();

                // Bloqueamos el ID porque es la llave, no se debe cambiar al editar
                txtIdLibro.ReadOnly = true;
            }
        }

        private void btnLimpiarLibro_Click(object sender, EventArgs e)
        {
            txtIdLibro.Clear();
            txtTituloLibro.Clear();
            txtAutorLibro.Clear();
            txtAnioLibro.Clear();

            // IMPORTANTE: Desbloqueamos el ID por si estaba en modo edición
            txtIdLibro.ReadOnly = false;
            txtIdLibro.Focus(); // Pone el cursor listo para escribir
        }

        private void txtIdLibro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnioLibro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}