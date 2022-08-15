using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfTeams = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            for (int i = 0; i < numOfTeams; i++)
            {
                //input: {userName}-{teamName}
                string[] input = Console.ReadLine().Split('-').ToArray();
                bool isCreatorPresent = false;
                bool isTeamPresent = false;
                foreach (Team t in teams)
                {
                    if (t.Name == input[1])
                    {
                        System.Console.WriteLine($"Team {t.Name} was already created!");
                        isTeamPresent = true;
                        break;
                    }
                    if (t.Creator == input[0])
                    {
                        System.Console.WriteLine($"{t.Creator} cannot create another team!");
                        isCreatorPresent = true;
                        break;
                    }
                }
                if (!isTeamPresent && !isCreatorPresent)
                {
                    Team team = new Team(input[1], input[0]);
                    teams.Add(team);
                    System.Console.WriteLine($"Team {team.Name} has been created by {team.Creator}!");
                }
            }

            string line = Console.ReadLine();
            while (line != "end of assignment")
            {
                ////input: {userName}->{teamName}
                string[] assingments = line.Split("->");
                bool teamExists = false;
                bool userExists = false;

                foreach (Team t in teams)
                {
                    if (t.Name == assingments[1])
                    {
                        teamExists = true;
                        foreach (Team team in teams)
                        {
                            if (team.Creator == assingments[0] || team.Users.Any(u => u == assingments[0]))
                            {
                                Console.WriteLine($"Member {assingments[0]} cannot join team {assingments[1]}!");
                                userExists = true;
                                break;
                            }
                        }
                        if (userExists) break;
                        t.Users.Add(assingments[0]);
                        break;
                    }
                }
                if (!teamExists)
                {
                    System.Console.WriteLine($"Team {assingments[1]} does not exist!");
                }

                line = Console.ReadLine();
            }

            List<Team> toDisband = new List<Team>();
            foreach (Team team in teams)
            {
                if (team.Users.Count == 0)
                {
                    toDisband.Add(team);
                }
            }
            List<Team> orderedToDisband = toDisband.OrderBy(t => t.Name).ToList();
            orderedToDisband.ForEach(t => teams.Remove(t));


            List<Team> ordByName = teams.OrderBy(t => t.Name).ToList();
            List<Team> ordByUsersAndName = ordByName.OrderByDescending(t => t.Users.Count).ToList();
            ordByUsersAndName.ForEach(t => Console.WriteLine(t));

            Console.WriteLine("Teams to disband:");
            if (toDisband.Count != 0)
            {
                orderedToDisband.ForEach(t => Console.WriteLine(t.Name));
            }
        }

    }
    class Team
    {

        public Team(string name, string creator)
        {
            this.Name = name;
            this.Creator = creator;
            this.Users = new List<string>();
        }
        public string Name { get; }
        public string Creator { get; }
        public List<string> Users { get; set; }
        public override string ToString()
        {
            string users = null;
            List<string> orderedUsers = this.Users.OrderBy(u => u).ToList();
            for (int i = 0; i < orderedUsers.Count; i++)
            {
                if (i != orderedUsers.Count - 1)
                    users += $"-- {orderedUsers[i]}{Environment.NewLine}";
                else
                    users += $"-- {orderedUsers[i]}";
            }
            return $"{this.Name}{Environment.NewLine}- {this.Creator}{Environment.NewLine}{users}";
        }
    }
}
