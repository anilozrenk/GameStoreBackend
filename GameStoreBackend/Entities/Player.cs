using System;
using System.Collections.Generic;
using System.Text;
using GameStoreBackend.Interfaces;


namespace GameStoreBackend.Entities
{
    class Player:BaseEntitiy
    {
        public DateTime DateOfBirth { get; set; }
        public string Surname { get; set; }
        public string NationaityId { get; set; }


    }
}
