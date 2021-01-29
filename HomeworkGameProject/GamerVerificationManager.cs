using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkGameProject
{
    class GamerVerificationManager : IGamerVerificationService
    {
        public bool Verify(Gamer gamer)
        {
            if (gamer.IdentityNumber==12345678900 && gamer.FirstName=="ENGİN" && gamer.LastName=="DEMİROĞ" && gamer.BirthYear==1985)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
