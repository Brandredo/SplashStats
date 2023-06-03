using System;
namespace SplashStats.API.Models.Schedule
{
	public class Game
	{
        public string Id { get; set; }
		public string Status { get; set; }
		public string Coverage { get; set; }
		public string Schedule { get; set; }
		public int Home_Points { get; set; }
		public int Away_Points { get; set; }
		public bool Track_On_Court { get; set; }
		public string Sr_Id { get; set; }
		public string Reference { get; set; }
		public TimeZone Time_Zones { get; set; }
		public Venue Venue { get; set; }
		public List<Broadcast> Broadcasts { get; set; }



		public Game()
		{
		}
	}
}


//{
//    "id": "9f01b268-29c5-4f0e-bf67-21e3dbcf3005",
//    "status": "closed",
//    "coverage": "full",
//    "scheduled": "2022-10-18T23:30:00Z",
//    "home_points": 126,
//    "away_points": 117,
//    "track_on_court": true,
//    "sr_id": "sr:match:35431579",
//    "reference": "0022200001",
//    "time_zones": {
//    "venue": "US/Eastern",
//    "home": "US/Eastern",
//    "away": "US/Eastern"
//      },
//      "venue": {
//        "id": "7d69b080-91ca-53c9-9302-45c1a72c5549",
//        "name": "TD Garden",
//        "capacity": 18624,
//        "address": "100 Legends Way",
//        "city": "Boston",
//        "state": "MA",
//        "zip": "02114",
//        "country": "USA",
//        "sr_id": "sr:venue:5940",
//        "location": { "lat": "42.366303", "lng": "-71.062228" }
//    },
//      "broadcasts": [
//        {
//        "network": "TNT",
//          "type": "TV",
//          "locale": "National",
//          "channel": "245"
//        }
//      ],
//      "home": {
//        "name": "Boston Celtics",
//        "alias": "BOS",
//        "id": "583eccfa-fb46-11e1-82cb-f4ce4684ea4c",
//        "sr_id": "sr:team:3422",
//        "reference": "1610612738"
//      },
//      "away": {
//        "name": "Philadelphia 76ers",
//        "alias": "PHI",
//        "id": "583ec87d-fb46-11e1-82cb-f4ce4684ea4c",
//        "sr_id": "sr:team:3420",
//        "reference": "1610612755"
//      }
//}