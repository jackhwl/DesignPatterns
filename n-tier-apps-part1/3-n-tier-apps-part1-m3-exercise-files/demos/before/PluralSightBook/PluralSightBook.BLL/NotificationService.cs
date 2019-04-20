using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using PluralSightBook.DAL;

namespace PluralSightBook.BLL
{
    public class NotificationService
    {
        public void SendNotification(string currentUserEmail, string currentUserName, string friendEmail, aspnetdbEntities context)
        {
            string emailBody = "";

            var userService = new UserService();
            bool isFriendMember = userService.IsEmailRegistered(friendEmail);

            if (isFriendMember)
            {
                // do they already list the current user as one of their friends?
                var friendUserId = userService.GetUserByEmail(friendEmail).UserId;
                bool currentUserAlreadyFriend = context.Friends.Any(f => f.UserId == friendUserId && f.EmailAddress == currentUserEmail);
                if (currentUserAlreadyFriend)
                {
                    emailBody = String.Format(@"Good News!
Your friend {0} just added you as a friend!",
                                            currentUserEmail);
                }
                else
                {
                    emailBody = String.Format(@"{0} added you as a friend on PluralsightBook!  Click here to add them as your friend:
 http://localhost:4927/QuickAddFriend.aspx?email={1}",
                                                   currentUserName,
                                                   currentUserEmail);
                }
            }
            else
            {
                emailBody = String.Format(@"{0} added you as a friend on PluralsightBook!  Click here to register your own account and then add them as your friend:
http://localhost:4927/QuickAddFriend.aspx?email={1}",
                               currentUserName,
                               currentUserEmail);

            }
            // send email
            Debug.Print("Sending Email: " + emailBody);
        }

    }
}
