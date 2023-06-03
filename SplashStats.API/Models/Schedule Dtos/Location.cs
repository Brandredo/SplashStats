using System;
namespace SplashStats.API.Models.Schedule
{
	public class Location
	{

		public string Lat { get; set; }
		public string Lng { get; set; }

		public Location()
		{
		}

        public Location(string lat, string lng)
        {
            Lat = lat;
            Lng = lng;
        }
    }
}

