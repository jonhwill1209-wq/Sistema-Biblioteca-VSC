using BibliotecaApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaApp
{
    public partial class Form1 : Form
    {
        // El Diccionario para búsquedas rápidas por ID
        Dictionary<int, Usuario> registroUsuarios = new Dictionary<int, Usuario>();

        int[,] contadorRegistros = new int[1, 1];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Capturar los datos de los TextBox
                int id = int.Parse(txtId.Text); // Convertimos el texto a número
                string nombre = txtNombre.Text;

                // 2. Validar si el ID ya existe en el Diccionario 
                if (registroUsuarios.ContainsKey(id))
                {
                    MessageBox.Show("Este ID ya está registrado.");
                    return;
                }

                // 3. Crear el objeto Usuario (Usando la clase de tu carpeta Models)
                Usuario nuevoUsuario = new Usuario(id, nombre);

                // 4. Guardar en el Diccionario
                registroUsuarios.Add(id, nuevoUsuario);

                // 5. Mostrar en la Tabla (DataGridView)
                dgvUsuarios.Rows.Add(id, nombre);

                // 6. Limpiar los campos para el siguiente registro
                txtId.Clear();
                txtNombre.Clear();
                txtId.Focus();

                MessageBox.Show("Estudiante registrado con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Asegúrate de ingresar un ID numérico válido.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Obtener el ID que el usuario escribió para buscar
                int idABuscar = int.Parse(txtId.Text);

                // 2. Verificar si el ID existe en el Diccionario
                if (registroUsuarios.ContainsKey(idABuscar))
                {
                    // 3. Extraer el objeto Usuario del Diccionario usando su llave
                    Usuario usuarioEncontrado = registroUsuarios[idABuscar];

                    // 4. Mostrar el resultado en el cuadro de Nombre
                    txtNombre.Text = usuarioEncontrado.Nombre;

                    MessageBox.Show("¡Usuario encontrado!");
                }
                else
                {
                    MessageBox.Show("El ID " + idABuscar + " no existe en el registro.");
                    txtNombre.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingresa un ID numérico para buscar: " + ex.Message);
            }
        }
    }
}
