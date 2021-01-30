using GameStoreBackend.Entities;
using GameStoreBackend.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreBackend.Managers
{
    class SaleManager : ISaleManager
    {
        public void Return(Game game, Player player)
        {
            Console.WriteLine(player.Name+"returned "+game.Name);
        }

        public void Buy(Game game, Player player)
        {
            Console.WriteLine(player.Name+"bought "+game.Name+"with "+game.Price+"USD");
        }
    }
}
