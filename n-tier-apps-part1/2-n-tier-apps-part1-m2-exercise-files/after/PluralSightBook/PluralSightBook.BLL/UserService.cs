﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PluralSightBook.DAL;

namespace PluralSightBook.BLL
{
    public class UserService
    {
        public bool IsEmailRegistered(string email)
        {
            var context = new aspnetdbEntities();
            return context.aspnet_Membership.Any(m => m.Email == email);
        }

        public aspnet_Membership GetUserByEmail(string email)
        {
            var context = new aspnetdbEntities();
            return context.aspnet_Membership.FirstOrDefault(m => m.Email == email);
        }
    }
}
