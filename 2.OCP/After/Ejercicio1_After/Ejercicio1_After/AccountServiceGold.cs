using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_After
{
    public class AccountServiceGold :IAccountService
    {
        public Membership create(IPerson IPerson)
        {
            Membership newMembership = new Membership();
            newMembership.FirstName = IPerson.FirstName;
            newMembership.LastName = IPerson.LastName;
            newMembership.Email = $"{IPerson.FirstName}.{IPerson.LastName}@gold.com";
            newMembership.Id = Guid.NewGuid().ToString();
            newMembership.NameMembership = "Gold";
            newMembership.Price = 80;
            return newMembership;
        }

    }
}
