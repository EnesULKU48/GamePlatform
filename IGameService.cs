using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatform
{
    interface IGameService
    {

        void Buy(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
