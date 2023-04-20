using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaProject.Funciones
{
    internal class UtilGraficos
    {
        //Recibimos tres parametros, uno sera el formulario a abrir, otro el formulario que esta activo y el ultimo el panel donde lo debemos colocar
        public void openForm(Form formularioAbrir, Form formularioActivo, Panel panelFormularios) { 
            //Cerramos el formulario activo si es que existe ;)
            if(formularioActivo != null) formularioActivo.Close();

            //Conifguramos y mostramos el formulario
            formularioActivo = formularioAbrir;
            formularioAbrir.TopLevel = false;
            formularioAbrir.FormBorderStyle = FormBorderStyle.None;
            formularioAbrir.Dock = DockStyle.Fill;
            panelFormularios.Controls.Add(formularioAbrir);
            panelFormularios.Tag = formularioAbrir;
            formularioAbrir.BringToFront();
            formularioAbrir.Show();
        }
    }
}
