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
    }
}
