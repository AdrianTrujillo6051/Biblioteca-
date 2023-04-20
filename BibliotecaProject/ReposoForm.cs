using Conexiones;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaProject
{
    public partial class ReposoForm : Form
    {
        public ReposoForm()
        {
            InitializeComponent();
        }

        private void buttondml1_Click(object sender, EventArgs e)
        {
            DataSet ds = Conexiones.ConnectDB.RealizarConexion("SELECT * FROM cubiculos");
        }
    }
}
