using System;
using System.Collections.Generic;
using System.Data;
using WorldSkills_WinApp.DBEntities;

namespace WorldSkills_WinApp.DBWorkers
{
    public static class CompetitionsController
    {
        public static List<Competition> Get()
        {
            string command = $@"
SELECT *
FROM `competition` 
WHERE 
DATEDIFF('{DateTime.Now.ToString("yyyy-MM-dd")}', `competition`.`date_start`) <= {Competition.INTERVAL};";

            DataTable tableCompetition = DBController.GetFromDB(command);
            if (tableCompetition == null)
                return null;

            List<Competition> result = new List<Competition>();

            for (int i = 0; i < tableCompetition.Rows.Count; i++)
            {
                result.Add(new Competition(tableCompetition.Rows[i]));
            }

            return result;
        }

        // TODO подумать о том, нужно ли оно на самом деле в дальнейшей перспективе.
        public static Competition Get(int id)
        {
            string command = $@"
SELECT *
FROM `competition` 
WHERE 
`competition`.`id` = '{id}';";

            DataTable tableCompetition = DBController.GetFromDB(command);
            if (tableCompetition == null)
                return null;
            return new Competition(tableCompetition.Rows[0]);
        }

        public static List<Tuple<int, string>> GetIDName()
        {
            string command = $@"
SELECT 
competition.id,
competition.title
FROM `competition` 
WHERE 
DATEDIFF('{DateTime.Now.ToString("yyyy-MM-dd")}', `competition`.`date_start`) <= {Competition.INTERVAL};";

            DataTable tableCompetition = DBController.GetFromDB(command);
            if (tableCompetition == null)
                return null;
            List<Tuple<int, string>> result = new List<Tuple<int, string>>();

            for (int i = 0; i < tableCompetition.Rows.Count; i++)
            {
                result.Add(new Tuple<int, string>((int)tableCompetition.Rows[i][0], (string)tableCompetition.Rows[i][1]));
            }

            return result;
        }


    }
}
