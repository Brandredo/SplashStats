using System;
namespace SplashStats.API.Models.TeamDtos
{
	public class Division
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Alias { get; set; }

		public Division()
		{
		}

        public Division(string id, string name, string alias)
        {
            Id = id;
            Name = name;
            Alias = alias;
        }
    }
}

