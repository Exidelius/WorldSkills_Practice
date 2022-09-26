using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSkills_WinApp.DBWorkers
{
    public static class CompetitionSkillController
    {
        public static string[] Get(int competitionId)
        {
            string command = $@"
SELECT 
`skill`.`title`
FROM `competition_skill`
JOIN `skill` ON `skill`.`id` = `competition_skill`.`skill_id`
WHERE 
competition_id = '{competitionId}';";

            DataTable tableCompetitionSkills = DBController.GetFromDB(command);

            if (tableCompetitionSkills == null)
                return null;

            string[] result = new string[tableCompetitionSkills.Rows.Count];
            for (int i = 0; i < tableCompetitionSkills.Rows.Count; i++)
            {
                result[i] = tableCompetitionSkills.Rows[i][0].ToString();
            }

            return result;
        }
    }
}
