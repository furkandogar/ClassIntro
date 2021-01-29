using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkGameProject
{
    class GamerManager : IGamerService
    {
        //Microservice
        IGamerVerificationService _gamerVerificationService;
        public GamerManager(IGamerVerificationService gamerVerificationService)
        {
            _gamerVerificationService = gamerVerificationService;
        }

        public void DeleteProfile(Gamer gamer)
        {
            Console.WriteLine("Your Profile Has Been Deleted.");
        }

        public void SignUp(Gamer gamer)
        {
            if (_gamerVerificationService.Verify(gamer))
            {
                Console.WriteLine("Welcome " + gamer.Username);
            }
            else
            {
                Console.WriteLine("Your Profile Could Not Be Verified.");
            }
        }

        public void UpdateProfile(Gamer gamer)
        {
            Console.WriteLine("Your Profile Has Been Updated.");
        }
    }
}
