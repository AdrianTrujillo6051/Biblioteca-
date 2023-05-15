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
    public partial class DMLModiAdmin : Form
    {
        public DMLModiAdmin()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            try
            {


                string consulta = string.Format("SELECT codigo_admin, nombre_admin, nss_admin, telefono_admin, correo_emp, puesto, horario FROM administrativos WHERE codigo_admin = {0}; ", txtBuscarCodigo.Text);
                DataSet ds = Conexiones.ConnectDB.RealizarConexion(consulta);
                txtCodigo.Text = ds.Tables[0].Rows[0]["codigo_admin"].ToString();
                txtNombre.Text = ds.Tables[0].Rows[0]["nombre_admin"].ToString();
                txtnss.Text = ds.Tables[0].Rows[0]["nss_admin"].ToString();
                txtTelefono.Text = ds.Tables[0].Rows[0]["telefono_admin"].ToString();
                txtCorreo.Text = ds.Tables[0].Rows[0]["correo_emp"].ToString();
                txtPuesto.Text = ds.Tables[0].Rows[0]["puesto"].ToString();
                horario.Text = ds.Tables[0].Rows[0]["horario"].ToString();

                txtCodigo.Visible = true;
                txtnss.Visible = true;
                txtNombre.Visible = true;
                txtTelefono.Visible = true;
                txtCorreo.Visible = true;
                txtPuesto.Visible = true;
                horario.Visible = true;
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
                DateTime fechax = horario.Value;
                string formato = "hh:mm:ss";
                lblhora.Text = fechax.ToString(formato);


                string update = string.Format("UPDATE administrativos SET codigo_admin ='{0}', nombre_admin='{1}', nss_admin='{2}', telefono_admin='{3}', correo_emp='{4}', puesto='{5}', horario='{6}' WHERE codigo_admin ={7};", txtCodigo.Text, txtNombre.Text, txtnss.Text, txtTelefono.Text, txtCorreo.Text, txtPuesto.Text, lblhora.Text, txtBuscarCodigo.Text);

                DataSet ds = Conexiones.ConnectDB.RealizarConexion(update);


                MessageBox.Show("Se ha modificado correctamente");

                //limpiar registro 
                txtCodigo.Text = " ";
                txtnss.Text = " ";
                txtNombre.Text = " ";
                txtCorreo.Text = " ";
                txtPuesto.Text = " ";
                txtTelefono.Text = " ";
                horario.Value = DateTime.Now;
                txtBuscarCodigo.Text = " ";

                txtCodigo.Visible = false;
                txtNombre.Visible = false;
                txtCorreo.Visible = false;
                txtnss.Visible = false;
                txtPuesto.Visible = false;
                txtTelefono.Visible = false;
                horario.Visible = false;
                txtBuscarCodigo.Text = " ";
                btActualizar.Visible = false;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificarse " + ex.Message);

            }
        }

        private void DMLModiAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
