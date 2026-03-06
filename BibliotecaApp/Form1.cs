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
        Dictionary<int, Usuario> registroUsuarios = new Dictionary<int, Usuario>();
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
    }
}
