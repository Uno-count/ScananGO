using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace Scanan_go.Classes
{
    public class connection
    {
        MySqlConnection con = new MySqlConnection("server=localhost;database=scanango;uid=root;password=");

        public MySqlConnection Activecon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
    }
}
