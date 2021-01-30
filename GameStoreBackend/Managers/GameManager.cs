using System;
using System.Collections.Generic;
using System.Text;
using GameStoreBackend.Entities;
using GameStoreBackend.Interfaces;


namespace GameStoreBackend.Managers
{
    class GameManager:IGameManager
    {
        public void Add(Game game)
        {
            Console.WriteLine("Game added: " + game.Name+"    "+game.BasePrice+"USD");
        }

        public void Delete(Game game)
        {
            throw new NotImplementedException();
        }

        public void Update(Game game)
        {
            
        }
    }
}
