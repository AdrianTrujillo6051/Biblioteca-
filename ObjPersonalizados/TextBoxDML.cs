using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjPersonalizados
{
    public partial class TextBoxDML : UserControl
    {
        public TextBoxDML()
        {
            InitializeComponent();
        }

        //Instancia del objeto que nos permite realizar validaciones :)
        Utilidades util = new Utilidades();

        //Campos estaticos :)

        public Color colorBorde = Color.FromArgb(26, 30, 41);

        public bool subrayadoEstilo = true;

        public int tamanoBorde = 4;

        [Category("TextBox properties")]
        public bool passCaracter
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }

        }

        [Category("TextBox properties")]
        public bool soloNumeros { get; set; }

        [Category("TextBox properties")]
        public bool soloLetras { get; set; }


        //Para manipular el texto de nuestro TextBox1 :)
        public string getTextFromTXT()
        {
            return textBox1.Text;
        }

        public void setTextFromTXT(string texto)
        {
            textBox1.Text = texto;
        }


        //Dibujado nuevo de nuestro TextBox
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            //Dibujamos el borde
            using (Pen dibujarBorde = new Pen(colorBorde, tamanoBorde))
            {
                dibujarBorde.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if (subrayadoEstilo) g.DrawLine(dibujarBorde, 0, this.Height - 1, this.Width, this.Height - 1); //Estilo linea
                else g.DrawRectangle(dibujarBorde, 0, 0, this.Width - 0.5F, this.Height - 0.5F); //Estilo caja              
            }
        }


        //Evitando bugs al redibujarlo en diseñador :)
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode) ActualizarAltura();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ActualizarAltura();
        }

        private void ActualizarAltura()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        //Evento para validaciones
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (soloNumeros) if (util.validarNumeros(e)) errorExiste.SetError(this, "Solo numeros");
                else if (soloLetras) if (util.validarLetras(e)) errorExiste.SetError(this, "Solo letras");
        }
    }
}
