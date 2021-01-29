using GameProject;
using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.FirstName = "Metin";
            gamer1.LastName = "Onur";
            gamer1.IdentityNumber = 123456;
            gamer1.BirthYear = 2002;

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer1);
            Console.WriteLine("----------------");

            Game game1 = new Game();
            game1.Id = 1;
            game1.GameName = "COD";
            game1.GamePrice = 100;


            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.Add(game1);
            Console.WriteLine("----------------");


            GameOwnerManager gameOwnerManager = new GameOwnerManager();
            gameOwnerManager.OwnGame(gamer1,game1);
            Console.WriteLine("----------------");

            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.CampaignName = "Aldın aldın";
            campaign1.DiscountPercent = "10";

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            Console.WriteLine("----------------");

            campaignManager.BuyWithCampaign(game1, campaign1, gamer1);
            Console.WriteLine("----------------");

        }
    }
}
