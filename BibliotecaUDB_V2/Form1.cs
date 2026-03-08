using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BibliotecaUDB_V2.Models;

namespace BibliotecaUDB_V2
{
    public partial class Form1 : Form
    {
        #region ESTRUCTURAS DE DATOS EN MEMORIA

        // Diccionarios principales para el manejo de entidades (Requerimiento)
        Dictionary<int, Libro> inventarioLibros = new Dictionary<int, Libro>();
        Dictionary<int, Usuario> registroUsuarios = new Dictionary<int, Usuario>();

        // Diccionario transaccional: Key = IdLibro, Value = Entidad Prestamo
        Dictionary<int, Prestamo> registroPrestamos = new Dictionary<int, Prestamo>();

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        #region MÉTODOS DE SINCRONIZACIÓN DE UI

        /// <summary>
        /// Refresca los DataGridViews iterando sobre las colecciones en memoria.
        /// </summary>
        private void ActualizarTablas()
        {
            // Sincronizar UI de Libros
            dgvLibros.Rows.Clear();
            foreach (var l in inventarioLibros.Values)
            {
                dgvLibros.Rows.Add(l.Id, l.Titulo, l.Autor, l.Anio);
            }

            // Sincronizar UI de Usuarios
            dgvUsuarios.Rows.Clear();
            foreach (var u in registroUsuarios.Values)
            {
                dgvUsuarios.Rows.Add(u.Id, u.Nombre, u.Correo);
            }

            // Sincronizar UI de Préstamos Activos e Históricos
            dgvPrestamos.Rows.Clear();
            foreach (var p in registroPrestamos.Values)
            {
                dgvPrestamos.Rows.Add(p.IdLibro, p.IdUsuario, p.FechaSalida.ToShortDateString(), p.Estado);
            }
        }

        /// <summary>
        /// Procesa los datos de las métricas y renderiza los componentes Chart.
        /// Agrupa las entidades duplicadas lógicamente (ej. copias del mismo libro).
        /// </summary>
        private void ActualizarGraficas()
        {
            // 1. Renderizado: Demanda de Libros (Pie Chart)
            chartLibrosMasPrestados.Series.Clear();
            chartLibrosMasPrestados.Titles.Clear();
            chartLibrosMasPrestados.Titles.Add("Libros con Mayor Demanda");

            var serieLibros = chartLibrosMasPrestados.Series.Add("Préstamos");
            serieLibros.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            serieLibros.IsValueShownAsLabel = true;

            // Agrupación y normalización de títulos para evitar discrepancias por case-sensitivity
            Dictionary<string, int> conteoPorTitulo = new Dictionary<string, int>();

            foreach (var libro in inventarioLibros.Values)
            {
                if (libro.ContadorPrestamos > 0)
                {
                    string tituloClave = libro.Titulo.Trim().ToUpper();

                    if (conteoPorTitulo.ContainsKey(tituloClave))
                        conteoPorTitulo[tituloClave] += libro.ContadorPrestamos;
                    else
                        conteoPorTitulo.Add(tituloClave, libro.ContadorPrestamos);
                }
            }

            foreach (var entrada in conteoPorTitulo)
            {
                serieLibros.Points.AddXY(entrada.Key, entrada.Value);
            }

            // 2. Renderizado: Ranking de Usuarios (Column Chart)
            chartUsuariosActivos.Series.Clear();
            chartUsuariosActivos.Titles.Clear();
            chartUsuariosActivos.Titles.Add("Ranking de Usuarios Activos");

            var serieUsers = chartUsuariosActivos.Series.Add("Actividad");
            serieUsers.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            serieUsers.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;

            foreach (var user in registroUsuarios.Values)
            {
                if (user.ContadorPrestamos > 0)
                {
                    serieUsers.Points.AddXY(user.Nombre, user.ContadorPrestamos);
                }
            }
        }

        #endregion

        #region MÓDULO 1: GESTIÓN DE INVENTARIO (LIBROS)

