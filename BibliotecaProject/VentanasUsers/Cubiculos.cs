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

        private void evento(object sender, EventArgs e)
        {
            Button botonCubi = sender as Button;
            int filaInfo = Convert.ToInt16(botonCubi.Text) - 1;
            int dispo = Convert.ToInt16(CubiculosInfoDGV.Rows[filaInfo].Cells[2].Value);
            String estadoCub;

            if (dispo == 1) estadoCub = "Disponible";
            else estadoCub = "No disponible";

            MessageBox.Show("\nIDCubiculo: " + CubiculosInfoDGV.Rows[filaInfo].Cells[0].Value.ToString() + "\nAsientos: " + CubiculosInfoDGV.Rows[filaInfo].Cells[1].Value.ToString() + "\nDisponibilidad: " + estadoCub);
        }
    }
}
