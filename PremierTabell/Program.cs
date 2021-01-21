using System;
using System.Collections.Generic;

namespace PremierTabell
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> top5 = new List<Team>();

            top5.Add(new Team("liver", 19, 12, 2, 5, 35, 38));
            top5.Add(new Team("man u  ", 18, 11, 4, 3, 34, 37));
            top5.Add(new Team("city   ", 17, 10, 5, 2, 29, 35));
            top5.Add(new Team("arsnal ", 18, 9, 7, 2, 37, 34));
            top5.Add(new Team("chelsea", 18, 9, 6, 3, 33, 33));
            Console.WriteLine("Lagnavn\ts\tv\tu\tt\tmm\tp");
            foreach (var t in top5) 
            {
                t.show();
            }
        }
    }
}
