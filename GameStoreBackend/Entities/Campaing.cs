using GameStoreBackend.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreBackend.Entities
{
    class Campaing:BaseEntitiy  
    {
        public double SaleAmount { get; set; }
        public DateTime Duration { get; set; }
    }
}
