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
using static System.Net.Mime.MediaTypeNames;

namespace BibliotecaProject.VentanasAdmin
{
    public partial class DMLModiAlum : Form
    {
        public DMLModiAlum()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            try
            {


                string consulta = string.Format("SELECT codigo, nombre, fechaN, nss, numeroT, correoIns FROM alumnos WHERE codigo = {0}; ", txtBuscarCodigo.Text);
                DataSet ds = Conexiones.ConnectDB.RealizarConexion(consulta);
                txtCodigooo.Text = ds.Tables[0].Rows[0]["codigo"].ToString();
                txtName.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                //txtB.Text = ds.Tables[0].Rows[0]["fechaN"].ToString();
                datexd.Text = ds.Tables[0].Rows[0]["fechaN"].ToString();
                txtnsss.Text = ds.Tables[0].Rows[0]["nss"].ToString();
                txtTelefono.Text = ds.Tables[0].Rows[0]["numeroT"].ToString();
                txtcorreoo.Text = ds.Tables[0].Rows[0]["correoIns"].ToString();

                txtCodigooo.Visible = true;
                txtName.Visible = true;
                datexd.Visible = true;
                txtnsss.Visible = true;
                txtTelefono.Visible = true;
                txtcorreoo.Visible = true;
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
                DateTime fechax = datexd.Value;
                string formato = "yyyy/MM/dd";
                lblFecha.Text = fechax.ToString(formato);


                string update = string.Format("UPDATE alumnos SET nombre ='{0}', numeroT='{1}', nss='{2}', correoIns='{3}', fechaN='{4}', codigo='{5}' WHERE codigo ={6};", txtName.Text, txtTelefono.Text, txtnsss.Text, txtcorreoo.Text, lblFecha.Text, txtCodigooo.Text, txtBuscarCodigo.Text);

                DataSet ds = Conexiones.ConnectDB.RealizarConexion(update);


                MessageBox.Show("Se ha modificado correctamente");

                //limpiar registro 
                txtCodigooo.Text = " ";
                txtName.Text = " ";
                txtcorreoo.Text = " ";
                txtnsss.Text = " ";
                txtTelefono.Text = " ";
                datexd.Value = DateTime.Now;
                txtBuscarCodigo.Text = " ";

                txtCodigooo.Visible = false;
                txtName.Visible = false;
                datexd.Visible = false;
                txtnsss.Visible = false;
                txtTelefono.Visible = false;
                txtcorreoo.Visible = false;
                btActualizar.Visible = false;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificarse " + ex.Message);

            }

        }

        private void ya_Click(object sender, EventArgs e)
        {


        }

        private void txtBuscarCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void datexd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DMLModiAlum_Load(object sender, EventArgs e)
        {

        }
    }

}
