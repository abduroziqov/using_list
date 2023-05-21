using System;
using System.Collections.Generic;

namespace using_from_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            players.Add(new Player("Anvar"));
            players.Add(new Player("MuhammadAli"));
            players.Add(new Player("Quvonchbek"));

            foreach (Player player in players)
            {
                Console.WriteLine(player);
            }
        }

        class Player
        {
            public string username;

            public Player(string username)
            {
                this.username = username;
            }
            public override string ToString()
            {
                return username;
            }
        }
    }
}