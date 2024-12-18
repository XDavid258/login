using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SistemaLoginControlVersionesRepositorioRemoto.Data
{
    internal class Conection
    {
        public static string server = "127.0.0.1";
        public static string dataBase = "login";
        public static string user = "root";
        public static string pwd = "Axel69";

        // Instancia para poder acceder a la base de datos
        public static MySqlConnection connMaster = new MySqlConnection();

        public static void OpenConnection()
        {
            string ConnectionString = $"server={server};database={dataBase};user={user};password={pwd};";
            connMaster = new MySqlConnection(ConnectionString);

            connMaster.Open();

            if (connMaster.State == ConnectionState.Open)
            {
                MessageBox.Show("conexión establecida");
            }

        }
        public static void CloseConnection()
        {

        }


    }
}
