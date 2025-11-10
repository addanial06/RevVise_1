using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    }
}
