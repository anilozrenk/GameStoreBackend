using GameStoreBackend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreBackend.Interfaces
{
    interface IPlayerCheckService
    {
        bool CheckIsPlayerReal(Player player);
    }
}
