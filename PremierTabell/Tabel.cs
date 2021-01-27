using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTabell
{
   public class Tabel
    
        
        {
        public string _name;
        public string _gameplayed;
        public string _goalscored;


        public Tabel(string name, string gameplayed, string goalscored)
        {
            _name = name;
            _gameplayed = gameplayed;
            _goalscored = goalscored;
        }

        public void Add(Match match, bool teamHome)
        {
            _gameplayed++;
            _goalscored += teamHome ? match.GoalAway : match.GoalAway;
            
        }
    }      
}
