using System;
using System.Collections.Generic;
using System.Text;

namespace Piantoni_Isabella_991392679_Assignment_1
{
    class Player
    {
        //variables
        protected int PlayerId { get; set; }
        protected string PlayerName { get; set; }
        protected string SportName { get; set; }

        //setters
        //public void setPlayerId(int id)
        //{
          //  PlayerId = id;
        //}
        //public void setPlayerName(string name)
        //{
        //    PlayerName = name;
        //}

        //public void setSportName(string sport)
        //{
         //   SportName = sport;
        //}

        //constructor
        public Player(int playerID, string playerName, string sportName)
        {
            PlayerId = playerID;
            PlayerName = playerName;
            SportName = sportName;
        }

        public Player()
        {
        }

        //Printing method
        public virtual void print()
        {
            Console.WriteLine("Player ID: " + PlayerId + " | Player Name: " + PlayerName + " | Sport: " + SportName);
        }
    }
}

