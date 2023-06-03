using System;
namespace SplashStats.API.Models.ScheduleDtos
{
	public interface ITeam
    {
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Id { get; set; }
        public string Sr_Id { get; set; }
        public string Reference { get; set; }

	}
}

