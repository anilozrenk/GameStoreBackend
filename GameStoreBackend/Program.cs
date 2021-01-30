using GameStoreBackend.Entities;
using System;
using System.Collections.Generic;
using GameStoreBackend.Interfaces;
using GameStoreBackend.Managers;
using GameStoreBackend.Service;

namespace GameStoreBackend
{
    class Program
    {

        static void Main(string[] args)
        {
            Player player1 = new Player() { NationaityId = "0000000000", Name = "ANIL", Surname = "ÖZRENK",DateOfBirth=new DateTime(1999,6,22)};
            
            Game game1 = new Game() {Name="ECorps",Genre="Cyberpunk Vr Action" ,BasePrice=50 };

            Campaing campaing1 = new Campaing() { Name = "Patron Cildirdi", SaleAmount = 0.75 };

            PlayerManager playerManager = new PlayerManager(new PlayerCheckService());

            playerManager.Add(player1);

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            CampaingManager campaingManager = new CampaingManager();
            campaingManager.Apply(campaing1, game1);
            SaleManager saleManager = new SaleManager();
            saleManager.Buy(game1,player1);







        }
    }
}
