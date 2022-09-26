using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using WorldSkills_WinApp.DBEntities;

namespace WorldSkills_WinApp.DBWorkers
{
    public static class SkillsController
    {
        public static List<Skill> Get()
        {
            string command = "SELECT * FROM `skill`;";

            DataTable tableSkills = DBController.GetFromDB(command);
            if (tableSkills == null)
                return null;

            List<Skill> result = new List<Skill>();

            for (int i = 0; i < tableSkills.Rows.Count; i++)
            {
                result.Add(new Skill(tableSkills.Rows[i]));
            }

            return result;
        }

        public static Skill Get(string title)
        {
            string command = $@"
SELECT * 
FROM `skill`
WHERE 
title = '{title}';";

            DataTable tableSkills = DBController.GetFromDB(command);
            if (tableSkills == null)
                return null;

            Skill result = new Skill(tableSkills.Rows[0]);

            return result;
        }

        public static string[] GetTitles()
        {
            string command = $@"SELECT title FROM `skill`;";

            DataTable tableSkills = DBController.GetFromDB(command);

            if (tableSkills == null)
                return null;

            string[] result = new string[tableSkills.Rows.Count];
            for (int i = 0; i < tableSkills.Rows.Count; i++)
            {
                result[i] = tableSkills.Rows[i][0].ToString();
            }

            return result;
        }
    }
}
