using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign successfully added : " +  campaign.CampaignName );
        }

        public void BuyWithCampaign(Game game, Campaign campaign, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " purchased the " + game.GameName + " game with % "+ campaign.DiscountPercent + " discount using the " + campaign.CampaignName + " campaign." );
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign succesfully deleted : " + campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign succesfully updated : " + campaign.CampaignName);
        }
    }
}
