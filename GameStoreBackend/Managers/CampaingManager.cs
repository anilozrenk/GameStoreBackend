using System;
using System.Collections.Generic;
using System.Text;
using GameStoreBackend.Entities;
using GameStoreBackend.Interfaces;


namespace GameStoreBackend.Managers
{
    class CampaingManager : ICampaingManager
    {
        

        public void Apply(Campaing campaing, Game game)
        {
            Console.WriteLine(campaing.Name+" added to "+"game");
            game.Price = game.BasePrice - game.BasePrice * campaing.SaleAmount;
            Console.WriteLine("new price is:"+game.Price+"USD");
        }

        public void Cancel(Campaing campaing, Game game)
        {
            Console.WriteLine(campaing + " cancelled on " + "game");
            game.Price = game.BasePrice;
        }

        
    }
}
