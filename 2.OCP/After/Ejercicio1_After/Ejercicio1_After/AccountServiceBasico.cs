using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_After
{
    public class AccountServiceBasico : IAccountService
    {
        public Membership create(IPerson IPerson)
        {
          Membership newMembership =new Membership();
            newMembership.FirstName = IPerson.FirstName;
            newMembership.LastName = IPerson.LastName;
            newMembership.Email = $"{IPerson.FirstName}.{IPerson.LastName}@basico.com";
            newMembership.Id = Guid.NewGuid().ToString();
            newMembership.NameMembership = "Basico";
            newMembership.Price = 30;
            return newMembership;

        }
    }
}
