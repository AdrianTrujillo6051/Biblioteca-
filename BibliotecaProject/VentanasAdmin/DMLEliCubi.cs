using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaProject.VentanasAdmin
{
    public partial class DMLEliCubi : Form
    {
        public DMLEliCubi()
        {
            InitializeComponent();
        }

        private void Buscarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string comandoSelect = string.Format("SELECT idcubiculos, asientos FROM cubiculos WHERE idcubiculos = {0}; ", IDCTXT.getTextFromTXT());
                DataSet ds = Conexiones.ConnectDB.RealizarConexion(comandoSelect);

                IDCubiTXT.Text = ds.Tables[0].Rows[0]["idcubiculos"].ToString();
                AsientosTXT.Text = ds.Tables[0].Rows[0]["asientos"].ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado, datos invalidos o no existen");
                IDCubiTXT.Text = null;
                AsientosTXT.Text = null;
                
            }
        }

        private void Eliminarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string comandoDelete = string.Format("DELETE FROM cubiculos WHERE idcubiculos = {0};", IDCubiTXT.Text);
                Conexiones.ConnectDB.RealizarConexion(comandoDelete);

                IDCubiTXT.Text = null;
                AsientosTXT.Text = null;


                MessageBox.Show("Se ha eliminado correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado, no se puede eliminar, datos invalidos");
                IDCubiTXT.Text = null;
                AsientosTXT.Text = null;

            }
        }
    }
}
