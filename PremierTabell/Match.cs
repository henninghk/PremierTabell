using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTabell
{
    public class Match
    {
        public Team TeamHome;
        public Team TeamAway;
        public int GoalHome;
        public int GoalAway;
        public Match(Team teamHome, Team teamAway, int goalHome, int goalAway)
        {
            TeamHome = teamHome;
            TeamAway = teamAway;
            GoalHome = goalHome;
            GoalAway = goalAway;
        }

       
    }
}
