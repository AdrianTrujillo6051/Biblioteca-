using MySqlConnector;
using System.Data;

namespace Conexiones
{
    public class ConnectDB
    {
        public static MySqlConnection con;

        public static DataSet RealizarConexion(String cmd)
        {
            DataSet DS = null;
            try 
            {
                String datosCon = "server=localhost;user=root;database=biblioteca;port=3306;password=";
                con = new MySqlConnection(datosCon);
                con.Open();

                DS = new DataSet();
                MySqlDataAdapter DP = new MySqlDataAdapter(cmd, con);

                DP.Fill(DS);

                con.Close();

  
            }
            catch {}

            return DS;

        }
    }
}