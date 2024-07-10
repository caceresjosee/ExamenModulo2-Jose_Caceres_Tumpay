
using Ejercicio1_After;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        List<IPerson> persons = new List<IPerson>()
        {
                new Gold{ FirstName = "Rodrigo", LastName="Morales"},
                new Basico{ FirstName = "Miguel", LastName="Sandoval"},
                new Platinium{ FirstName = "Robert", LastName="Martin"}
         };

        List<Membership> memberships = new List<Membership>();
        foreach (var person in persons)
        {
            memberships.Add(person.IAccountService.create(person));
        }
        foreach (Membership  x in memberships)
        {
            Console.WriteLine($"Bienvenido {x.FirstName} {x.LastName} - {x.Email} {Environment.NewLine}Membership ID:{ x.Id} {Environment.NewLine}MembershipType : {x.NameMembership} - Price {x.Price}");
            Console.WriteLine(new string('*', 50));
        
        }
        Console.ReadLine();
    }

}