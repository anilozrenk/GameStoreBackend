using System;
using System.Collections.Generic;
using System.Text;
using GameStoreBackend.Entities;
using GameStoreBackend.Interfaces;


namespace GameStoreBackend.Managers
{
    class PlayerManager:IPlayerManager
    {
        private IPlayerCheckService _playerCheckService;

        

        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }
        public void Add(Player player)
        {
            if (_playerCheckService.CheckIsPlayerReal(player))
            {
                Console.WriteLine("Player added: "+player.Name);
            }
            else
            {
                throw new Exception("Not a valid player");
            }
            
        }

        public void Delete(Player player)
        {
            throw new NotImplementedException();
        }

        public void Update(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
