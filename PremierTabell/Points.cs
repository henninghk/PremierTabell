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

        public string Results()
        {
            
            if (aSingleMatch.GoalHome > aSingleMatch.GoalAway)
                {
               var home = HomeTeamPoints = pointInMatch;
                home.ToString();
                Console.WriteLine("hjemmelaget " + home);
                    
                }
            if (aSingleMatch.GoalHome < aSingleMatch.GoalAway)
            {
                var away =AwayTeamPoints = pointInMatch;
                away.ToString();
                Console.WriteLine("bortelaget " + away);
            }
            
           return null;
            
        }
    }
}