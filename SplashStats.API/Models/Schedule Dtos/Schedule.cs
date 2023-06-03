using System;
namespace SplashStats.API.Models.ScheduleDtos
{
	public class Schedule
	{
		public League League { get; set; }
		public Season Season { get; set; }
		public List<Game> Games { get; set; }

		public Schedule()
		{
		}

        public Schedule(League league, Season season, List<Game> games)
        {
            League = league;
            Season = season;
            Games = games;
        }
    }
}

