using BibliotecaProject.Funciones;
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

namespace BibliotecaProject
{
    public partial class ReposoForm : Form
    {
        //Hacemos una lista de los libros que vamos a mostrar :)
        List<librosGaleria> libros = new List<librosGaleria>();
        int librosNum, librosCont = 0;

        public ReposoForm()
        {
            InitializeComponent();
            //Ajustamos el tamaño dependiendo de la resolucion
            double altura = Screen.PrimaryScreen.Bounds.Height;

            if (altura < 800)
            {
                frontPageImg.Size = new Size(285, 376);
                //int posX = elemento.Location.X;
                //elemento.Location = new System.Drawing.Point(52, 23);
                lblAutor.Location = new System.Drawing.Point(lblAutor.Location.X - 170, lblAutor.Location.Y);
                lblDescrrpcion.Location = new System.Drawing.Point(lblDescrrpcion.Location.X - 170, lblDescrrpcion.Location.Y);
                lblTitulo.Location = new System.Drawing.Point(lblTitulo.Location.X - 170, lblTitulo.Location.Y);
            }

            //NOTA: Si quieren añadir libros deben de cargar primero una imagen a los recursos locales del proyecto, despues crear un objeto como los de abajo con la estructura:
            //* Imagen * Titulo * Autor * Sinopsis
            libros.Add(new librosGaleria(Properties.Resources.book11, "Donde habitan los ángeles", "Claudia Celis", "“¿Por qué todos aquellos a los que amamos en la vida tienen que desaparecer?”, se pregunta Pancho, el protagonista. Esta novela recoge sus memorias y recuerdos desde la perspectiva de su juventud. Durante las vacaciones, Pancho y otros sobrinos de Tacho y Chabela llenan de alegría la casa de San Miguel. En esos breves lapsos, los tíos olvidan la tristeza que la muerte de su hijo les dejó. Al término de las vacaciones todos los sobrinos vuelven a su hogar, pero en una ocasión Pancho no lo hace: abandonado por su madre, atractiva viuda, y después de esperarla mucho tiempo, se convierte en el hijo de sus tíos."));

            libros.Add(new librosGaleria(Properties.Resources.book3, "Homo Deus", "Yuval Noah Harari", " A lo largo del último siglo, la humanidad ha logrado lo imposible frenando la hambruna, la peste y la guerra. Por primera vez en la historia, más personas mueren por obesidad que por pasar hambre y hay más probabilidades de quitarse la vida que de morir en un conflicto bélico o un atentado terrorista. ¿Qué pasará con la democracia cuando Google y Facebook lleguen a conocer nuestros gustos y preferencias políticas nos conocemos a nosotros mismos? ¿Qué pasará con el estado de bienestar cuando la inteligencia artificial expulse a los individuos del mercado laboral, creando una «clase innecesaria» de humanos? ¿Cómopodremos lidiar con los avances en ingeniería genética? ¿Terminará Silicon Valley por establecer nuevas religiones en lugar de enfocarse a producir únicamente dispositivos inteligentes?"));

            libros.Add(new librosGaleria(Properties.Resources.book4, "El Aleph", "Jorge Luis Borges", "Sus textos remiten a una infinidad de fuentes y bibliografías en torno a las cuales se articulan mitos y metáforas de la tradición literaria universal. Esta obra marca un punto de inflexión respecto al estilo que destilaba su colección anterior de cuentos, Ficciones; aún manteniendo su estilo sobrio y perfeccionista, el escritor aborda aquí otra serie de eventos u objetos inverosímiles enmarcados en un ambiente realista, lo que contribuye a resaltar su carácter fantástico. Así como los cuentos de Ficciones describen mundos imposibles, los de El Aleph revelan grietas en la lógica de la realidad; muestran una irrealidad secreta y oculta que, aunque es más visible en cuentos como El Zahir, La escritura del dios o El Aleph, también está presente aunque de una forma más sutil en otros aparentemente más realistas como Emma Zunz o El muerto"));

            libros.Add(new librosGaleria(Properties.Resources.book5, "Rayuela", "Julio Cortázar", "El amor turbulento de Oliveira y La Maga, los amigos del Club de la Serpiente, las caminatas por Paría en busca del cielo y el infierno tienen su reverso en la aventura simétrica de Oliveira, Talira y Traveler en un Buenos Aires teñido por el recuerdo.\nLa novela se puede leer de dos maneras: de forma lineal, empezando por el primer capítulo, seguido del segundo, y así sucesivamente hasta el final, o, empezando por el capítulo 73 y siguiendo el orden propuesto y desordenado que señala Cortázar.\nEn este orden que aconseja Cortázar, pasas rápidamente de los primeros capítulos del libro a los finales, y viceversa, como si se tratase de una Rayuela, el juego infantil en el que se basó el autor para darle la estructura al libro.  "));

            libros.Add(new librosGaleria(Properties.Resources.book2, "Cien años de soledad", "Gabriel García Márquez", "Entre la boda de José Arcadio Buendía con Amelia Iguarán hasta la maldición de Aureliano Babilonia transcurre todo un siglo. Cien años de soledad para una estirpe única, fantástica, capaz de fundar una ciudad tan especial como Macondo y de engendrar niños con cola de cerdo. En medio, una larga docena de personajes dejarán su impronta a las generaciones venideras, que tendrán que lidiar con un mundo tan complejo como sencillo."));

            librosNum = libros.Count;
        }

        private void reloj_Tick(object sender, EventArgs e)
        {
            //Por cada click (15 segundos) seteamos los datos a los siguientes datos del libro :)
            if (librosCont < librosNum)
            {
                frontPageImg.BackgroundImage = libros[librosCont].getFoto();
                frontPageImg.BackgroundImageLayout = ImageLayout.Stretch;
                lblAutor.Text = libros[librosCont].getAutor();
                lblTitulo.Text = libros[librosCont].getTitulo();
                lblDescrrpcion.Text = libros[librosCont].getDescripcion();

                librosCont++;

            }
            else librosCont = 0;
        }


    }
}
