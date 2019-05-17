using System;
using System.Collections.Generic;
using System.Text;

namespace Piantoni_Isabella_991392679_Assignment_1
{
    class Ranks: Player
    {
        //variables
        private int Rank;
        private int TotalPoints;

        public Player p = new Player();

        public void setRank(int rank)
        {
            Rank = rank;
        }

        public void setTotalPoints(int points)
        {
            TotalPoints = points;
        }

        //construtor

        public Ranks(int PlayerID, string PlayerName, string SportName, int rank, int totalPoints) : base(PlayerID, PlayerName, SportName)
        {
            Rank = rank;
            TotalPoints = totalPoints;
        }

        //Printing method
        /*
        public void PrintPlayerInfo()
        {
            Console.WriteLine("Player ID: " + PlayerId + " | Player Name: " + PlayerName + " | Sport: " + SportName + " | Rank: " + Rank + " | Points: " + TotalPoints);
        }
        **/
        public override void print()
        {
            base.print();
            Console.WriteLine($" | Rank: " + Rank + $" | Points: " + TotalPoints);
        }
    }
}
