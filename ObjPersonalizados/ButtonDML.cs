using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjPersonalizados
{
    public partial class ButtonDML : Button
    {

        //Datos para diseño :)
        public int borderSize = 3;
        public int borderRadius = 40;
        public Color borderColor = Color.FromArgb(106,110,121);

        //Metodos para poder setear los datos al momento de diseñar,  personalizar mejor el boton :)
        public ButtonDML()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.FromArgb(106, 110, 121);
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
            InitializeComponent();
        }

        //Evento para evitar que el boton se deforme al momento de cambiarle el tamaño
        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height) borderRadius = this.Height;
        }


        //Metodo de dibujado pa nuestro boton
        private GraphicsPath TrazadoDeFgura(RectangleF rect, float radius)
        {
            //Iniciamos una figura
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            //Agregamos una curvatura por cada esquina, indicando los parametros de los limites de la esquina y al final desde  
            //que radio a que radio se pintara la curvatura de nuestro boton, esto cuatro veces, una por equina :)
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            //Retornamos el trazado de la figura :)
            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSuperficie = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorde = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            if (borderRadius > 2) //El boton sera un boton redondo :)
            {
                using (GraphicsPath pathSuperficie = TrazadoDeFgura(rectSuperficie, borderRadius))
                using (GraphicsPath pathBorde = TrazadoDeFgura(rectSuperficie, borderRadius - 1F))
                using (Pen dibujarSuperfuicie = new Pen(this.Parent.BackColor, 2))
                using (Pen dibujarBorde = new Pen(borderColor, borderSize))
                {
                    dibujarBorde.Alignment = PenAlignment.Inset;

                    //Dibujamos la superficie de los botones
                    this.Region = new Region(pathSuperficie);
                    e.Graphics.DrawPath(dibujarSuperfuicie, pathSuperficie);

                    //Dibujamos los bordes de los botones
                    if (borderSize >= 1) e.Graphics.DrawPath(dibujarBorde, pathBorde);


                }

            }
            else //Boton normal :( 
            {
                this.Region = new Region(rectSuperficie);

                if (borderSize >= 1)
                {
                    using (Pen dibujarBorde = new Pen(borderColor, borderSize))
                    {
                        dibujarBorde.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawRectangle(dibujarBorde, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }

            }
        }

        //Eventos que al chile no se que hacen pero el tuto los tenia y no dan error :)
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }
    }
}
