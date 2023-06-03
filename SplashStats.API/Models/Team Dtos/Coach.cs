using System;
namespace SplashStats.API.Models.TeamDtos
{
	public class Coach
	{
		public string Id { get; set; }
		public string Full_Name { get; set; }
		public string First_Name { get; set; }
		public string Last_Name { get; set; }
		public string Position { get; set; }
		public string Experience { get; set; }
		public string Reference { get; set; }

		public Coach()
		{
		}

        public Coach(string id, string full_Name, string first_Name, string last_Name, string position, string experience, string reference)
        {
            Id = id;
            Full_Name = full_Name;
            First_Name = first_Name;
            Last_Name = last_Name;
            Position = position;
            Experience = experience;
            Reference = reference;
        }
    }
}

