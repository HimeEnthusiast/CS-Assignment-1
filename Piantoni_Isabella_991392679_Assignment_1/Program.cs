using System;
using System.Collections;
using System.Collections.Generic;

namespace Piantoni_Isabella_991392679_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //create an arraylist for players
            List<Player> playerList = new List <Player>();


            //Loop to contain whole program
            while (true)
            {
                //How many times the loop has occured
                int n = 0;

                //Ask user what they want to do
                Console.WriteLine("Press 1 to create a player. Press 2 to view players.");
                char choice = Console.ReadKey().KeyChar;

                //Check user input
                if (choice == '1')
                {
                    //start to create player
                    Console.WriteLine("Let's create a player!\n");

                    //get input
                    Console.WriteLine("Enter player ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n");

                    Console.WriteLine("Enter player rank: ");
                    int rank = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n");

                    Console.WriteLine("Enter total points: ");
                    int points = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n");

                    Console.WriteLine("Enter player name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("\n");

                    Console.WriteLine("Enter sport name: ");
                    string sport = Console.ReadLine();
                    Console.WriteLine("\n");

                    //Create player with gathered inputs, add to the list and repeat the process.
                    Ranks r = new Ranks(id, name, sport, rank, points);
                    playerList.Add(r);
                    n++;

                } else if (choice == '2') 
                    {
                    //check if list has data


                    //display player
                    playerList[n].print();

                    }
            }
        }
    }
}
