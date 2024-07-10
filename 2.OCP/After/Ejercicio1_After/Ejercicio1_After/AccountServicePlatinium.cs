using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_After
{
    public class AccountServicePlatinium : IAccountService
    {
        public Membership create(IPerson IPerson)
        {
            Membership newMembership = new Membership();
            newMembership.FirstName = IPerson.FirstName;
            newMembership.LastName = IPerson.LastName;
            newMembership.Email = $"{IPerson.FirstName}.{IPerson.LastName}@platinium.com";
            newMembership.Id = Guid.NewGuid().ToString();
            newMembership.NameMembership = "Platinium";
            newMembership.Price = 300;
            return newMembership;

        }

    }
}
