using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointments
{
    class UserFactory : IUserFactory
    {
        private readonly DataService dataService;
        public UserFactory(DataService dataService)
        {
            this.dataService = dataService;
        }
        public IUser CreateUser(string name)
        {
            return new User(name);
        }
        public IRegistrantUser CreateRegistrantUser(IUser user, string password)
        {
            return new PersistableUser(user, this.dataService, password);
        }

    }
}
