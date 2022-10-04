using WorldSkills_WinApp.DBEntities;
using System.Data;
using System;

namespace WorldSkills_WinApp.DBWorkers
{
    public static class UsersController
    {

        private const string SELECT_ALL = @"
`users`.`id`, 
`users`.`FIO`,
`users`.`gender`,
`users`.`date_birthday`,
`users`.`id_role`,
`users`.`skill`,
`users`.`region`,
`users`.`place`,
`users`.`competition`";

        //    Id = id;
        //    FIO = fIO;
        //    Gender = gender;
        //    DateBirthday = dateBirthday;
        //    Role = role;
        //    Skill = skill;
        //    Region = region;
        //    Place = place;
        //    Competition = competition;

        //Id = (int) rowUser[0];
        //FIO = (string) rowUser[1];
        //Gender = (string) rowUser[2];
        //DateBirthday = DateTime.ParseExact(rowUser[3].ToString(), "dd.MM.yyyy s:mm:HH", null);
        //Role = Convert.ToInt32(rowUser[4].ToString());
        //Skill = Convert.ToInt32(rowUser[5].ToString());
        //Region = Convert.ToInt32(rowUser[6].ToString());
        //Place = Convert.ToInt32(rowUser[7].ToString());
        //Competition = Convert.ToInt32(rowUser[8].ToString());

        public static User Get(string login, string password)
        {
            string command = $@"
SELECT 
{SELECT_ALL}
FROM `users` 
WHERE 
`users`.`PIN` = '{login}' AND 
`users`.`password` = '{password}';";

            DataTable tableUser = DBController.GetFromDB(command);
            if (tableUser == null)
                return null;
            return new User(tableUser.Rows[0]);
        }

        public static User[] Get(Competition competition, RolesController.RoleToSelect role)
        {
            string command = $@"
SELECT 
{SELECT_ALL}
FROM `users` 
WHERE 
`users`.`competition` = '{competition.Id}'{BuildRoles(role)};";

            DataTable tableUser = DBController.GetFromDB(command);
            if (tableUser == null || tableUser.Rows.Count == 0)
                return new User[0];

            User[] result = new User[tableUser.Rows.Count];
            for (int i = 0; i < tableUser.Rows.Count; i++)
            {
                result[i] = new User(tableUser.Rows[i]);
            }

            return result;
        }

        public static User[] Get(Competition competition, int role, int skill)
        {
            string command = $@"
SELECT 
{SELECT_ALL}
FROM `users` 
WHERE 
`users`.`competition` = '{competition.Id}'{BuildRoles(role)}{BuildSkillS(skill)};";

            DataTable tableUser = DBController.GetFromDB(command);
            if (tableUser == null || tableUser.Rows.Count == 0)
                return new User[0];

            User[] result = new User[tableUser.Rows.Count];
            for (int i = 0; i < tableUser.Rows.Count; i++)
            {
                result[i] = new User(tableUser.Rows[i]);
            }

            return result;
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

        private static string BuildRoles(RolesController.RoleToSelect role)
        {
            switch (role)
            {
                case RolesController.RoleToSelect.All:
                    return "";
                case RolesController.RoleToSelect.Experts:
                    return @"
AND
`users`.`id_role` > '1'
AND 
`users`.`id_role` < '6'";
                case RolesController.RoleToSelect.MainExperts:
                    return @"
AND
`users`.`id_role` > '2'
AND 
`users`.`id_role` < '6'";
                case RolesController.RoleToSelect.Participants:
                    return @"
AND
`users`.`id_role` = '1'";
                default:
                    return "";
            }
        }

        private static string BuildRoles(int role)
        {
            if (role == -1)
                return "";

            return $@"
AND
`users`.`id_role`='{role}'";
        }

        private static string BuildSkillS(int skill) {
            if (skill == -1)
                return "";

            return $@"
AND
`users`.`skill`='{skill}'";
        }
    }
}
