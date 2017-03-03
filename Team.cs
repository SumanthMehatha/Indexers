using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class Team
    {
        public string TeamName { get; set; }
        private string[] players = new string[11];
        private string[] subPlayers = new string[5];

        // Indexer  is a special property for arrays

        public string this[int index]
        {
            get
            {
                return players[index];
            }
            set
            {
                players[index] = value;
            }
        }
        // Two Indexers cannot be used because indexer must have same this keyword.
        // However one can overload indexer (This is serious depth WWDL(We will deal later))
        //public string this[int index]
        //{
        //    get
        //    {
        //        return subPlayers[index];
        //    }
        //    set
        //    {
        //        subPlayers[index] = value;
        //    }
        //}
    }

    class TeamDemo
    {
        public static void Main()
        {
            Team t = new Team { TeamName = "India" };
            Console.WriteLine(t.TeamName);

            t[0] = "Captain Virat Kohli";
            t[1] = "Ex Captain Dhoni";
            t[2] = "Good for Nothing Dhawan";

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(t[i]);
            }
        }
    }
}
