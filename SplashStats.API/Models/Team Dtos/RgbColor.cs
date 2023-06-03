using System;
namespace SplashStats.API.Models.TeamDtos
{
	public class RgbColor
	{
		public string Red { get; set; }
		public string Green { get; set; }
		public string Blue { get; set; }

		public RgbColor()
		{
		}

        public RgbColor(string red, string green, string blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }
    }
}

