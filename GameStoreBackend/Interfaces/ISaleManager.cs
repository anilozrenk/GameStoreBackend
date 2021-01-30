using GameStoreBackend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreBackend.Interfaces
{
    interface ISaleManager
    {
        void Buy(Game game,Player player);
        void Return(Game game, Player player);
    }
}
