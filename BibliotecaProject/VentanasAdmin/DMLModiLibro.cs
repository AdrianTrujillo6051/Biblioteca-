using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BibliotecaProject.VentanasAdmin
{
    public partial class DMLModiLibro : Form
    {
        public DMLModiLibro()
        {
            InitializeComponent();
        }

        private void cbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            try
            {


                string consulta = string.Format("SELECT isbn, titulo, autor, editorial, fechaPubli, genero, disponibleBi, cantidadPres, idiomas, paginas FROM libros WHERE isbn = {0}; ", txtBuscarCodigo.Text);
                DataSet ds = Conexiones.ConnectDB.RealizarConexion(consulta);
                txtisb.Text = ds.Tables[0].Rows[0]["isbn"].ToString();
                txtTitulo.Text = ds.Tables[0].Rows[0]["titulo"].ToString();
                txtAutor.Text = ds.Tables[0].Rows[0]["autor"].ToString();
                txtEdi.Text = ds.Tables[0].Rows[0]["editorial"].ToString();
                datexd.Text = ds.Tables[0].Rows[0]["fechaPubli"].ToString();
                cbGenero.Text = ds.Tables[0].Rows[0]["genero"].ToString();
                cbDispoL.Text = ds.Tables[0].Rows[0]["disponibleBi"].ToString();
                txtCantida.Text = ds.Tables[0].Rows[0]["cantidadPres"].ToString();
                cbIdiomas.Text = ds.Tables[0].Rows[0]["idiomas"].ToString();
                txtPaginas.Text = ds.Tables[0].Rows[0]["paginas"].ToString();

                txtisb.Visible = true;
                txtTitulo.Visible = true;
                txtAutor.Visible = true;
                txtEdi.Visible = true;
                datexd.Visible = true;
                cbGenero.Visible = true;
                cbDispoL.Visible = true;
                txtCantida.Visible = true;
                cbIdiomas.Visible = true;
                txtPaginas.Visible = true;
                btActualizar.Visible = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la busqueda" + ex.Message);

            }
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int dispo = 1;

                if (cbDispoL.Text == "Disponible")
                {
                    dispo = 1;

                }
                else
                {
                    dispo = 0;
                }
                DateTime fechax = datexd.Value;
                string formato = "yyyy/MM/dd";
                lblFecha.Text = fechax.ToString(formato);


                string update = string.Format("UPDATE libros SET isbn ='{0}', titulo='{1}', autor='{2}', editorial='{3}', fechaPubli='{4}', genero='{5}', disponibleBi='{6}', cantidadPres='{7}', idiomas='{8}', paginas='{9}' WHERE isbn ={10};", txtisb.Text, txtTitulo.Text, txtAutor.Text, txtEdi.Text, lblFecha.Text, cbGenero.Text, dispo, txtCantida.Text, cbIdiomas.Text, txtPaginas.Text, txtBuscarCodigo.Text);

                DataSet ds = Conexiones.ConnectDB.RealizarConexion(update);


                MessageBox.Show("Se ha modificado correctamente");

                //limpiar registro 
                txtisb.Text = " ";
                txtTitulo.Text = " ";
                txtAutor.Text = " ";
                txtEdi.Text = " ";
                cbGenero.Text = " ";
                datexd.Value = DateTime.Now;
                cbDispoL.Text = " ";
                txtCantida.Text = " ";
                cbIdiomas.Text = " ";
                txtPaginas.Text = " ";
                txtBuscarCodigo.Text = " ";


                txtisb.Visible = false;
                txtTitulo.Visible = false;
                txtAutor.Visible = false;
                txtEdi.Visible = false;
                cbGenero.Visible = false;
                datexd.Visible = false;
                cbDispoL.Visible = false;
                txtCantida.Visible = false;
                cbIdiomas.Visible = false;
                txtPaginas.Visible = false;
                btActualizar.Visible = false;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificarse " + ex.Message);

            }
        }

        private void DMLModiLibro_Load(object sender, EventArgs e)
        {

        }
    }
}
