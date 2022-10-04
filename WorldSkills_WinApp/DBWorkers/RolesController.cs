using System;
using System.Data;

namespace WorldSkills_WinApp.DBWorkers
{
    public static class RolesController
    {
        public enum RoleToSelect { All=-1, Experts, MainExperts, Participants }

        public static string[] Get()
        {
            string command = "SELECT `role`.`role` FROM `role`;";
            DataTable tableRoles = DBController.GetFromDB(command);

            if (tableRoles == null)
                return new string[0];

            string[] result = new string[tableRoles.Rows.Count + 1];
            result[0] = "Все";

            for (int i = 0; i < tableRoles.Rows.Count; i++)
            {
                result[i + 1] = tableRoles.Rows[i][0].ToString();
            }

            return result;
        }

        public static string[] GetTitles()
        {
            string command = "SELECT `role`.`role` FROM `role`;";
            DataTable tableRoles = DBController.GetFromDB(command);

            if (tableRoles == null)
                return new string[0];

            string[] result = new string[tableRoles.Rows.Count];

            for (int i = 0; i < tableRoles.Rows.Count; i++)
            {
                result[i] = tableRoles.Rows[i][0].ToString();
            }

            return result;
        }

        public static int GetId(string title)
        {
            string command = $@"SELECT `role`.`id` 
FROM `role`
WHERE
`role`.`role` = '{title}';";
            DataTable tableRoles = DBController.GetFromDB(command);

            if (tableRoles == null)
                return -1;

            return Convert.ToInt32(tableRoles.Rows[0][0].ToString());
        }

        public static string GetTitle(int roleId)
        {
            string command = $@"
SELECT `role`.`role` 
FROM `role`
WHERE
`id` = '{roleId}';";

            DataTable tableRoles = DBController.GetFromDB(command);

            if (tableRoles == null)
                return null;

            return tableRoles.Rows[0][0].ToString();
        }
    }
}
