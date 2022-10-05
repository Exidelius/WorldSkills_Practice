using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WorldSkills_ClientApp.DBWorkers
{
    public static class DBController
    {
        #region Поля
        private static string ServerName { get { return "localhost"; } }
        private static string ServerPort { get { return "3306"; } }
        private static string User { get { return "root"; } }
        private static string Password { get { return "1234"; } }
        private static string DataBaseName { get { return "world_skills"; } }


        private static string _connectionString = $"server={ServerName};port={ServerPort};user={User};password={Password};database={DataBaseName}";

        private static MySqlConnection Connection = new MySqlConnection(_connectionString);
        #endregion

        #region Методы
        public static void OpenConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
            {
                Connection.Open();
            }
        }

        public static void CloseConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
            {
                Connection.Close();
            }
        }

        public static MySqlConnection GetConnection()
        {
            return Connection;
        }

        public static DataTable GetFromDB(string _command)
        {
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand(_command);

            OpenConnection();
            adapter.SelectCommand = command;
            command.Connection = GetConnection();
            adapter.Fill(table);
            CloseConnection();


            if (table.Rows.Count == 0) return null;

            return table;
        }
        #endregion
    }
}
