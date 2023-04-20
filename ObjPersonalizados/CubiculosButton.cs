using ObjPersonalizados.Properties;
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
    public partial class CubiculosButton : ButtonDML
    {
        public CubiculosButton()
        {
            //Como heredamos de la clase BOTON ya personalizado, solo seteamos unos parametros nuevos para poder usar este boton :)
            this.Size = new Size(150, 165);
            this.Image = Properties.Resources.cube128px;
            this.ImageAlign = ContentAlignment.BottomCenter;
            this.Padding = new Padding(8);
            this.TextAlign = ContentAlignment.TopCenter;

            InitializeComponent();
        }

    }
}
