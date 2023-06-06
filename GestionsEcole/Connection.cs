using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionsEcole
{
    class Connection
    {
        private static string connectionString = "server=btssio.dedyn.io;Database=MISSILO_GestionEcole;Uid=MISSILO;password=09082001";
        private static MySqlConnection maConnection= new MySqlConnection(connectionString);

        public static MySqlConnection MaConnection { get => maConnection; }

        public static MySqlConnection NewConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public static bool OpenConnection()
        {
            try
            {
                MaConnection.Open();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public static bool CloseConnection()
        {
            try
            {
                MaConnection.Close();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
