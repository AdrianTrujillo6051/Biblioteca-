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
    public partial class DMLAlumn : Form
    {
        public DMLAlumn()
        {
            InitializeComponent();
        }

        private bool Validalum()
        {
            bool notEmpty = true;

            if (codigoAlumnoTXT.getTextFromTXT() == string.Empty)
            {
                notEmpty = false;
                errorPA.SetError(codigoAlumnoTXT, "No admite campos vacios");
            }

            if (nombreAlumnoTXT.getTextFromTXT() == string.Empty)
            {
                notEmpty = false;
                errorPA.SetError(nombreAlumnoTXT, "No admite campos vacios");
            }

            /*if (cumAlumnoTXT.getTextFromTXT() == string.Empty)
            {
                notEmpty = false;
                errorPA.SetError(cumAlumnoTXT, "No admite campos vacios");
            }*/

            if (NSSAlumnoTXT.getTextFromTXT() == string.Empty)
            {
                notEmpty = false;
                errorPA.SetError(NSSAlumnoTXT, "No admite campos vacios");
            }

            if (telefonoAlumnoTXT.getTextFromTXT() == string.Empty)
            {
                notEmpty = false;
                errorPA.SetError(telefonoAlumnoTXT, "No admite campos vacios");
            }

            if (correoAlumnoTXT.getTextFromTXT() == string.Empty)
            {
                notEmpty = false;
                errorPA.SetError(correoAlumnoTXT, "No admite campos vacios");
            }


            return notEmpty;
        }


        private void SaveAlBtn_Click(object sender, EventArgs e)
        {
            string comandoInsert = "popo";

            if (Validalum())
            {
                try
                {
                    DateTime fechax = datexd.Value;
                    string formato = "yyyy/MM/dd";
                    lblFecha.Text = fechax.ToString(formato);

                    comandoInsert = string.Format("INSERT INTO alumnos(codigo, nombre, fechaN, nss, numeroT, correoIns) VALUES ({0}, '{1}', '{2}', {3}, {4}, '{5}');", codigoAlumnoTXT.getTextFromTXT(), nombreAlumnoTXT.getTextFromTXT(), lblFecha.Text, NSSAlumnoTXT.getTextFromTXT(), telefonoAlumnoTXT.getTextFromTXT(), correoAlumnoTXT.getTextFromTXT());
                    //string comandoInsert = string.Format("INSERT INTO alumnos(codigo, nombre, fechaN, nss, numeroT, correoIns) VALUES ({0}, {1}, {2}, {3}, {4}, {5});");

                    Conexiones.ConnectDB.RealizarConexion(comandoInsert);
                    MessageBox.Show("Se insertaron los datos correctamente");
                    datexd.Value = DateTime.Now;


                    //limpiar registro 
                    codigoAlumnoTXT.setTextFromTXT(" ");
                    nombreAlumnoTXT.setTextFromTXT(" ");
                    NSSAlumnoTXT.setTextFromTXT(" ");
                    telefonoAlumnoTXT.setTextFromTXT(" ");
                    correoAlumnoTXT.setTextFromTXT(" ");
                    datexd.Value = DateTime.Now;
                }
                catch (Exception ex) { MessageBox.Show("Error innesperado, datos ya existentes o invalidos"); }
            }
        }

        private void codigoAlumnoTXT_Load(object sender, EventArgs e)
        {

        }

        private void DMLAlumn_Load(object sender, EventArgs e)
        {

        }
    }
}
