using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp2_OOP
{
    internal class DBase
    {
        MySqlConnection connection = new MySqlConnection(@"Server=localhost;Database=remcomplect;port=3300;User id=root;PASSWORD=1234");

        
        public void openConn()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConn()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection getConnection() 
            { 
            return connection;
        }
    }
}
