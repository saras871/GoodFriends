using Seido.Utilities.SeedGenerator;
using System.Security.AccessControl;

namespace Models;

public class Customer : ICustomer, ISeed<Customer>
{
    public Guid CustomerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public ICreditCard CreditCard { get; set; }

    public bool Seeded { get; set; } = false;
    public virtual Customer Seed(SeedGenerator seeder)
    {
        Seeded = true;
        CustomerId = Guid.NewGuid();
        FirstName = seeder.FirstName;
        LastName = seeder.LastName; ;
        return this;
    }
}