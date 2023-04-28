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
    public partial class Prestamos : Form
    {
        public Prestamos()
        {
            InitializeComponent();

            DataSet ds = Conexiones.ConnectDB.RealizarConexion("SELECT * FROM prestamolibros");
            PrestamosInfo.DataSource = ds.Tables[0];

        }

        private void BuscarBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string comando = string.Format("SELECT * FROM prestamolibros WHERE codigo = {0};", TXTCod.getTextFromTXT());
                DataSet ds = Conexiones.ConnectDB.RealizarConexion(comando);
                PrestamosInfo.DataSource = ds.Tables[0];
            }
            catch { MessageBox.Show("Error inesperado..."); }

        }
    }
}
