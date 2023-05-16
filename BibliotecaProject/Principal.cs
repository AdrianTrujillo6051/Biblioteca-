using ObjPersonalizados;

using BibliotecaProject.VentanasAdmin;
using BibliotecaProject.VentanasUsers;
using BibliotecaProject.Funciones;
using System.Data;

namespace BibliotecaProject
{
    public partial class Principal : Form
    {


        //Variables usadas en la configuracion de botones admin or user
        int posXNextElement = 0;
        Boolean primeraIteracion = true;
        Boolean loginExitoso = true;

        //Variable para el control de formularios
        UtilGraficos utilGraficos = new UtilGraficos();
        public Form formActivo = null;

        public Principal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;




            Boolean admin = false;

            try
            {
                //Hacemos una consulta del ultimo Login a la BD para setear si es Admin o Alumno
                DataSet datos = Conexiones.ConnectDB.RealizarConexion("SELECT usuario_id FROM gente_biblioteca;");
                string util = datos.Tables[0].Rows[0]["usuario_id"].ToString();

                util = string.Format("DELETE FROM gente_biblioteca WHERE usuario_id = {0}; SELECT * FROM usuarios WHERE id = ({0});", util);
                datos = Conexiones.ConnectDB.RealizarConexion(util);
                string isAdminQuerry = datos.Tables[0].Rows[0]["esAdmin"].ToString();


                if (isAdminQuerry == "True")
                {
                    //Obtenemos nombre y seteamos nivel de privilegio :)
                    admin = true;
                    util = datos.Tables[0].Rows[0]["codigo_administrativo"].ToString();
                    util = string.Format("SELECT nombre_admin FROM administrativos WHERE codigo_admin = {0};", util);
                    datos = Conexiones.ConnectDB.RealizarConexion(util);
                    util = datos.Tables[0].Rows[0]["nombre_admin"].ToString();

                    UserLBL.Text = string.Format("Bienvenido: {0}", util);
                }
                else
                {
                    //Obtenemos nombre y seteamos nvel de privilegio
                    admin = false;
                    util = datos.Tables[0].Rows[0]["codigo_alumno"].ToString();
                    util = string.Format("SELECT nombre FROM alumnos WHERE codigo = {0};", util);
                    datos = Conexiones.ConnectDB.RealizarConexion(util);
                    util = datos.Tables[0].Rows[0]["nombre"].ToString();

                    UserLBL.Text = string.Format("Bienvenido: {0}", util);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha iniciado ninguna sesión recientemente, abriendo usuario. Error: " + ex);
            }





            //Cargamos el chatBot o alguna otra mamada:)
            ReposoForm form = new ReposoForm();
            utilGraficos.openForm(form, this.formActivo, this.PanelSubventanas);

            //Creamos una lista con nuestros botones, esto con el fin de poder acomodarlos y habilitar
            //los ques sean admin o usuario, dinamicamente claro esta :)
            //Y seguiran el orden que tenemos aqui :)
            List<CircleButton> botonesNav = new List<CircleButton>();
            List<Label> labelsNav = new List<Label>();

            botonesNav.Add(buscarLibBTN);
            labelsNav.Add(buscadorLBL);

            botonesNav.Add(BTNEntrSalid);
            labelsNav.Add(entradasLBL);

            botonesNav.Add(BTNPrestCub);
            labelsNav.Add(cubiculosLBL);

            botonesNav.Add(BTNGenteEnBib);
            labelsNav.Add(genteLBL);

            botonesNav.Add(BTNRegistros);
            labelsNav.Add(registrosLBL);

            botonesNav.Add(BTNLibrosPrest);
            labelsNav.Add(prestamosLBL);

            botonesNav.Add(BTNPrestamos);
            labelsNav.Add(historialLBL);

            //Ocultamos todos los botones para despues mostrar unicamente los que necesitamos :)
            foreach (CircleButton elemento in botonesNav) elemento.Visible = false;
            foreach (Label elemento in labelsNav) elemento.Visible = false;

            //Contador para nuestras etiquetas
            int cont = 0;

            foreach (CircleButton elemento in botonesNav)
            {
                Label etiqueta = labelsNav[cont];
                if (admin)
                {
                    ColocarBoton(elemento, etiqueta);
                }
                else if (elemento.Admin != true)
                {
                    ColocarBoton(elemento, etiqueta);
                }

                cont++;
            }
        }

        //Metodo para colocar botones :)
        void ColocarBoton(CircleButton elemento, Label etiqueta)
        {

            //Checamos si es el primer boton que colocamos, para otorgarle un Padding respecto al panelInfo
            //Si no, solo lo colocamos en la siguiente posicion X calculada :)
            elemento.Visible = true;
            elemento.Size = new Size(120, 120);
            elemento.borderRadius = 120;
            etiqueta.Visible = true;

            if (primeraIteracion)
            {
                elemento.Location = new System.Drawing.Point(52, 23);
                etiqueta.Location = new System.Drawing.Point(82, 150);
                primeraIteracion = false;
            }
            else
            {
                elemento.Location = new System.Drawing.Point(posXNextElement, 23);
                etiqueta.Location = new System.Drawing.Point(posXNextElement + 30, 150);
            }

            int posX = elemento.Location.X;
            int size = elemento.Width;

            posXNextElement = posX + size + 42;
        }


        //Timer event 
        private void Reloj_Tick(object sender, EventArgs e)
        {
            //Seteamos la hora con nuestro timer, pero mandamos parametros personalizados para mostrart un formato especifico :)
            HoraLBL.Text = DateTime.Now.ToString("hh:mm tt");
            FechaLBL.Text = DateTime.Now.ToString("dddd,MMMM dd");
        }

        //BOTONES CODIGO DE REDIRECCIONAMIENTO----------------------------------------------------------------------------------------------------------------------------------

        //Registros de datos :ADMIN
        private void BTNRegistros_Click(object sender, EventArgs e)
        {
            DMLMain form = new DMLMain();
            formActivo = utilGraficos.openForm(form, this.formActivo, this.PanelSubventanas);
        }


        //Prestamos de libros :ADMIN
        private void BTNLibrosPrest_Click(object sender, EventArgs e)
        {
            LibrosPrestamos form = new LibrosPrestamos();
            formActivo = utilGraficos.openForm(form, this.formActivo, this.PanelSubventanas);
        }

        //Prestamos de cubiculos :USER
        private void BTNPrestCub_Click(object sender, EventArgs e)
        {
            Cubiculos form = new Cubiculos();
            formActivo = utilGraficos.openForm(form, this.formActivo, this.PanelSubventanas);
        }

        private void BTNPrestamos_Click(object sender, EventArgs e)
        {
            Prestamos form = new Prestamos();
            formActivo = utilGraficos.openForm(form, this.formActivo, this.PanelSubventanas);
        }

        private void buscarLibBTN_Click(object sender, EventArgs e)
        {
            BuscadorLibros form = new BuscadorLibros();
            formActivo = utilGraficos.openForm(form, this.formActivo, this.PanelSubventanas);
        }



        private void BTNEntrSalid_Click(object sender, EventArgs e)
        {
            EntradaSalidacs form = new EntradaSalidacs();
            formActivo = utilGraficos.openForm(form, this.formActivo, this.PanelSubventanas);
        }

        private void BTNGenteEnBib_Click(object sender, EventArgs e)
        {
            Comunidad form = new Comunidad();
            formActivo = utilGraficos.openForm(form, this.formActivo, this.PanelSubventanas);
        }

        //BOTONES CODIGO DE REDIRECCIONAMIENTO----------------------------------------------------------------------------------------------------------------------------------


    }
}