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
    public partial class DMLModiCubi : Form
    {
        public DMLModiCubi()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            try
            {


                string consulta = string.Format("SELECT idcubiculos, asientos, disponibilidad FROM cubiculos WHERE idcubiculos = {0}; ", txtBuscarCodigo.Text);
                DataSet ds = Conexiones.ConnectDB.RealizarConexion(consulta);
                txtid.Text = ds.Tables[0].Rows[0]["idcubiculos"].ToString();
                txtAsientos.Text = ds.Tables[0].Rows[0]["asientos"].ToString();
                cbDispo.Text = ds.Tables[0].Rows[0]["disponibilidad"].ToString();

                txtid.Visible = true;
                txtAsientos.Visible = true;
                cbDispo.Visible = true;
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

                if (cbDispo.Text == "Disponible")
                {
                    dispo = 1;

                }
                else
                {
                    dispo = 0;
                }

                string update = string.Format("UPDATE cubiculos SET idcubiculos ='{0}', asientos='{1}', disponibilidad='{2}' WHERE idcubiculos ={3};", txtid.Text, txtAsientos.Text, dispo,  txtBuscarCodigo.Text);

                DataSet ds = Conexiones.ConnectDB.RealizarConexion(update);


                MessageBox.Show("Se ha modificado correctamente");

                //limpiar registro 
                txtAsientos.Text = " ";
                txtid.Text = " ";
                cbDispo.Text = " ";
                txtBuscarCodigo.Text = " ";
               

                txtAsientos.Visible = false;
                txtid.Visible = false;
                cbDispo.Visible = false;
                btActualizar.Visible= false;
               



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificarse " + ex.Message);

            }
        }
    }
}
