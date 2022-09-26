using System.Data;

namespace WorldSkills_WinApp.DBWorkers
{
    public static class RolesController
    {
        public static string[] Get()
        {
            string command = "SELECT * FROM `role`;";
            DataTable tableRoles = DBController.GetFromDB(command);

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
    }
}
