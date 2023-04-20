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
    public partial class TextBoxPers : UserControl
    {
        //Campos modificables prro
        [Category("TextBox properties")]
        public Color colorBorde { get; set; }

        [Category("TextBox properties")]
        public int tamanoBorde { get; set; }

        [Category("TextBox properties")]
        public bool subrayadoEstilo { get; set; }

        [Category("TextBox properties")]
        public bool passCaracter
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }

        }

        public TextBoxPers()
        {
            InitializeComponent();
        }

        //Para obtener el texto de nuestro TextBox1 :)
        public string getTextFromTXT()
        {
            return textBox1.Text;
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
    }
}
