using System;
namespace SplashStats.API.Models.ScheduleDtos
{
	public class Broadcast
	{
		public string Network { get; set; }
		public string Type { get; set; }
		public string Locale { get; set; }
		public string Channel { get; set; }

		public Broadcast()
		{
		}

        public Broadcast(string network, string type, string locale, string channel)
        {
            Network = network;
            Type = type;
            Locale = locale;
            Channel = channel;
        }
    }
}
