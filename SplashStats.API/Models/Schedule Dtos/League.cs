using System;
namespace SplashStats.API.Models.Schedule
{
	public class League
	{
        public string Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }

        public League()
		{
		}

        public League(string id, string name, string alias)
        {
            Id = id;
            Name = name;
            Alias = alias;
        }
    }
}

