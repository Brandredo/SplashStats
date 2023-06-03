using System;
namespace SplashStats.API.Models.ScheduleDtos
{
	public class Season
	{
		public string Id { get; set; }
		public int Year { get; set; }
		public string Type { get; set; }

		public Season()
		{
		}

        public Season(string id, int year, string type)
        {
            Id = id;
            Year = year;
            Type = type;
        }
    }
}

