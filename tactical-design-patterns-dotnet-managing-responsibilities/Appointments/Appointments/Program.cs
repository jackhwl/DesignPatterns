using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointments
{
    class Program
    {
        static void MassRegister(IEnumerable<IRegistrant> registrants)
        {
            foreach(IRegistrant registrant in registrants)
                registrant.Register();
        }
        static void ScramblePasswords(IEnumerable<IRegistrant> registrants)
        {
            foreach(IRegistrant registrant in registrants)
            {
                registrant.ChangePassword(Guid.NewGuid().ToString().Substring(0, 6));
            }
        }
        static void Main(string[] args)
        {
            DomainService domain = new DomainService(new UserFactory(new DataService()));
            IUser jill = domain.RegisterUser("Jill", "pwd");
            IUser joe = domain.RegisterUser("Joe", "pwd");
            IUser jack = domain.RegisterUser("Jack", "pwd");

            IUserGroup group = new UserGroup();
            group.AddMember(jill);
            group.AddMember(joe);
            group.AddMember(jack);

            DataService dataSvc = new DataService();

            IEnumerable<IRegistrant> registrants = new IRegistrant[]
            {
                new PersistableUser(jill, dataSvc, "pwd"),
                new PersistableUser(jack, dataSvc, "pwd"),
                new PersistableUser(joe, dataSvc, "pwd"),
                new RegistrantGroup(group, "friends", "secret")
            };

            MassRegister(registrants);
            ScramblePasswords(registrants);

            //IRegistrantGroup regGroup = new RegistrantGroup(group, "friends", "secret");
            //regGroup.Register();

            //IUser user = domain.RegisterUser("zoranh", "magicword");
            //Console.WriteLine("{0}\n", user);

            //IAppointment appointment = user.MakeAppointment(DateTime.Now.Date.AddHours(40));
            //Console.WriteLine("{0}\n", appointment);

            //user = domain.ChangePassword("zoranh", "magicword", "somethingmorecomplex");
            //Console.WriteLine("{0}\n", user);

            Console.ReadLine();
        }
    }
}
