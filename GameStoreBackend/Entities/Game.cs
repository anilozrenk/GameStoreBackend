using GameStoreBackend.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreBackend.Entities
{
    class Game : BaseEntitiy
    {
       

        public string Genre { get; set; }
        public double BasePrice { get; set; }
        public double Price { get; set; } 
        

    }
}