        private void btnAnadirLibro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdLibro.Text) || string.IsNullOrWhiteSpace(txtTituloLibro.Text))
            {
                MessageBox.Show("Campos obligatorios incompletos (ID y Título).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtIdLibro.Text, out int id) || !int.TryParse(txtAnioLibro.Text, out int anio))
            {
                MessageBox.Show("Tipos de datos incorrectos en campos numéricos.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!inventarioLibros.ContainsKey(id))
            {
                Libro nuevo = new Libro(id, txtTituloLibro.Text, txtAutorLibro.Text, anio);
                inventarioLibros.Add(id, nuevo);

                ActualizarTablas();
                btnLimpiarLibro_Click(sender, e);
                MessageBox.Show("Registro insertado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Restricción de clave: El ID especificado ya existe.", "Conflicto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                    btnLimpiarLibro_Click(sender, e);
                    MessageBox.Show("Entidad actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Formato de año inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro existente para su modificación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            if (dgvLibros.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvLibros.CurrentRow.Cells[0].Value);
                DialogResult respuesta = MessageBox.Show($"¿Confirmar eliminación del registro ID: {id}?", "Confirmar operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    inventarioLibros.Remove(id);
                    // TODO: Implementar validación de eliminación en cascada o restricción si el libro está prestado actualmente.

                    ActualizarTablas();
                    btnLimpiarLibro_Click(sender, e);
                    MessageBox.Show("Registro eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Selección requerida en el control de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpiarLibro_Click(object sender, EventArgs e)
        {
            txtIdLibro.Clear();
            txtTituloLibro.Clear();
            txtAutorLibro.Clear();
            txtAnioLibro.Clear();
            txtIdLibro.ReadOnly = false;
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
                txtIdLibro.ReadOnly = true;
            }
        }

        #endregion

        #region MÓDULO 2: GESTIÓN DE USUARIOS

        private void btnAnadirUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdUsuario.Text) || string.IsNullOrWhiteSpace(txtNombreUsuario.Text))
            {
                MessageBox.Show("Campos obligatorios incompletos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtIdUsuario.Text, out int id))
            {
                MessageBox.Show("El ID de usuario debe ser numérico.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!registroUsuarios.ContainsKey(id))
            {
                Usuario nuevo = new Usuario(id, txtNombreUsuario.Text, txtCorreoUsuario.Text);
                registroUsuarios.Add(id, nuevo);

                ActualizarTablas();
                btnLimpiarUsuario_Click(sender, e);
                MessageBox.Show("Usuario registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Restricción de clave: El ID de usuario ya existe.", "Conflicto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdUsuario.Text, out int id) && registroUsuarios.ContainsKey(id))
            {
                registroUsuarios[id].Nombre = txtNombreUsuario.Text;
                registroUsuarios[id].Correo = txtCorreoUsuario.Text;

                ActualizarTablas();
                btnLimpiarUsuario_Click(sender, e);
                MessageBox.Show("Datos actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario existente para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value);
                DialogResult confirmacion = MessageBox.Show($"¿Confirmar eliminación del usuario ID: {id}?", "Confirmar operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    registroUsuarios.Remove(id);
                    ActualizarTablas();
                    btnLimpiarUsuario_Click(sender, e);
                    MessageBox.Show("Usuario eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Selección requerida en el control de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpiarUsuario_Click(object sender, EventArgs e)
        {
            txtIdUsuario.Clear();
            txtNombreUsuario.Clear();
            txtCorreoUsuario.Clear();
            txtIdUsuario.ReadOnly = false;
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
                txtIdUsuario.ReadOnly = true;
            }
        }

        #endregion

        #region MÓDULO 3: LÓGICA DE NEGOCIO (PRÉSTAMOS Y DEVOLUCIONES)

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            // Validación de parseo de IDs
            if (int.TryParse(txtIdLibroPrestamo.Text, out int idLibro) &&
                int.TryParse(txtIdUsuarioPrestamo.Text, out int idUsuario))
            {
                // Validación de integridad referencial
                if (!inventarioLibros.ContainsKey(idLibro))
                {
                    MessageBox.Show("Referencia no encontrada: ID de Libro inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!registroUsuarios.ContainsKey(idUsuario))
                {
                    MessageBox.Show("Referencia no encontrada: ID de Usuario inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validación de estado del recurso
                if (registroPrestamos.ContainsKey(idLibro) && registroPrestamos[idLibro].Estado == "Prestado")
                {
                    MessageBox.Show("Operación rechazada: El recurso se encuentra actualmente asignado.", "Conflicto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Generación de la transacción
                Prestamo nuevoPrestamo = new Prestamo(idLibro, idUsuario, DateTime.Now, "Prestado");
                registroPrestamos[idLibro] = nuevoPrestamo;

                // Actualización de métricas analíticas
                inventarioLibros[idLibro].ContadorPrestamos++;
                registroUsuarios[idUsuario].ContadorPrestamos++;

                // Sincronización de interfaz
                ActualizarTablas();
                ActualizarGraficas();

                MessageBox.Show("Transacción de préstamo procesada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Entrada inválida. Verifique los formatos de ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdLibroPrestamo.Text, out int idLibro))
            {
                // Búsqueda de transacción activa
                if (registroPrestamos.ContainsKey(idLibro) && registroPrestamos[idLibro].Estado == "Prestado")
                {
                    // Actualización de estado del recurso
                    registroPrestamos[idLibro].Estado = "Devuelto";
                    ActualizarTablas();

                    MessageBox.Show("Transacción de devolución procesada. Recurso liberado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró un préstamo activo para el identificador proporcionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Formato de ID de libro inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void btnDocumentacion_Click(object sender, EventArgs e)
        {
            try
            {
                // Nombre exacto de tu archivo PDF
                string nombreArchivo = "Manual_Usuario_Biblioteca.pdf";

                // Combinamos la ruta de ejecución con el nombre del archivo
                string rutaPdf = System.IO.Path.Combine(Application.StartupPath, nombreArchivo);

                if (System.IO.File.Exists(rutaPdf))
                {
                    // Iniciamos el proceso para abrir el PDF con el visor predeterminado del sistema
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(rutaPdf)
                    {
                        UseShellExecute = true
                    });
                }
                else
                {
                    MessageBox.Show("El manual en PDF no se encuentra en la carpeta raíz del programa.\n\n" +
                                    "Asegúrese de que el archivo 'Manual_Usuario_Biblioteca.pdf' esté junto al ejecutable.",
                                    "Documentación no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar abrir el PDF: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}