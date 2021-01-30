using GameStoreBackend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreBackend.Interfaces
{
    interface IGameManager
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
    }
}
