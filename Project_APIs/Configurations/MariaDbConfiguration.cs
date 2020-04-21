using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_APIs.Configurations
{
    public class MariaDbConfiguration
    {
        public MySqlConnection Connection { get; set; }

        public MariaDbConfiguration(string connectionString)
        {
            Connection = new MySqlConnection()
        }
    }
}
