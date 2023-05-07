using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaProject.VentanasUsers
{
    public partial class LibrosPrestamos : Form
    {
        public LibrosPrestamos()
        {
            InitializeComponent();
        }


        //Hacer un prestamo
        private void BTNEnviar_Click(object sender, EventArgs e)
        {
            string fecha = "null";
            if (TXTFecha.getTextFromTXT() != string.Empty) fecha = TXTFecha.getTextFromTXT();

            //Validamos si los campos no estan vacios 
            if (validar())
            {
                try
                {
                    //Insertamos en la tabla relacional :)
                    string comandoInsert = string.Format("INSERT INTO prestamolibros(codigo, isbn, fechaprestamo, retardo, codigo_admin) VALUES ({0},{1},{2},{3},{4});",
                    TXTCodAlm.getTextFromTXT(), TXTIsbn.getTextFromTXT(), fecha, 0, TXTCodAdm.getTextFromTXT());

                    Conexiones.ConnectDB.RealizarConexion(comandoInsert);
                    MessageBox.Show("Incersion correctamente realizada");

                }
                catch (Exception ex)
                { MessageBox.Show("Error inesperado :( " + ex); }

            }
        }


        //Devolver un prestamo
        private void BTNReturn_Click(object sender, EventArgs e)
        {
            if (validarRet())
            {
                try
                {
                    //Agarramos los datos de nuestra consulta prestamos libros para reinsertarlos de nuevo en el historial
                    string comandoSelect = string.Format("SELECT * FROM prestamolibros WHERE codigo = {0} AND isbn = {1}; ", TXTRETCod.getTextFromTXT(), TXTRETIsbn.getTextFromTXT());
                    DataSet ds = Conexiones.ConnectDB.RealizarConexion(comandoSelect);

                    string codigo = ds.Tables[0].Rows[0]["codigo"].ToString().Trim();
                    string isbn = ds.Tables[0].Rows[0]["isbn"].ToString().Trim();
                    string fechaprestamo = ds.Tables[0].Rows[0]["fechaprestamo"].ToString().Trim();
                    string retardo = ds.Tables[0].Rows[0]["retardo"].ToString().Trim();
                    string codigoAdmin = ds.Tables[0].Rows[0]["codigo_admin"].ToString().Trim();

                    if (fechaprestamo == string.Empty) fechaprestamo = "null";

                    //Insertamos el prestamo en el historial :)
                    string comandoInsert = string.Format("INSERT INTO historial(codigoA, isbnL, fechaprestamoo, retardoo, admin_cargo) VALUES({0}, {1}, {2}, {3}, {4});", codigo, isbn, fechaprestamo, retardo, codigoAdmin);
                    Conexiones.ConnectDB.RealizarConexion(comandoInsert);

                    string comandoDelete = string.Format("DELETE FROM prestamolibros  WHERE codigo = {0} AND isbn = {1};", TXTRETCod.getTextFromTXT(), TXTRETIsbn.getTextFromTXT());
                    Conexiones.ConnectDB.RealizarConexion(comandoDelete);

                    MessageBox.Show("Libro devuelto correctamente...");
                }
                catch (Exception ex)
                { MessageBox.Show("Error inesperado :( " + ex); }

            }
        }

        //Validamos
        private bool validar()
        {
            bool notEmpty = true;

            if (TXTCodAdm.getTextFromTXT() == string.Empty)
            {
                notEmpty = false;
                errorForm.SetError(TXTCodAdm, "No admite campos vacios");
            }
            if (TXTCodAlm.getTextFromTXT() == string.Empty)
            {
                notEmpty = false;
                errorForm.SetError(TXTCodAlm, "No admite campos vacios");
            }
            if (TXTIsbn.getTextFromTXT() == string.Empty)
            {
                notEmpty = false;
                errorForm.SetError(TXTIsbn, "No admite campos vacios");
            }

            return notEmpty;
        }

        //Validamos
        private bool validarRet()
        {
            bool notEmpty = true;

            if (TXTRETCod.getTextFromTXT() == string.Empty)
            {
                notEmpty = false;
                errorForm.SetError(TXTRETCod, "No admite campos vacios");
            }
            if (TXTRETIsbn.getTextFromTXT() == string.Empty)
            {
                notEmpty = false;
                errorForm.SetError(TXTRETIsbn, "No admite campos vacios");
            }

            return notEmpty;
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
