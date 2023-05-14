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
    public partial class DMLEliLibros : Form
    {
        public DMLEliLibros()
        {
            InitializeComponent();
        }

        private void Buscarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string comandoSelect = string.Format("SELECT isbn, titulo, autor, editorial FROM libros WHERE isbn = {0}; ", ISBNTXT.getTextFromTXT());
                DataSet ds = Conexiones.ConnectDB.RealizarConexion(comandoSelect);

                ISBNLTXT.Text = ds.Tables[0].Rows[0]["isbn"].ToString();
                TituloTXT.Text = ds.Tables[0].Rows[0]["titulo"].ToString();
                AutorTXT.Text = ds.Tables[0].Rows[0]["autor"].ToString();
                EditorialTXT.Text = ds.Tables[0].Rows[0]["editorial"].ToString();


            }
            catch (Exception ex) { MessageBox.Show("Error inesperado, datos invalidos o no existen");
                ISBNLTXT.Text = null;
                TituloTXT.Text = null;
                AutorTXT.Text = null;
                EditorialTXT.Text = null;
            }
        }

        private void Eliminarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string comandoDelete = string.Format("DELETE FROM libros WHERE isbn = {0};", ISBNLTXT.Text);
                Conexiones.ConnectDB.RealizarConexion(comandoDelete);

                ISBNLTXT.Text = null;
                TituloTXT.Text = null;
                AutorTXT.Text = null;
                EditorialTXT.Text = null;

                MessageBox.Show("Se ha eliminado correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado, no se puede eliminar, datos invalidos");
                ISBNLTXT.Text = null;
                TituloTXT.Text = null;
                AutorTXT.Text = null;
                EditorialTXT.Text = null;
            }
        }
    }
}
