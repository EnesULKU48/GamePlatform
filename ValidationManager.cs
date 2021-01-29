using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatform
{
    class ValidationManager : IUserValidationService
    {
        public bool Validation(Gamer gamer)
        {
            if (gamer.Id == 1 && gamer.BirthYear == 2003 && gamer.FirstName == "Enes" && gamer.LastName == "ÜLKÜ" && 
                gamer.TcNo == 123456)
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
