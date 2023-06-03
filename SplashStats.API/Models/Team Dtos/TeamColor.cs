using System;
namespace SplashStats.API.Models.TeamDtos
{
	public class TeamColor
	{
		public string Type { get; set; }
		public string Hex_Color { get; set; }
		public RgbColor Rgb_Color { get; set; }

		public TeamColor()
		{
		}
	}
}

