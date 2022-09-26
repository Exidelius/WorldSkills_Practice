using WorldSkills_WinApp.DBEntities;
using System.Data;
using System.Windows.Forms.VisualStyles;
using System;

namespace WorldSkills_WinApp.DBWorkers
{
    public static class UsersController
    {
        public static User Get(string login, string password)
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

            DataTable tableUser = DBController.GetFromDB(command);
            if (tableUser == null)
                return null;
            return new User(tableUser.Rows[0]);
        }

        public static int GetParticipantsCount(int competitionIndex)
        {
            string command = $@"
SELECT 
COUNT(*)
FROM `users` 
WHERE 
`users`.`competition` = '{competitionIndex}'
AND
`users`.`id_role` = '1';
";

            DataTable tableUser = DBController.GetFromDB(command);
            if (tableUser == null)
                return 0;
            return Convert.ToInt32(tableUser.Rows[0][0]);
        }

        public static int GetExpertsCount(int competitionIndex)
        {
            string command = $@"
SELECT 
COUNT(*)
FROM `users` 
WHERE 
`users`.`competition` = '{competitionIndex}'
AND
`users`.`id_role` > '1'
AND 
`users`.`id_role` < '6';
";

            DataTable tableUser = DBController.GetFromDB(command);
            if (tableUser == null)
                return 0;
            return Convert.ToInt32(tableUser.Rows[0][0]);
        }

        public static string[] GetExpertsNames(int competitionIndex)
        {
            string command = $@"
SELECT 
`users`.`FIO`
FROM `users` 
WHERE 
`users`.`competition` = '{competitionIndex}'
AND
`users`.`id_role` > '1'
AND 
`users`.`id_role` < '6';
";

            DataTable tableUser = DBController.GetFromDB(command);
            if (tableUser == null)
                return null;

            string[] result = new string[tableUser.Rows.Count];
            result[0] = "Все";
            for (int i = 0; i < tableUser.Rows.Count; i++)
            {
                result[i] = tableUser.Rows[i][0].ToString();
            }

            return result;
        }

        public static string GetMainExpertName(int competitionIndex)
        {
            string command = $@"
SELECT 
`users`.`FIO`
FROM `users` 
WHERE 
`users`.`competition` = '{competitionIndex}'
AND
`users`.`id_role` = '2';
";

            DataTable tableUser = DBController.GetFromDB(command);
            if (tableUser == null)
                return null;
            return (string)tableUser.Rows[0][0];
        }
    }
}
