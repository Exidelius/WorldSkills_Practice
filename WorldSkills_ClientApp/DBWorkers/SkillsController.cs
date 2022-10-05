using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSkills_ClientApp.DBWorkers
{
    public static class SkillsController
    {
        public static string Get(int skillId)
        {
            string command = $@"
SELECT `title` 
FROM `skill`
WHERE
`id` = '{skillId}';";

            DataTable tableSkills = DBController.GetFromDB(command);

            if (tableSkills == null)
                return null;

            return tableSkills.Rows[0][0].ToString();
        }
    }
}
