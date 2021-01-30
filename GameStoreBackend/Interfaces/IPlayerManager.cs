using GameStoreBackend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreBackend.Interfaces
{
    interface IPlayerManager
    {
        void Add(Player player);
        void Delete(Player player);
        void Update(Player player);
    }
}
