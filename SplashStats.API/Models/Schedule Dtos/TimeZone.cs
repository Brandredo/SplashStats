using System;
namespace SplashStats.API.Models.ScheduleDtos
{
	public class TimeZone
	{
        public string Venue { get; set; }
        public string Home { get; set; }
        public string Away { get; set; }

        public TimeZone()
		{
		}

        public TimeZone(string venue, string home, string away)
        {
            Venue = venue;
            Home = home;
            Away = away;
        }
    }
}

