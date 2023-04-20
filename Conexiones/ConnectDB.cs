using MySqlConnector;
using System.Data;

namespace Conexiones
{
    public class ConnectDB
    {
        public static MySqlConnection con;

        public static DataSet RealizarConexion(String cmd)
        {
            String cadena = "server=localhost;user=root;database=biblioteca;port=3306;password=admin";
            con = new MySqlConnection(cadena);
            con.Open();

            DataSet DS = new DataSet();
            MySqlDataAdapter DP = new MySqlDataAdapter(cmd, con);

            DP.Fill(DS);

            con.Close();

            return DS;
        }
    }
}