using Conexiones;
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
using ObjPersonalizados;

namespace BibliotecaProject.VentanasUsers
{
    public partial class Cubiculos : Form
    {

        private int contador = 1;
        public Cubiculos()
        {
            InitializeComponent();


            //Ocultamos nuestro DGV pa que no se vea feo alv :)
            CubiculosInfoDGV.Visible = false;
            panelManipulacion.Visible = false;

            //Cargamos los cubiculos 
            reloadCubiculos();

        }

        private void DesplegarBTN_Click(object sender, EventArgs e)
        {
            //Para abrir o cerrar el panel lateral
            if (panelManipulacion.Visible)
            {
                panelManipulacion.Visible = false;
                DesplegarBTN.Text = ">";
            }
            else if (panelManipulacion.Visible == false)
            {
                panelManipulacion.Visible = true;
                DesplegarBTN.Text = "<";
            }
        }


        //Evento generico para nuestros botones cubiculos
        private void evento(object sender, EventArgs e)
        {
            //Obtenemos datos basicos del boton
            Button botonCubi = sender as Button;
            int filaInfo = Convert.ToInt16(botonCubi.Text) - 1;
            int dispo = Convert.ToInt16(CubiculosInfoDGV.Rows[filaInfo].Cells[2].Value);
            String estadoCub, pedirOdevolver;


            //Seteamos los datos para imprimir el mensaje de informacion
            if (dispo == 1) estadoCub = "Disponible";
            else estadoCub = "No disponible";

            if (dispo == 1) pedirOdevolver = "\n¿Quiere pedir el cubiculo?";
            else pedirOdevolver = "\n¿Quiere devolver el cubiculo?";

            string mensaje = string.Format("\nIDCubiculo: " + CubiculosInfoDGV.Rows[filaInfo].Cells[0].Value.ToString() + "\nAsientos: " + CubiculosInfoDGV.Rows[filaInfo].Cells[1].Value.ToString() + "\nDisponibilidad: " + estadoCub + pedirOdevolver);
            if (MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                //Si el usuario quiere devolver o pedir el cubiculo lo mandamos a su respectivo textbox
                panelManipulacion.Visible = true;

                if (dispo == 1)
                {
                    TXTCodCubPres.setTextFromTXT(CubiculosInfoDGV.Rows[filaInfo].Cells[0].Value.ToString());
                    TXTCodCubPres.Focus();
                    TXTCodCubDev.setTextFromTXT("");
                }
                else
                {
                    TXTCodCubDev.setTextFromTXT(CubiculosInfoDGV.Rows[filaInfo].Cells[0].Value.ToString());
                    TXTCodCubDev.Focus();
                    TXTCodCubPres.setTextFromTXT("");
                }
            }
        }

        private void reloadCubiculos()
        {
            //Vaciamos estas madres para no tener problemas :)
            CubiculosInfoDGV.DataSource = null;
            panelCubiculos.Controls.Clear();

            //Obtenemos todos los cubiculos guardados en la BD y los cargamos a una DataGriedView para facilitar el trabajo :)
            try
            {
                DataSet ds = Conexiones.ConnectDB.RealizarConexion("SELECT * FROM cubiculos");
                CubiculosInfoDGV.DataSource = ds.Tables[0];

                //Le restamos dos, esto tomando en cuenta que añade una al final y que debemos empezar por cero
                int columnas = CubiculosInfoDGV.Rows.Count - 2;

                //En este caso el iterador "i" nos permite poner siempre un numero de cubiculo seguido, independientemente de su ID,  
                //y nos permitira controlar esto mediante posiciones de la data  DGView


                //Hacemos un for normal para evitar problemas 
                for (int i = 0; i <= columnas; i++)
                {

                    CubiculosButton boton = new CubiculosButton();
                    boton.Text = Convert.ToString(i + 1);
                    boton.Click += evento;

                    int ocupado = Convert.ToInt16(CubiculosInfoDGV.Rows[i].Cells[2].Value);
                    if (ocupado != 1)
                    {
                        boton.BackColor = Color.Red;
                    }
                    panelCubiculos.Controls.Add(boton);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Inesperado :(");
            }
        }


        //-------------------PRESTAR Y DEVOLVER BOTONES ----------------------------------------------------------------------------------------------------------------------------------
        private void PedirBTN_Click(object sender, EventArgs e)
        {
            //Validamos si tenemos los campos necesarios para hacer la incersion
            if (validar())
            {
                try
                {
                    //Como estos son opcionales los seteamos en null para no tener problemas al momento de hacer la incersion, pero si si tienen datos los seteamos a esos datos :)
                    string fecha = "null", hora = "null";
                    if (TXTFecha.getTextFromTXT() != string.Empty) fecha = TXTFecha.getTextFromTXT();
                    if (TXTHora.getTextFromTXT() != string.Empty) hora = TXTHora.getTextFromTXT();


                    //Creamos nuestros comandos SQL, uno para insertar en la tabla relacional y otro para hacer un update del cubiculos :)
                    string comandoInsert = string.Format("INSERT INTO cubiculos_usados_por_alumnos(idcubiculosu, codigoes, prestamo_habilitado, fecha_prestamo, hora_prestamo) " +
                    "VALUES ({0}, {1}, {2}, {3}, {4});", TXTCodCubPres.getTextFromTXT(), TXTCodigoAlum.getTextFromTXT(), 1, fecha, hora);
                    string comandoUpdate = string.Format("UPDATE cubiculos SET disponibilidad = 0 WHERE idcubiculos = {0};", TXTCodCubPres.getTextFromTXT());


                    //Hacemos las incersiones y actualizamos los botones de los cubiculos :)
                    Conexiones.ConnectDB.RealizarConexion(comandoInsert);
                    Conexiones.ConnectDB.RealizarConexion(comandoUpdate);
                    reloadCubiculos();
                    MessageBox.Show("Prestamo correctamente realizado :)");
                }
                catch
                {
                    MessageBox.Show("Error inesperado :(\nLos datos no son correctos...");
                }
            }
            else MessageBox.Show("Falta informaciòn...");
        }

        private void DevolverBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string comandoDelete = string.Format("DELETE FROM cubiculos_usados_por_alumnos WHERE idcubiculosu = {0};", TXTCodCubDev.getTextFromTXT());
                string comandoUpdate = string.Format("UPDATE cubiculos SET disponibilidad = 1 WHERE idcubiculos = {0};", TXTCodCubDev.getTextFromTXT());

                Conexiones.ConnectDB.RealizarConexion(comandoDelete);
                Conexiones.ConnectDB.RealizarConexion(comandoUpdate);
                reloadCubiculos();
                MessageBox.Show("Cubiculo devuelto correctamente!! :) ");
            }
            catch
            {
                MessageBox.Show("Error inesperado :(");
            }
        }

        private bool validar()
        {
            bool notEmpty = true;

            if (TXTCodCubPres.getTextFromTXT() == string.Empty)
            {
                notEmpty = false;
                errorFormulario.SetError(TXTCodCubPres, "No admite campos vacios");
            }
            if (TXTCodigoAlum.getTextFromTXT() == string.Empty)
            {
                notEmpty = false;
                errorFormulario.SetError(TXTCodigoAlum, "No admite campos vacios");
            }

            return notEmpty;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //-------------------PRESTAR Y DEVOLVER BOTONES ----------------------------------------------------------------------------------------------------------------------------------



    }
}
