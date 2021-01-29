using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatform
{
    interface IGameCampaignService
    {
        void NewCampaign(Gamer gamer);
        void CampaignDeletion(Gamer gamer);
        void CampaignUpdate(Gamer gamer);
    }
}
