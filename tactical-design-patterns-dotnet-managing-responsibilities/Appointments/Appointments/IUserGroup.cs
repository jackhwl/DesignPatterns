using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointments
{
    interface IUserGroup
    {
        void AddMember(IUser user);
        void Accept(Func<IUserGroupVisitor> visitorFactory);
    }
}
