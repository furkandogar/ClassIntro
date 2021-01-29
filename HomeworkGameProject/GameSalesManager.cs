using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkGameProject
{
    class GameSalesManager : IGameSalesService
    {
        public void ApplyCampaign(Gamer gamer, Campaign campaign)
        {
            if (gamer.BoughtFlag == false)
            {
                if(gamer.CampaignFlag == false)
                {
                    if (campaign.Availability == true)
                    {
                        Console.WriteLine("Enjoy " + (int)(100 * campaign.DiscountRate) + "% Off!");
                        gamer.CampaignFlag = true;
                    }
                    else
                    {
                        Console.WriteLine("The Campaign Is Unavailable.");
                    }
                }
                else
                {
                    Console.WriteLine("Only One Campaign Can Be Used At Once.");
                }
            }
            else
            {
                Console.WriteLine("You Have Already Bought The Game!");
            }
        }

        public void Sell(Gamer gamer)
        {
            if(gamer.BoughtFlag == false)
            {
                gamer.BoughtFlag = true;
                Console.WriteLine("Thank You For Supporting Us!");
            }
            else
            {
                Console.WriteLine("You Have Already Bought The Game!");
            }
        }
    }
}
