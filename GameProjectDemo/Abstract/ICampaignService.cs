﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
        void BuyWithCampaign(Game game, Campaign campaign, Gamer gamer);
    }
}
