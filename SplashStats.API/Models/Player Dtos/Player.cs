using System;
namespace SplashStats.API.Models.PlayerDtos
{
	public class Player
	{
        public string Id { get; set; }
        public string Status { get; set; }
        public string Full_Name { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Abbr_Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string Position { get; set; }
        public string Primary_Position { get; set; }
        public string Jersey_Number { get; set; }
        public string Experience { get; set; }
        public string College { get; set; }
        public string High_School { get; set; }
        public string Birth_Place { get; set; }
        public string Birthdate { get; set; }
        public string Updated { get; set; }
        public string Sr_Id { get; set; }
        public string Rookie_Year { get; set; }
        public string Reference { get; set; }
        public Draft? Draft { get; set; }
        public List<Injury>? Injuries { get; set; }

        public Player()
		{
		}

        public Player(string id, string status, string full_Name, string first_Name, string last_Name, string abbr_Name, int height, int weight, string position, string primary_Position, string jersey_Number, string experience, string college, string high_School, string birth_Place, string birthdate, string updated, string sr_Id, string rookie_Year, string reference, Draft draft, List<Injury> injuries)
        {
            Id = id;
            Status = status;
            Full_Name = full_Name;
            First_Name = first_Name;
            Last_Name = last_Name;
            Abbr_Name = abbr_Name;
            Height = height;
            Weight = weight;
            Position = position;
            Primary_Position = primary_Position;
            Jersey_Number = jersey_Number;
            Experience = experience;
            College = college;
            High_School = high_School;
            Birth_Place = birth_Place;
            Birthdate = birthdate;
            Updated = updated;
            Sr_Id = sr_Id;
            Rookie_Year = rookie_Year;
            Reference = reference;
            Draft = draft;
            Injuries = injuries;
        }
    }
}
