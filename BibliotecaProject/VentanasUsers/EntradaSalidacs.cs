using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaProject.VentanasUsers
{
    public partial class EntradaSalidacs : Form
    {
        public EntradaSalidacs()
        {
            InitializeComponent();

            double altura = Screen.PrimaryScreen.Bounds.Height;

            if (altura < 800) Formulario.Size = new Size(535, 391);
        }
    }
}
