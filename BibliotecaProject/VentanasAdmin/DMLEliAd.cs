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
    public partial class DMLEliAd : Form
    {
        public DMLEliAd()
        {
            InitializeComponent();
        }

        private void Buscarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string comandoSelect = string.Format("SELECT codigo_admin, nombre_admin, correo_emp FROM administrativos WHERE codigo_admin = {0}; ", CodigoAdmiTXT.getTextFromTXT());
                DataSet ds = Conexiones.ConnectDB.RealizarConexion(comandoSelect);



                CodigAdmTXT.Text = ds.Tables[0].Rows[0]["codigo_admin"].ToString();
                NameAdmTXT.Text = ds.Tables[0].Rows[0]["nombre_admin"].ToString();
                EmailAdmTXT.Text = ds.Tables[0].Rows[0]["correo_emp"].ToString();


            }
            catch (Exception ex) { MessageBox.Show("Error inesperado, datos invalidos o no existen"); }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string comandoDelete = string.Format("DELETE FROM administrativos WHERE codigo_admin = {0};", CodigAdmTXT.Text);
                Conexiones.ConnectDB.RealizarConexion(comandoDelete);

                CodigoAdmiTXT.Text = null;
                CodigAdmTXT.Text = null;
                NameAdmTXT.Text = null;
                EmailAdmTXT.Text = null;

                MessageBox.Show("Se ha eliminado correctamente");
            }
            catch (Exception ex) { MessageBox.Show("Error inesperado, no se puede eliminar, datos invalidos");
                CodigoAdmiTXT.Text = null;
                CodigAdmTXT.Text = null;
                NameAdmTXT.Text = null;
                EmailAdmTXT.Text = null;
            }

        }
    }
}
