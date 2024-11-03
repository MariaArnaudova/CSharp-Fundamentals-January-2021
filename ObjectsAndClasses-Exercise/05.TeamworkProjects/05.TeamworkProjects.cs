using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamCount = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamCount; i++)
            {
                string[] team = Console.ReadLine().Split('-');
                string creatorUser = team[0];
                string teamName = team[1];

                string setTeamName = String.Empty;
                string setCreator = String.Empty;
    
                if (teams.Any(x => x.TeamName == teamName))
                {
                    setTeamName = teamName;
                    setCreator = creatorUser;

                }
                else if (teams.Any(x => x.Creator==creatorUser))
                {
                    Console.WriteLine($"Team { teamName} was already created!");
                    continue;
                }
                else if (creatorUser == setCreator)
                {
                    Console.WriteLine($"{creatorUser} cannot create another team!");
                    continue;
                }

                Team currentTeam = new Team(creatorUser, teamName);
                teams.Add(currentTeam);
                Console.WriteLine($"Team {teamName} has been created by {creatorUser}!");
            }

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "end of assignment")
            {
                string[] teamInfo = input.Split("->");

                string joinUser = teamInfo[0];
                string joinTeam = teamInfo[1];

                if (!(teams.Any(x => x.TeamName == joinTeam)))
                {
                    Console.WriteLine($"Team {teams} does not exist!");
                    continue;
                }
                else if (teams.Any(x => x.usersJoined.Contains(joinUser)) || teams.Any(x => x.Creator ==joinUser && x.TeamName== joinTeam))
                {
                    Console.WriteLine($"Member {joinUser} cannot join team {joinTeam}!");
                    continue;
                }

                int index = teams.FindIndex(x => x.TeamName == joinTeam);
                teams[index].usersJoined.Add(joinUser);
            }

            List<Team> teamsToBeDisbanded = teams
                .FindAll( x => x.usersJoined.Count == 0)
                .OrderBy(x => x.TeamName)
                .ToList() ;

            List<Team> validTeams = teams
                .FindAll(x => x.usersJoined.Count > 0)
                .OrderBy(x => x.TeamName)
                .ToList();

            Console.WriteLine(String.Join(Environment.NewLine, validTeams));
            Console.WriteLine("Teams to disband: " + String.Join(Environment.NewLine, teamsToBeDisbanded));
        }
        class Team
        {
            public string TeamName { get; set; }
            public string Creator { get; set; }

            public List<string> usersJoined;

            public Team(string teamName, string creator)
            {
                this.Creator = creator;
                this.TeamName = teamName;
                usersJoined = new List<string>();
            }

            public override string ToString()
            {
                string text = "";

                text += TeamName + Environment.NewLine;
                text += '-' + Creator + Environment.NewLine;

                foreach (string member in usersJoined)
                {
                    text += "--" + member + Environment.NewLine;
                }
                return base.ToString();
            }
        }
    }
  
   
}
