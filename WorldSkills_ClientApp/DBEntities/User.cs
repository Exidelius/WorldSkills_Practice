using System;
using System.Data;

namespace WorldSkills_ClientApp.DBEntities
{
    public class User
    {
        public int Id { get; private set; }
        public string FIO { get; private set; }
        public string Gender { get; private set; }
        public DateTime DateBirthday { get; private set; }
        public int Role { get; private set; }
        public int Skill { get; private set; }
        public int Region { get; private set; }
        public int Place { get; private set; }
        public int Competition { get; private set; }
        public bool IsActive { get; private set; }


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
            DateBirthday = DateTime.ParseExact(rowUser[3].ToString(), "dd.MM.yyyy s:mm:HH", null);

            Role = 0;
            if (int.TryParse(rowUser[4].ToString(), out int role))
                Role = role;

            Skill = 0;
            if (int.TryParse(rowUser[5].ToString(), out int skill))
                Skill = skill;

            Region = 0;
            if (int.TryParse(rowUser[6].ToString(), out int region))
                Region = region;

            Place = 0;
            if (int.TryParse(rowUser[7].ToString(), out int place))
                Place = place;

            Competition = 0;
            if (int.TryParse(rowUser[8].ToString(), out int competition))
                Competition = competition;

            IsActive = Convert.ToBoolean(rowUser[9]);
        }
        public bool IsNull() => FIO == null;

    }
}
