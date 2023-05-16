using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexiones;
using MySqlConnector; //

namespace BibliotecaProject.VentanasAdmin
{
    public partial class DMLCubi : Form
    {
        public DMLCubi()
        {
            InitializeComponent();
        }

        private void DMLCubi_Load(object sender, EventArgs e)
        {

        }

        private void btSi_Click(object sender, EventArgs e)
        {

        }


        private bool validar()
        {
            bool notEmpty = true;


            if (txtAsientos.getTextFromTXT() == string.Empty)
            {
                notEmpty = false;
                errorFormulario.SetError(txtAsientos, "No admite campos vacios");
            }
            if (txtIDCubi.getTextFromTXT() == string.Empty)
            {
                notEmpty = false;
                errorFormulario.SetError(txtIDCubi, "No admite campos vacios");
            }
            if (cbDispo.Text == string.Empty)
            {
                notEmpty = false;
                errorFormulario.SetError(cbDispo, "No admite campos vacios");
            }



            return notEmpty;
        }






        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {



                string id;
                string asientos;
                asientos = txtAsientos.getTextFromTXT();
                id = txtIDCubi.getTextFromTXT();
                int dispo = 1;

                if (cbDispo.Text == "Disponible")
                {
                    dispo = 1;

                }
                else
                {
                    dispo = 0;
                }

                try
                {
                    String guardar = "insert into cubiculos (idcubiculos,asientos, disponibilidad) values('" + id + "','" + asientos + "', '" + dispo + "')";
                    Conexiones.ConnectDB.RealizarConexion(guardar);
                    MessageBox.Show("Cubículo guardado correctamente");

                    //limpiar registro 
                    txtAsientos.setTextFromTXT(" ");
                    txtIDCubi.setTextFromTXT(" ");
                    cbDispo.Text = " ";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cubículo existente, intente de nuevo ");
                }
            }


        }

        private void cbDispo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
