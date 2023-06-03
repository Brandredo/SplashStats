using System;
namespace SplashStats.API.Models.Schedule
{
	public class Away
	{
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Id { get; set; }
        public string Sr_Id { get; set; }
        public string Reference { get; set; }

        public Away()
		{
		}

        public Away(string name, string alias, string id, string sr_Id, string reference)
        {
            Name = name;
            Alias = alias;
            Id = id;
            Sr_Id = sr_Id;
            Reference = reference;
        }
    }
}

