using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTabell
{
    public class Points 
    {
        public int AwayTeamPoints;
        public int HomeTeamPoints;
        public Match aSingleMatch;
        
        public Points(Match match1)
        {
            aSingleMatch = match1;
        }
        int pointInMatch = 3;
        public  void Results()
        {
            
            if (aSingleMatch.GoalHome > aSingleMatch.GoalAway)
                {
                    HomeTeamPoints = pointInMatch;
                }
            if (aSingleMatch.GoalHome < aSingleMatch.GoalAway)
            {
                AwayTeamPoints = pointInMatch;
            }
            
            
        }
    }
}