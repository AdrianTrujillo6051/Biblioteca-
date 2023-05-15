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
    public partial class DMLEliAlum : Form
    {
        public DMLEliAlum()
        {
            InitializeComponent();
        }

        private void Buscarbtn_Click(object sender, EventArgs e)
        {


            try
            {
                string comandoSelect = string.Format("SELECT codigo, nombre, correoIns FROM alumnos WHERE codigo = {0}; ", CodigoAlumTXT.getTextFromTXT());
                DataSet ds = Conexiones.ConnectDB.RealizarConexion(comandoSelect);



                CodigAlumTXT.Text = ds.Tables[0].Rows[0]["codigo"].ToString();
                NameAlumTXT.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                EmailAlumTXT.Text = ds.Tables[0].Rows[0]["correoIns"].ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado, datos invalidos o no existen");
                CodigoAlumTXT.Text = null;
                CodigoAlumTXT.Text = null;
                NameAlumTXT.Text = null;
                EmailAlumTXT.Text = null;
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {

            try
            {
                string comandoDelete = string.Format("DELETE FROM alumnos WHERE codigo = {0};", CodigAlumTXT.Text);
                Conexiones.ConnectDB.RealizarConexion(comandoDelete);

                CodigoAlumTXT.Text = null;
                CodigAlumTXT.Text = null;
                NameAlumTXT.Text = null;
                EmailAlumTXT.Text = null;

                MessageBox.Show("Se ha eliminado correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado, no se puede eliminar, datos invalidos");
                CodigoAlumTXT.Text = null;
                CodigoAlumTXT.Text = null;
                NameAlumTXT.Text = null;
                EmailAlumTXT.Text = null;
            }

        }

        private void CodigoAlumTXT_Load(object sender, EventArgs e)
        {

        }
    }
}
