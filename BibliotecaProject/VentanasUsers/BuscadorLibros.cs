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
    public partial class BuscadorLibros : Form
    {
        public BuscadorLibros()
        {
            InitializeComponent();
        }

        private void Buscando(object sender, EventArgs e)
        {
            try
            {
                string buscar = string.Format("SELECT isbn as 'ISBN', titulo as 'Título', autor as 'Autor' FROM libros WHERE titulo LIKE '%{0}%';", bookTXT.Text.Trim());
                DataSet ds = Conexiones.ConnectDB.RealizarConexion(buscar);
                busquedaRETURN.DataSource = ds.Tables[0];
            }
            catch { MessageBox.Show("Error inesperado..."); }

        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
