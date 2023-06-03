using System;
using SplashStats.API.Models.PlayerDtos;
using SplashStats.API.Models.ScheduleDtos;

namespace SplashStats.API.Models.TeamDtos
{
	public class Team
	{

        public string Id { get; set; }
        public string Name { get; set; }
        public string Market { get; set; }
        public string Alias { get; set; }
        public int Founded { get; set; }
        public string Sr_Id { get; set; }
        public string Reference { get; set; }
        public Venue Venue { get; set; }
        public League League { get; set; }
        public Conference Conference { get; set; }
        public List<Coach> Coaches { get; set; }
        public List<TeamColor> Team_Colors { get; set; }
        public List<Player> Players { get; set; }

        public Team()
		{
		}

        public Team(string id, string name, string market, string alias, int founded, string sr_Id, string reference, Venue venue, League league, Conference conference, List<Coach> coaches, List<TeamColor> team_Colors, List<Player> players)
        {
            Id = id;
            Name = name;
            Market = market;
            Alias = alias;
            Founded = founded;
            Sr_Id = sr_Id;
            Reference = reference;
            Venue = venue;
            League = league;
            Conference = conference;
            Coaches = coaches;
            Team_Colors = team_Colors;
            Players = players;
        }
    }
}