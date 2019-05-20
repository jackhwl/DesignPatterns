using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointments
{
    class UserGroup: IUserGroup
    {
        private IList<IUser> members = new List<IUser>();

        public void AddMember(IUser user)
        {
            this.members.Add(user);
        }
        public void Accept(Func<IUserGroupVisitor> visitorFactory)
        {
            IUserVisitor visitor = visitorFactory();
            foreach(IUser user in this.members)
                user.Accept(()=> visitor);
        }
    }
}
