using System;
namespace SplashStats.API.Models.Schedule
{
	public class Venue
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public int Capacity { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
		public string Country { get; set; }
		public string Sr_Id { get; set; }
		public Location Location { get; set; }

		public Venue()
		{
		}

        public Venue(string id, string name, int capacity, string address, string city, string state, string zip, string country, string sr_Id, Location location)
        {
            Id = id;
            Name = name;
            Capacity = capacity;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            Country = country;
            Sr_Id = sr_Id;
            Location = location;
        }
    }
}

