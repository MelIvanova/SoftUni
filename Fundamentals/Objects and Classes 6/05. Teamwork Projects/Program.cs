using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _05._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamNumb = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamNumb; i++)


            {
                string[] income = Console.ReadLine().Split("-");
                string creator = income[0];
                string teamName = income[1];
                Team team = new Team(teamName, creator);

                bool isTeemCreate = teams.Select(x => x.TeamName).Contains(teamName);
                bool isCreartorExist = teams.Select(x => x.TeamCreartor).Contains(creator);
                
                if (isTeemCreate)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                if (isCreartorExist)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                if (!isTeemCreate && !isCreartorExist)
                {
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }



            }

            string newCommers = Console.ReadLine();

            while (newCommers != "end of assignment")
            {
                string[] commands = newCommers.Split("->");
                string member = commands[0];
                string teamName = commands[1];
                bool isTheTeamExist = teams.Select(x => x.TeamName).Contains(teamName);

                bool isAlreadyInTheTeamLeader = teams.Select(x => x.TeamCreartor).Contains(member);
                bool isAlreadyMember = teams.Select(x => x.Members).Any(y => y.Contains(member));

                if (isTheTeamExist)
                {
                    if (isAlreadyInTheTeamLeader || isAlreadyMember)
                    {
                        Console.WriteLine($"Member {member} cannot join team {teamName}!");
                    }
                    else
                    {
                        int index = teams.FindIndex(x => x.TeamName == teamName);
                        teams[index].Members.Add(member);
                    }
                    
                }
                else
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
               
                newCommers = Console.ReadLine();
            }

            Team[] disbanned = teams
                .OrderBy(x => x.TeamName)
                .Where(y => y.Members.Count == 0)
                .ToArray();
           
            Team[] fullTeams = teams
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(y => y.TeamName)
                .Where(y => y.Members.Count > 0)
                .ToArray();

            StringBuilder print = new StringBuilder(); 

            foreach (Team team in fullTeams)
            {
                print.AppendLine($"{team.TeamName}");
                print.AppendLine($"- {team.TeamCreartor}");

                foreach (var member in team.Members.OrderBy(x=>x))
                {
                    print.AppendLine($"-- {member}");
                }
            }

            print.AppendLine("Teams to disband:");

            foreach (Team team in disbanned)
            {
                print.AppendLine(team.TeamName);
            }

            Console.WriteLine(print.ToString());
        }
    }

    class Team
    {
        public Team(string teamName, string tramCreartor)
        {
            TeamName = teamName;
            TeamCreartor = tramCreartor;
            Members = new List<string>();
        }

        public string TeamName { get; set; }
        public string TeamCreartor { get; set; }
        public List<string> Members { get; set; }
    }
}
