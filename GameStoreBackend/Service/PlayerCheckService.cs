using GameStoreBackend.Entities;
using GameStoreBackend.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using GameStoreBackend.Service;
using ServiceReference1;

namespace GameStoreBackend.Service
{
    class PlayerCheckService : IPlayerCheckService
    {
        public bool CheckIsPlayerReal(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(player.NationaityId), player.Name, player.Surname, player.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }

        
    }
}
