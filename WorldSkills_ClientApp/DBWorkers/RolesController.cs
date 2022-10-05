using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSkills_ClientApp.DBWorkers
{
    internal class RolesController
    {
        public static string Get(int roleId)
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
