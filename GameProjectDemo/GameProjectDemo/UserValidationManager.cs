﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.BirthYear==1985 && gamer.FirstName=="Bilge"
                && gamer.LastName=="Yasar"&& gamer.IdentityNumber==12345)
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
