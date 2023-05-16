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
    public partial class DMLAdministrativos : Form
    {
        public DMLAdministrativos()
        {
            InitializeComponent();
        }

        private bool validadmin()
        {

            bool notEmpty = true;

            if (codigoAdminsTXT.getTextFromTXT() == string.Empty)
            {
                notEmpty = false;
                errorPAd.SetError(codigoAdminsTXT, "No admite campos vacios");
            }

            if (nombreAdminsTXT.getTextFromTXT() == string.Empty)
            {
                notEmpty = false;
                errorPAd.SetError(nombreAdminsTXT, "No admite campos vacios");
            }

            if (NSSAdminsTXT.getTextFromTXT() == string.Empty)
            {
                notEmpty = false;
                errorPAd.SetError(NSSAdminsTXT, "No admite campos vacios");
            }

            if (telefonoAdminsTXT.getTextFromTXT() == string.Empty)
            {
                notEmpty = false;
                errorPAd.SetError(telefonoAdminsTXT, "No admite campos vacios");
            }

            if (correoAdminsTXT.getTextFromTXT() == string.Empty)
            {
                notEmpty = false;
                errorPAd.SetError(correoAdminsTXT, "No admite campos vacios");
            }

            if (puestoAdminsTXT.getTextFromTXT() == string.Empty)
            {
                notEmpty = false;
                errorPAd.SetError(puestoAdminsTXT, "No admite campos vacios");
            }


            return notEmpty;
        }

        private void SaveAlBtn_Click(object sender, EventArgs e)
        {
            string comandoInsert = "Ayuda diosito";

            if (validadmin())
            {
                try
                {
                    string hora = "null";
                    if (horarioAdminsTXT.getTextFromTXT() != string.Empty) hora = horarioAdminsTXT.getTextFromTXT();

                    comandoInsert = string.Format("INSERT INTO administrativos(codigo_admin, nombre_admin, nss_admin, telefono_admin, correo_emp, puesto, horario) VALUES ({0}, '{1}', {2}, {3}, '{4}', '{5}', '{6}');", codigoAdminsTXT.getTextFromTXT(), nombreAdminsTXT.getTextFromTXT(), NSSAdminsTXT.getTextFromTXT(),
                            telefonoAdminsTXT.getTextFromTXT(), correoAdminsTXT.getTextFromTXT(), puestoAdminsTXT.getTextFromTXT(), hora);


                    Conexiones.ConnectDB.RealizarConexion(comandoInsert);
                    MessageBox.Show("Se ha insertado correctamente");

                    //limpiar registro 
                    codigoAdminsTXT.setTextFromTXT(" ");
                    nombreAdminsTXT.setTextFromTXT(" ");
                    NSSAdminsTXT.setTextFromTXT(" ");
                    telefonoAdminsTXT.setTextFromTXT(" ");
                    correoAdminsTXT.setTextFromTXT(" ");
                    horarioAdminsTXT.setTextFromTXT ("");
                    puestoAdminsTXT.setTextFromTXT("");


                }
                catch (Exception ex)
                { MessageBox.Show("Error de insercion, dato invalido o ya incertado"); }
            }
        }

        private void DMLAdministrativos_Load(object sender, EventArgs e)
        {

        }
    }
}

