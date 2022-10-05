using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSkills_ClientApp.DBWorkers
{
    public static class CompetitionsController
    {
        public static string Get(int id)
        {
            string command = $@"
SELECT `title`
FROM `competition` 
WHERE 
`competition`.`id` = '{id}';";

            DataTable tableCompetition = DBController.GetFromDB(command);
            if (tableCompetition == null)
                return null;

            return tableCompetition.Rows[0][0].ToString();
        }
    }
}
