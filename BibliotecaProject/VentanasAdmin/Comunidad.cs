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
    public partial class Comunidad : Form
    {
        public Comunidad()
        {
            InitializeComponent();

            try
            {
                //PrestamosInfo.DataSource = ds.Tables[0];
                AlumnosDGV.DataSource = Conexiones.ConnectDB.RealizarConexion("SELECT alumnos.nombre, alumnos.codigo FROM alumnos, usuarios WHERE usuarios.codigo_alumno = alumnos.codigo;").Tables[0];
                AdministrativosDGV.DataSource = Conexiones.ConnectDB.RealizarConexion("SELECT administrativos.nombre_admin, administrativos.codigo_admin FROM administrativos, usuarios WHERE  usuarios.codigo_administrativo  = administrativos.codigo_admin;").Tables[0];
            }
            catch
            {
                MessageBox.Show("Error inesperado...");
            }

        }
    }
}
