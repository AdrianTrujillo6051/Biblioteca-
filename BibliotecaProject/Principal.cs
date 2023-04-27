using ObjPersonalizados;
using BibliotecaProject.VentanasAdmin;
using BibliotecaProject.VentanasUsers;
using BibliotecaProject.Funciones;

namespace BibliotecaProject
{
    public partial class Principal : Form
    {
        //Variables usadas en la configuracion de botones admin or user
        int posXNextElement = 0;
        Boolean primeraIteracion = true;

        //Variable para el control de formularios
        UtilGraficos utilGraficos = new UtilGraficos();
        Form formActivo = null;

        public Principal()
        {
            InitializeComponent();

            //Prueba para implementar admin or user
            Boolean admin = true;
            UserLBL.Text = "Bienvenido: Alfredo";

            //Cargamos el chatBot o alguna otra mamada:)
            ReposoForm form = new ReposoForm();
            utilGraficos.openForm(form, formActivo, this.PanelSubventanas);

            //Creamos una lista con nuestros botones, esto con el fin de poder acomodarlos y habilitar
            //los ques sean admin o usuario, dinamicamente claro esta :)
            //Y seguiran el orden que tenemos aqui :)
            List<CircleButton> botonesNav = new List<CircleButton>();

            botonesNav.Add(BTNEntrSalid);
            botonesNav.Add(BTNPrestCub);
            botonesNav.Add(BTNGenteEnBib);
            botonesNav.Add(BTNRegistros);
            botonesNav.Add(BTNLibrosPrest);

            //Ocultamos todos los botones para despues mostrar unicamente los que necesitamos :)
            foreach (CircleButton elemento in botonesNav) elemento.Visible = false;

            foreach (CircleButton elemento in botonesNav)
            {
                if (admin)
                {
                    ColocarBoton(elemento);
                }
                else if (elemento.Admin != true)
                {
                    ColocarBoton(elemento);
                }
            }
        }

        //Metodo para colocar botones :)
        void ColocarBoton(CircleButton elemento)
        {

            //Checamos si es el primer boton que colocamos, para otorgarle un Padding respecto al panelInfo
            //Si no, solo lo colocamos en la siguiente posicion X calculada :)
            elemento.Visible = true;
            elemento.Size = new Size(129, 129);
            elemento.borderRadius = 129;

            if (primeraIteracion)
            {
                elemento.Location = new System.Drawing.Point(52, 23);
                primeraIteracion = false;
            }
            else
            {
                elemento.Location = new System.Drawing.Point(posXNextElement, 23);
            }

            int posX = elemento.Location.X;
            int size = elemento.Width;

            posXNextElement = posX + size + 52;
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
            utilGraficos.openForm(form, formActivo, this.PanelSubventanas);
        }


        //Prestamos de libros :ADMIN
        private void BTNLibrosPrest_Click(object sender, EventArgs e)
        {
            LibrosPrestamos form = new LibrosPrestamos();
            utilGraficos.openForm(form, formActivo, this.PanelSubventanas);
        }

        //Prestamos de cubiculos :USER
        private void BTNPrestCub_Click(object sender, EventArgs e)
        {
            Cubiculos form = new Cubiculos();
            utilGraficos.openForm(form, formActivo, this.PanelSubventanas);
        }

        //BOTONES CODIGO DE REDIRECCIONAMIENTO----------------------------------------------------------------------------------------------------------------------------------

        //Resize event, para adaptar el tamaño de algo nuc


    }
}