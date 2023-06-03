using System;
namespace SplashStats.API.Models.TeamDtos
{
	public class Conference
	{

		public string Id { get; set; }
		public string Name { get; set; }
		public string Alias { get; set; }

		public Conference()
		{
		}

        public Conference(string id, string name, string alias)
        {
            Id = id;
            Name = name;
            Alias = alias;
        }
    }
}

