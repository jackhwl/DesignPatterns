﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using PluralSightBook.Core.Interfaces;
using PluralSightBook.Core.Model;

namespace PluralSightBook.Infrastructure.Data
{
    public class EfQueryUsersByEmail : IQueryUsersByEmail
    {
        public bool UserWithEmailExists(string email)
        {
            var context = new aspnetdbEntities();
            return context.aspnet_Membership.Any(m => m.Email == email);
        }

        public User GetUserByEmail(string email)
        {
            var context = new aspnetdbEntities();
            return context.aspnet_Membership
                .Where(m => m.Email == email)
                .Select(m => new User())
                .FirstOrDefault();
        }


        public bool IsUserWithEmailFriendOfUser(Guid userId, string emailAddressOfPotentialFriend)
        {
            var context = new aspnetdbEntities();
            return context.Friends
                .Any(f => f.UserId == userId && 
                    f.EmailAddress == emailAddressOfPotentialFriend);
        }
    }
}
