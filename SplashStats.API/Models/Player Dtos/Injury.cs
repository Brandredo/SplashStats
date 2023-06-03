using System;
namespace SplashStats.API.Models.PlayerDtos
{
	public class Injury
	{
		public string Id { get; set; }
		public string Comment { get; set; }
		public string Desc { get; set; }
		public string Status { get; set; }
		public string Start_Date { get; set; }
		public string Update_Date { get; set; }

		public Injury()
		{
		}

        public Injury(string id, string comment, string desc, string status, string start_Date, string update_Date)
        {
            Id = id;
            Comment = comment;
            Desc = desc;
            Status = status;
            Start_Date = start_Date;
            Update_Date = update_Date;
        }
    }
}