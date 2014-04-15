using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class PlayerRepository
    {
        private List<Player> players;

        public PlayerRepository()
        {
            players= new List<Player>();

            var player = new Player()
            {
                Number=7,
                Name="Ronaldo",
                NumberOfAssists=5,
                NumberOfGamesPlayed=10,
                NumberOfGoalsScored=8,
                Position="Striker"
            };

            var player2 = new Player()
            {
                Number = 9,
                Name = "Benzema",
                NumberOfAssists = 3,
                NumberOfGamesPlayed = 7,
                NumberOfGoalsScored = 6,
                Position = "Striker"
            };

            players.Add(player);
            players.Add(player2);
        }

        public List<Player> GetAll()
        {
            return players;
        }

        public Player GetByNumber(int playerNumber)
        {
            return players.SingleOrDefault(p => p.Number == playerNumber);
        }

        public void Save(Player player)
        {
            players.Add(player);
        }

        public void Delete(int playerNumber)
        {
            players.Remove(players.SingleOrDefault(p => p.Number == playerNumber));
        }

        public void Update(Player player)
        {
            Player playerFound = players.SingleOrDefault(p=>p.Number==player.Number);
            playerFound.NumberOfAssists += player.NumberOfAssists;
            playerFound.NumberOfGoalsScored = player.NumberOfGoalsScored;
            playerFound.NumberOfGamesPlayed += 1;
        }

    }
}
