using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSkills_WinApp.DBEntities
{
    public class Skill
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public int SkillBlockId { get; private set; }
        public bool IsFuture { get; private set; }
        public string Description { get; private set; }
        public int SquareWorkspace { get; private set; }
        public int SquareExperts { get; private set; }
        public int SquareStorage { get; private set; }
        public int SquareBriefing { get; private set; }
        public int SquareUnknown { get; private set; }
        public int CountOfTeamMemebers { get; private set; }

        public Skill(DataRow rowSkill)
        {
            Id = (int)rowSkill[0];
            Title = (string)rowSkill[1];
            SkillBlockId = (int)rowSkill[2];
            IsFuture = (bool)rowSkill[3];
            Description = (string)rowSkill[4];
            SquareWorkspace = (int)rowSkill[5];
            SquareExperts = (int)rowSkill[6];
            SquareStorage = (int)rowSkill[7];
            SquareBriefing = (int)rowSkill[8];
            SquareUnknown = (int)rowSkill[9];
            CountOfTeamMemebers = (int)rowSkill[10];
        }

        public bool IsNull() => Title == null;
    }
}
