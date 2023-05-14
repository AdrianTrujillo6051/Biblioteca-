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
            panelBTNsCreate.Visible = false;
            panelBTNsDelete.Visible = false;
            panelBTNsUpdate.Visible = false;
        }

        //Metodos de navegación :)
        private void hideSubMenu()
        {
            if (panelBTNsDelete.Visible) panelBTNsDelete.Visible = false;
            if (panelBTNsUpdate.Visible) panelBTNsUpdate.Visible = false;
            if (panelBTNsCreate.Visible) panelBTNsCreate.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == true)
            {
                hideSubMenu();
            }
            else
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
        }


        //----------    CREATE DATA BUTTONS ---------------------------------------------------------------------
        private void AlumnBtn_Click(object sender, EventArgs e)
        {
            DMLAlumn form = new DMLAlumn();
            formActivo = utilGraficos.openForm(form, formActivo, panelSubVentanas);
        }

        private void CubiBtn_Click(object sender, EventArgs e)
        {
            DMLCubi form = new DMLCubi();
            formActivo = utilGraficos.openForm(form, formActivo, panelSubVentanas);
        }

        private void LibrosBtn_Click(object sender, EventArgs e)
        {
            DMLLibros form = new DMLLibros();
            formActivo = utilGraficos.openForm(form, formActivo, panelSubVentanas);

        }

        private void AdminBTN_Click(object sender, EventArgs e)
        {
            DMLAdministrativos form = new DMLAdministrativos();
            formActivo = utilGraficos.openForm(form, formActivo, panelSubVentanas);
        }

        //----------    UPDATE DATA BUTTONS ---------------------------------------------------------------------
        private void AdminUpd_Click(object sender, EventArgs e)
        {

        }

        private void LibrosUpd_Click(object sender, EventArgs e)
        {

        }

        private void CubiculosUpd_Click(object sender, EventArgs e)
        {

        }

        private void AlumnosUpd_Click(object sender, EventArgs e)
        {

        }
        //----------    DELETE DATA BUTTONS ---------------------------------------------------------------------
        private void AdminDel_Click(object sender, EventArgs e)
        {
            DMLEliAd form = new DMLEliAd();
            formActivo = utilGraficos.openForm(form, formActivo, panelSubVentanas);
        }

        private void LibrosDel_Click(object sender, EventArgs e)
        {

        }

        private void CubiculosDel_Click(object sender, EventArgs e)
        {

        }

        private void AlumnDel_Click(object sender, EventArgs e)
        {
            DMLEliAlum form = new DMLEliAlum();
            formActivo = utilGraficos.openForm(form, formActivo, panelSubVentanas);
        }

        //----------    SUBPANELS BUTTONS ---------------------------------------------------------------------
        private void BTNpanelCREATE_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBTNsCreate);
        }

        private void BTNPanelUpdate_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBTNsUpdate);
        }

        private void BTNpanelDelete_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBTNsDelete);
        }
    }
}
