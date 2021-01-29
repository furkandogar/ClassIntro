using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkGameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            if(campaign.Availability == false)
            {
                campaign.Availability = true;
                Console.WriteLine("Campaign Is Available Now On.");
            }
            else
            {
                Console.WriteLine("Campaign Is Already Available.");
            }
        }

        public void Delete(Campaign campaign)
        {
            if(campaign.Availability == true)
            {
                campaign.Availability = false;
                Console.WriteLine("Campaign Is Unavailable Now On.");
            }
            else
            {
                Console.WriteLine("Campaign Is Already Unavailable.");
            }
        }

        public void Update(Campaign campaign)
        {
            if(campaign.Availability == true)
            {
                if (0.00 <= campaign.SuccessRate && campaign.SuccessRate < 0.25)
                {
                    campaign.DiscountRate += 0.10;
                }
                else if (0.25 <= campaign.SuccessRate && campaign.SuccessRate < 0.50)
                {
                    campaign.DiscountRate += 0.05;
                }
                else if (0.50 <= campaign.SuccessRate && campaign.SuccessRate < 0.75)
                {
                    campaign.DiscountRate -= 0.05;
                }
                else
                {
                    campaign.DiscountRate -= 0.10;
                }
                Console.WriteLine("The Campaign Is Updated.");
            }
            else
            {
                Console.WriteLine("Unavailable Campaigns Cannot Be Updated.");
            }
        }
    }
}
