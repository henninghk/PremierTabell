using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTabell
{
    class Team
    {
        public string _name;
        public int _gameplayed;
        public int _gamewon;
        public int _gamedraw;
        public int _gamelost;
        public int _goaldiff;
        public int _points;



        public Team(string name, int gameplayed, int gamewon, int gamedraw, int gamelost, int goaldiff, int points)
        {
         _name = name;
         _gameplayed = gameplayed;
         _gamewon = gamewon;
         _gamedraw = gamedraw;
         _gamelost = gamelost;
         _goaldiff = goaldiff;
         _points = points;
    
        }
        public void show() 
        {
            Console.WriteLine(_name+"\t"+_gameplayed+"\t"+_gamewon+"\t"+_gamedraw + "\t" + _gamelost + "\t" + _goaldiff + "\t" + _points);
        }
    }
}