using System;

namespace HomeworkGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer
            {
                Id = 1,
                Username = "engin85",
                Password = "741852",
                IdentityNumber = 12345678900,
                FirstName = "ENGİN",
                LastName = "DEMİROĞ",
                BirthYear = 1985,
                ActivityInTheGame = 0.74,
                CampaignFlag = false,
                BoughtFlag = false
            };
            GamerManager gamerManager = new GamerManager(new GamerVerificationManager());
            gamerManager.SignUp(gamer1);
            gamerManager.UpdateProfile(gamer1);

            GameSalesManager gameSalesManager = new GameSalesManager();
            Console.WriteLine(gamer1.BoughtFlag);
            gameSalesManager.Sell(gamer1);
            gameSalesManager.Sell(gamer1);
            Console.WriteLine(gamer1.BoughtFlag);

            Campaign campaign1 = new Campaign
            {
                Id = 1,
                Availability = true,
                Name = "The First Campaign",
                Details = "Campaign #1",
                SuccessRate = 0.56,
                DiscountRate = 0.30
            };
            Campaign campaign2 = new Campaign
            {
                Id = 2,
                Availability = false,
                Name = "The Second Campaign",
                Details = "Campaign #1",
                SuccessRate = 0.19,
                DiscountRate = 0.05
            };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Delete(campaign2);
            //campaignManager.Delete(campaign1);
            campaignManager.Update(campaign2);
            campaignManager.Add(campaign2);
            Console.WriteLine(campaign1.DiscountRate);
            campaignManager.Update(campaign1);
            Console.WriteLine(campaign1.DiscountRate);
            Console.WriteLine(campaign2.DiscountRate);
            campaignManager.Update(campaign2);
            Console.WriteLine(campaign2.DiscountRate);
            campaignManager.Delete(campaign1);

            Console.WriteLine(campaign1.DiscountRate);
            Console.WriteLine(campaign2.DiscountRate);
            gameSalesManager.ApplyCampaign(gamer1, campaign1);
            gamer1.BoughtFlag = false;
            gameSalesManager.ApplyCampaign(gamer1, campaign1);
            gameSalesManager.ApplyCampaign(gamer1, campaign2);
            Console.WriteLine(gamer1.CampaignFlag);
            gameSalesManager.ApplyCampaign(gamer1, campaign2);
            gameSalesManager.Sell(gamer1);
            Console.WriteLine(gamer1.BoughtFlag);
            gamerManager.DeleteProfile(gamer1);
        }
    }
}
