using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PluralSightBook.Core.Interfaces;

namespace PluralSightBook.Core.Services
{
    public class NotificationService : INotificationService
    {
        private readonly IQueryUsersByEmail _queryUsersByEmail;
        private readonly ISendEmail _emailSender;
        public NotificationService(IQueryUsersByEmail queryUsersByEmail,
            ISendEmail emailSender)
        {
            _queryUsersByEmail = queryUsersByEmail;
            _emailSender = emailSender;
        }

        public void SendNotification(string currentUserEmail, string currentUserName, string friendEmail)
        {
            string emailBody = "";

            bool isFriendMember = _queryUsersByEmail.UserWithEmailExists(friendEmail);

            if (isFriendMember)
            {
                // do they already list the current user as one of their friends?
                var friendUserId = _queryUsersByEmail.GetUserByEmail(friendEmail).UserId;
                bool currentUserAlreadyFriend = _queryUsersByEmail.IsUserWithEmailFriendOfUser(
                    friendUserId, currentUserEmail);

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
            _emailSender.SendEmail(emailBody);
        }
    }
}
