using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSkills_WinApp.DBControllers
{
    class DBConnector
    {
        #region Поля
        private static string ServerName { get { return "localhost"; } }
        private static string ServerPort { get { return "3306"; } }
        private static string User { get { return "root"; } }
        private static string Password { get { return "1234"; } }
        private static string DataBaseName { get { return "world_skills"; } }


        private static string _connectionString = $"server={ServerName};port={ServerPort};user={User};password={Password};database={DataBaseName}";

        private MySqlConnection Connection = new MySqlConnection(_connectionString);
        #endregion

        #region Методы
        public void OpenConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
            {
                Connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
            {
                Connection.Close();
            }
        }

        public MySqlConnection GetConnection()
        {
            return Connection;
        }
        #endregion
    }
}
