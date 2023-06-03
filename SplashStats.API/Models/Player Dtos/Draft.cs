using System;
namespace SplashStats.API.Models.PlayerDtos
{
	public class Draft
	{

		public string? Team_Id { get; set; }
		public int Year { get; set; }
		public string? Round { get; set; }
		public string? Pick { get; set; }


		public Draft()
		{
		}

        public Draft(string team_Id, int year, string round, string pick)
        {
            Team_Id = team_Id;
            Year = year;
            Round = round;
            Pick = pick;
        }
    }
}

