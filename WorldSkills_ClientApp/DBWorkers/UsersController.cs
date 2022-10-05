using System.Collections.Generic;
using System.Data;
using WorldSkills_ClientApp.DBEntities;

namespace WorldSkills_ClientApp.DBWorkers
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
`users`.`competition`,
`users`.`is_active`";

        public static User Get(string code)
        {
            string command = $@"
SELECT 
{SELECT_ALL}
FROM `users` 
WHERE 
`users`.`PIN` = '{code}';";

            DataTable tableUser = DBController.GetFromDB(command);
            if (tableUser == null)
                return null;
            return new User(tableUser.Rows[0]);
        }

        public static List<User> Get(User user)
        {
            string command = $@"
SELECT 
{SELECT_ALL}
FROM `users` 
WHERE 
`users`.`competition` = '{user.Competition}';";

            DataTable tableUser = DBController.GetFromDB(command);
            if (tableUser == null)
                return new List<User>();

            List<User> result = new List<User>();

            for (int i = 0; i < tableUser.Rows.Count; i++)
            {
                result.Add(new User(tableUser.Rows[i]));
            }

            return result;
        }
    }
}
