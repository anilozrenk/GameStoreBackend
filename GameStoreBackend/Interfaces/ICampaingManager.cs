using GameStoreBackend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreBackend.Interfaces
{
    interface ICampaingManager
    {
        void Apply(Campaing campaing,Game game);
        void Cancel(Campaing campaing,Game game);
    }
}
