using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSkills_WinApp.DBEntities
{
    public class Competition
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public DateTime DateOfStart { get; private set; }
        public DateTime DateOfEnd { get; private set; }
        public string Description { get; private set; }
        public string City { get; private set; }

        public static readonly int INTERVAL = 3000;

        //public Competition(int id, string title, DateTime dateOfStart, DateTime dateOfEnd, string description, string city)
        //{
        //    Id = id;
        //    Title = title;
        //    DateOfStart = dateOfStart;
        //    DateOfEnd = dateOfEnd;
        //    Description = description;
        //    City = city;
        //}

        public Competition(DataRow rowCompetition)
        {
            Id = (int)rowCompetition[0];
            Title = (string)rowCompetition[1];
            DateOfStart = (DateTime)rowCompetition[2];
            DateOfEnd = (DateTime)rowCompetition[3];
            Description = (string)rowCompetition[4];
            City = (string)rowCompetition[5];
        }

        public string[] GetAsStringArray()
        {
            string[] result = {
                Id.ToString(),
                Title,
                DateOfStart.ToString("dd.MM.yyyy"),
                DateOfEnd.ToString("dd.MM.yyyy"),
                Description,
                City
            };

            return result;
        }

        public bool IsNull() => Title == null;
    }
}
