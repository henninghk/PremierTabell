using System;
using System.Collections.Generic;

namespace PremierTabell
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> top5 = new List<Team>();

            top5.Add(new Team("|live", 0, 0, 0, 0, 0, 0));
            top5.Add(new Team("|manu", 0, 0, 0, 0, 0, 0));
            top5.Add(new Team("|city", 0, 0, 0, 0, 0, 0));
            top5.Add(new Team("|arsn", 0, 0, 0, 0, 0, 0));
            top5.Add(new Team("|chel", 0, 0, 0, 0, 0, 0));
            Console.WriteLine("|Lagnavn|s\t|v\t|u\t|t\t|mm\t|p");
            foreach (var t in top5)
            {
                t.show();
            }
           
        }
    }
}
