using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexiones;
using MySqlConnector;





namespace BibliotecaProject.VentanasAdmin
{
    public partial class DMLLibros : Form
    {

        public DMLLibros()
        {
            InitializeComponent();
        }

        private void txtEditorial_Load(object sender, EventArgs e)
        {


        }


        private bool validar()
        {
            bool notEmpty = true;

            if (txtISBN.getTextFromTXT() == string.Empty)
            {
                notEmpty = false;
                errorFormulario.SetError(txtISBN, "No admite campos vacios");
            }
            if (txtTitulo.getTextFromTXT() == string.Empty)
            {
                notEmpty = false;
                errorFormulario.SetError(txtTitulo, "No admite campos vacios");
            }
            if (txtAutor.getTextFromTXT() == string.Empty)
            {
                notEmpty = false;
                errorFormulario.SetError(txtAutor, "No admite campos vacios");
            }
            if (txtEditorial.getTextFromTXT() == string.Empty)
            {
                notEmpty = false;
                errorFormulario.SetError(txtEditorial, "No admite campos vacios");
            }
            /*if (txtFechaPubli.getTextFromTXT() == string.Empty)
            {
                notEmpty = false;
                errorFormulario.SetError(txtFechaPubli, "No admite campos vacios");
            }*/
            if (txtCanPres.getTextFromTXT() == string.Empty)
            {
                notEmpty = false;
                errorFormulario.SetError(txtCanPres, "No admite campos vacios");
            }
            if (txtPaginas.getTextFromTXT() == string.Empty)
            {
                notEmpty = false;
                errorFormulario.SetError(txtPaginas, "No admite campos vacios");
            }
            if (cbGenero.Text == string.Empty)
            {
                notEmpty = false;
                errorFormulario.SetError(cbGenero, "No admite campos vacios");
            }
            if (cbDispoL.Text == string.Empty)
            {
                notEmpty = false;
                errorFormulario.SetError(cbDispoL, "No admite campos vacios");
            }
            if (cbIdiomas.Text == string.Empty)
            {
                notEmpty = false;
                errorFormulario.SetError(cbIdiomas, "No admite campos vacios");
            }


            return notEmpty;
        }

        private void btGuardarLibro_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                DateTime fechax = datexd.Value;
                string formato = "yyyy/MM/dd";
                lblFecha.Text = fechax.ToString(formato);

                string isbn; string fecha;
                string titulo; string genero;
                string autor; string disponibilidad;
                string editorial; string cantidad;
                string idiomas; string paginas;

                isbn = txtISBN.getTextFromTXT();
                titulo = txtTitulo.getTextFromTXT();
                autor = txtAutor.getTextFromTXT();
                editorial = txtEditorial.getTextFromTXT();
                idiomas = cbIdiomas.Text;
                //fecha = txtFechaPubli.getTextFromTXT();
                genero = cbGenero.Text;
                disponibilidad = cbDispoL.Text;
                cantidad = txtCanPres.getTextFromTXT();
                paginas = txtPaginas.getTextFromTXT();


                int dispo = 1;

                if (cbDispoL.Text == "Disponible")
                {
                    dispo = 1;

                }
                else
                {
                    dispo = 0;
                }

                try
                {
                    String guardarL = "insert into libros  (isbn ,titulo, autor, editorial, fechaPubli, genero, disponibleBi, cantidadPres, idiomas, paginas) values('" + isbn + "','" + titulo + "', '" + autor + "', '" + editorial + "','" + lblFecha.Text + "', '" + genero + "', '" + dispo + "', '" + cantidad + "','" + idiomas + "', '" + paginas + "')";
                    Conexiones.ConnectDB.RealizarConexion(guardarL);
                    MessageBox.Show("Registro guardado correctamente");

                    //limpiar registro 
                    txtISBN.setTextFromTXT(" ");
                    txtTitulo.setTextFromTXT(" ");
                    txtAutor.setTextFromTXT(" ");
                    txtEditorial.setTextFromTXT(" ");
                    //txtFechaPubli.setTextFromTXT(" ");
                    txtCanPres.setTextFromTXT(" ");
                    txtPaginas.setTextFromTXT(" ");
                    cbDispoL.Text = " ";
                    cbGenero.Text = " ";
                    cbIdiomas.Text = " ";
                    datexd.Value = DateTime.Now;


                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex);
                }
            }

        }

        private void btYes_Click(object sender, EventArgs e)
        {

        }

        private void DMLLibros_Load(object sender, EventArgs e)
        {

        }

        private void txtISBN_Load(object sender, EventArgs e)
        {

        }
    }
}
