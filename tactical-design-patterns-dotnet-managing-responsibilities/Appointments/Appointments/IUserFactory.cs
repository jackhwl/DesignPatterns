using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointments
{
    interface IUserFactory
    {
        IUser CreateUser(string name);
        IRegistrantUser CreateRegistrantUser(IUser user, string password);
    }
}
