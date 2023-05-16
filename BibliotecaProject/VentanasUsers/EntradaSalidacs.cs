using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaProject.VentanasUsers
{
    public partial class EntradaSalidacs : Form
    {
        public EntradaSalidacs()
        {
            InitializeComponent();

            double altura = Screen.PrimaryScreen.Bounds.Height;

            if (altura < 800) Formulario.Size = new Size(535, 391);
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNEntrada_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtenemos el usuario en base a su codigo OJO: solo funciona con estudiantes ;)
                string comando = string.Format("SELECT id FROM usuarios WHERE codigo_alumno = {0};", TXTCodEntrada.getTextFromTXT());
                DataSet ds = Conexiones.ConnectDB.RealizarConexion(comando);
                string vari = ds.Tables[0].Rows[0]["id"].ToString();

                comando = string.Format("SELECT usuario_id FROM historial_gente_biblioteca WHERE usuario_id = {0};", vari);
                ds = Conexiones.ConnectDB.RealizarConexion(comando);

                //Esto nos sirve como un IF else, si se encuentra un index en la primera casilla significa que existe algo, si no, falla y significa que no hay datos :)
                try
                {
                    //Esto nos serviria como nuestra condicional JAJAJAJAJAJA
                    string existe = ds.Tables[0].Rows[0]["usuario_id"].ToString();

                    //Actualizamos el resgistro si existe ya el usuario xd
                    comando = string.Format("UPDATE historial_gente_biblioteca SET hora_ingreso = '09:09:09', hora_salida = null WHERE usuario_id = {0};", vari);
                    Conexiones.ConnectDB.RealizarConexion(comando);
                    MessageBox.Show("Registro exitoso :)...");
                }
                catch
                {
                    //Los insertamos en historial de gente en biblioteca
                    comando = string.Format("INSERT INTO historial_gente_biblioteca (usuario_id, hora_ingreso) VALUES({0}, '10:10:10');", vari);
                    Conexiones.ConnectDB.RealizarConexion(comando);
                    MessageBox.Show("Registro exitoso :)...");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ups..." + ex);
            }
        }

        private void BTNSalida_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtenemos el usuario en base a su codigo OJO: solo funciona con estudiantes ;)
                string comando = string.Format("SELECT id FROM usuarios WHERE codigo_alumno = {0};", TXTCodSali.getTextFromTXT());
                DataSet ds = Conexiones.ConnectDB.RealizarConexion(comando);
                string vari = ds.Tables[0].Rows[0]["id"].ToString();

                //Cambiamos su resgistro de hora :)
                comando = string.Format("UPDATE historial_gente_biblioteca SET hora_salida = '12:12:12' WHERE usuario_id = {0};", vari);
                Conexiones.ConnectDB.RealizarConexion(comando);
                MessageBox.Show("Salida exitosa :)...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upss...");
            }

        }
    }
}
