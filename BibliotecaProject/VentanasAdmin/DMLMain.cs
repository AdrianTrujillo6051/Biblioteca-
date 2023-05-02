using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaProject.Funciones;

namespace BibliotecaProject.VentanasAdmin
{
    public partial class DMLMain : Form
    {
        //Variables para control de ventanas
        Form formActivo = null;
        UtilGraficos utilGraficos = new UtilGraficos();

        public DMLMain()
        {
            InitializeComponent();
        }

        private void BTNAlumDML_Click(object sender, EventArgs e)
        {
            DMLAlumn dMLAlumn = new DMLAlumn();
            utilGraficos.openForm(dMLAlumn, formActivo, this.panelSubVentanas);
        }

        private void AlumnBtn_Click(object sender, EventArgs e)
        {
            DMLAlumn form = new DMLAlumn();
            utilGraficos.openForm(form, formActivo, panelSubVentanas);
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
