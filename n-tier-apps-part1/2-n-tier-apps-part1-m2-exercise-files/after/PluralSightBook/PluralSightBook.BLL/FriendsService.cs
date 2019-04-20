using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using PluralSightBook.DAL;

namespace PluralSightBook.BLL
{
    public class FriendsService
    {
        public void AddFriend(Guid currentUserId,
            string currentUserEmail, 
            string currentUserName, 
            string friendEmail)
        {
            var context = new aspnetdbEntities();
            var newFriend = context.Friends.CreateObject();
            newFriend.UserId = currentUserId;
            newFriend.EmailAddress = friendEmail;
            context.Friends.AddObject(newFriend);
            context.SaveChanges();

            var notificationService = new NotificationService();
            notificationService.SendNotification(currentUserEmail, currentUserName, friendEmail, context);
        }
    }
}
