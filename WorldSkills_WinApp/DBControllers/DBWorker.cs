using MySql.Data.MySqlClient;
using WorldSkills_WinApp.DBEntities;
using System.Data;
using System.Collections.Generic;
using System;

namespace WorldSkills_WinApp.DBControllers
{
    public static class DBWorker
    {
        public static User GetUser(string login, string password)
        {
            string command = $@"
SELECT 
`users`.`id`, 
`users`.`FIO`,
`users`.`gender`,
`users`.`date_birthday`,
`users`.`id_role`,
`users`.`skill`,
`users`.`region`,
`users`.`place`,
`users`.`competition`
FROM `users` 
WHERE 
`users`.`PIN` = '{login}' AND 
`users`.`password` = '{password}';";

            DataTable tableUser = GetFromDB(command);
            if (tableUser == null) 
                return null;
            return new User(tableUser.Rows[0]);
        }

        public static List<Competition> GetCompetitions()
        {
            string command = $@"
SELECT *
FROM `competition` 
WHERE 
DATEDIFF('{DateTime.Now.ToString("yyyy-MM-dd")}', `competition`.`date_start`) <= {Competition.INTERVAL};";

            DataTable tableCompetition = GetFromDB(command);
            if (tableCompetition == null)
                return null;

            List<Competition> result = new List<Competition>();

            for (int i = 0; i < tableCompetition.Rows.Count; i++)
            {
                result.Add(new Competition(tableCompetition.Rows[i]));
            }

            return result;
        }

        public static string[] GetRoles()
        {
            string command = "SELECT * FROM `role`";
            DataTable tableRoles = GetFromDB(command);

            if (tableRoles == null) 
                return null;
            
            string[] result = new string[tableRoles.Rows.Count + 1];
            result[0] = "Все";
            for (int i = 0; i < tableRoles.Rows.Count; i++)
            {
                result[i + 1] = tableRoles.Rows[i][1].ToString();
            }

            return result;
        }

        // TODO подумать о том, нужно ли оно на самом деле в дальнейшей перспективе.
        public static Competition GetCompetition(int id)
        {
            string command = $@"
SELECT *
FROM `competition` 
WHERE 
`competition`.`id` = '{id}';";

            DataTable tableCompetition = GetFromDB(command);
            if (tableCompetition == null)
                return null;
            return new Competition(tableCompetition.Rows[0]);
        }

        private static DataTable GetFromDB(string _command)
        {
            DBConnector db = new DBConnector();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand(_command);

            db.OpenConnection();
            adapter.SelectCommand = command;
            command.Connection = db.GetConnection();
            adapter.Fill(table);
            db.CloseConnection();


            if (table.Rows.Count == 0) return null;

            return table;
        }
    }
}
