using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatform
{
    class GameManager : IGameService, IGameCampaignService
    {

        public void Buy(Gamer gamer)
        {
            Console.WriteLine("Oyun satın alındı!");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyun kütüphaneden çıkarıldı!");
        }


        public void NewCampaign(Gamer gamer)
        {
            Console.WriteLine("İlk defa sizi burda gördüğümüz için ... oyun bedava");
        }

        public void CampaignDeletion(Gamer gamer)
        {
            Console.WriteLine("Oyunun kampanya süresi dolmuştur ");
        }

        public void CampaignUpdate(Gamer gamer)
        {
            Console.WriteLine("Oyunu indirim süresi 2 hafta uzatıldı");
        }

    }
}
