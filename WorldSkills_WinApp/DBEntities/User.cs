using System;
using System.Data;

namespace WorldSkills_WinApp.DBEntities
{
    public class User
    {
        private int Id { get; set; }
        private string FIO { get; set; }
        private string Gender { get; set; }
        private DateTime DateBirthday { get; set; }
        private int Role { get; set; }
        private int Skill { get; set; }
        private int Region { get; set;}
        private int Place { get; set;}
        private int Competition { get; set;}

        //public User(int id, string fIO, string gender, DateTime dateBirthday, int role, int skill, int region, int place, int competition)
        //{
        //    Id = id;
        //    FIO = fIO;
        //    Gender = gender;
        //    DateBirthday = dateBirthday;
        //    Role = role;
        //    Skill = skill;
        //    Region = region;
        //    Place = place;
        //    Competition = competition;
        //}

        public User(DataRow rowUser)
        {
            Id = (int)rowUser[0];
            FIO = (string)rowUser[1];
            Gender = (string)rowUser[2];
            DateBirthday = (DateTime)rowUser[3];
            Role = (int)rowUser[4];
            Skill = (int)rowUser[5];
            Region = (int)rowUser[6];
            Place = (int)rowUser[7];
            Competition = (int)rowUser[8];
        }
        public bool IsNull() => GetFIO() == null;

        public string GetFIO() => FIO;

    }
}
