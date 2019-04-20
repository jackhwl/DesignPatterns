using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PluralSightBook.Infrastructure.Data;

namespace PluralSightBook.IntegrationTests
{
    [TestClass]
    public class EfFriendRepository_CreateShould
    {
        [TestMethod]
        public void AddRecord()
        { 

            
            var context = new aspnetdbEntities();
            var testUser = context.aspnet_Membership.First();

            var friendRepository = new EfFriendRepository();
            var testEmail = Guid.NewGuid().ToString();

            friendRepository.Create(testUser.UserId, testEmail);

            bool friendExists = context.Friends.Any(f => f.UserId == testUser.UserId && f.EmailAddress == testEmail);
            Assert.IsTrue(friendExists);

            context.DeleteObject(context.Friends.FirstOrDefault(f => f.UserId == testUser.UserId && f.EmailAddress == testEmail));
            context.SaveChanges();
        }
    }
}
