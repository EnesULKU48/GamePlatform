using GamePlatform;
using System;

namespace gamePlatform
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new ValidationManager());
            gamerManager.Add(new Gamer {Id=1, BirthYear=2003, TcNo=123456, FirstName="Enes", LastName="ÜLKÜ" });
            //gamerManager.Delete(new Gamer { Id = 2, BirthYear = 2003, TcNo = 123456, FirstName = "Enes", LastName = "ÜLKÜ" });
            //gamerManager.Update(new Gamer { Id = 3, BirthYear = 2003, TcNo = 123456, FirstName = "Enes", LastName = "ÜLKÜ" });



            GameManager gameManager = new GameManager();
            gameManager.Buy(new Gamer { Id = 2, BirthYear = 2005, TcNo = 123456, FirstName = "Enes", LastName = "ÜLKÜ" });
            //gameManager.Delete(new Gamer { Id = 1, BirthYear = 2003, TcNo = 123456, FirstName = "Enes", LastName = "ÜLKÜ" });
            //gameManager.NewCampaign(new Gamer { Id = 1, BirthYear = 2003, TcNo = 123456, FirstName = "Enes", LastName = "ÜLKÜ" });
         //gameManager.CampaignDeletion(new Gamer { Id = 1, BirthYear = 2003, TcNo = 123456, FirstName = "Enes", LastName = "ÜLKÜ" });
         gameManager.CampaignUpdate(new Gamer { Id = 1, BirthYear = 2003, TcNo = 123456, FirstName = "Enes", LastName = "ÜLKÜ" });

        }
    }
}
