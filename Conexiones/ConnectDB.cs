﻿using MySqlConnector;
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
                String datosCon = "server=localhost;user=root;database=biblioteca;port=3306;password=admin";
                con = new MySqlConnection(datosCon);
                con.Open();

                DS = new DataSet();
                MySqlDataAdapter DP = new MySqlDataAdapter(cmd, con);

                DP.Fill(DS);

                con.Close();

  
            }
            catch {
                String datosCon = "server=localhost;user=root;database=biblioteca;port=3306;password=03052003";
                con = new MySqlConnection(datosCon);
                con.Open();

                DS = new DataSet();
                MySqlDataAdapter DP = new MySqlDataAdapter(cmd, con);

                DP.Fill(DS);

                con.Close();
            }

            return DS;

        }
    }
}