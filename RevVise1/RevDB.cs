using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace RevVise1
{
    internal class RevDB
    {
        private MySqlConnection dbConn;
        private MySqlCommand dbCommand;
        private MySqlDataAdapter da;
        private DataTable dt;
        private String strConn = "server=localhost;uid=root;pwd=;database=";
        public void dbConnect() // test connection
        {
            dbConn = new MySqlConnection(strConn);
            dbConn.Open();
            MessageBox.Show("Connection Successful");
            dbConn.Close();
        }

        public void dbConnect(String dbName) //actual connection
        {
            dbConn = new MySqlConnection(strConn+dbName);
            dbConn.Open();
            MessageBox.Show("Connection Successful");
            dbConn.Close();
        }

        public void SQLManager(String strQuery) // execute query
        {
            dbConn = new MySqlConnection(strConn + "db_revapp");
            dbConn.Open();
            dbCommand = new MySqlCommand(strQuery, dbConn);
            dbCommand.ExecuteNonQuery();
            dbConn.Close();
        }

        public DataTable getData(String query) 
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection(strConn + "db_revapp");

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }


    }
}
