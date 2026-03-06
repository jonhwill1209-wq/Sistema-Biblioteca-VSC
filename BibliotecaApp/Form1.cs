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
    }
}
