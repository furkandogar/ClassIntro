using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkGameProject
{
    interface IGameSalesService
    {
        void ApplyCampaign(Gamer gamer, Campaign campaign);
        void Sell(Gamer gamer);
    }
}
