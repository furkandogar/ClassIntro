using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkGameProject
{
    interface IGamerService
    {
        void SignUp(Gamer gamer);
        void UpdateProfile(Gamer gamer);
        void DeleteProfile(Gamer gamer);
    }
}
