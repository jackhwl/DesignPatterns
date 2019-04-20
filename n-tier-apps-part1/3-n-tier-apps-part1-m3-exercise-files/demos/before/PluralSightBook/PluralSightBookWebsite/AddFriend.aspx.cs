using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using PluralSightBook.BLL;
using PluralSightBookWebsite.Code;

namespace PluralSightBookWebsite
{
    public partial class AddFriend : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            string currentUserName = MyProfile.CurrentUser.Name;
            string currentUserEmail = Membership.GetUser().Email;
            Guid currentUserId = (Guid)Membership.GetUser().ProviderUserKey;
            string friendEmail = EmailTextBox.Text;
            var friendsService = new FriendsService();
            friendsService.AddFriend(currentUserId, currentUserEmail, currentUserName, friendEmail);

            Response.Redirect("~/Friends.aspx", true);
        }
    }
}