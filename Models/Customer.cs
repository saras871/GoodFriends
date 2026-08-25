using System.Security.AccessControl;

namespace Models;

public class Customer : ICustomer
{
    public virtual string FirstName { get; set; }
    public virtual string LastName { get; set; }
    public virtual ICreditCard CreditCard { get; set; }

    public Customer (string firstName, string lastName, ICreditCard creditCard)
    {
        firstName = FirstName;
        lastName = LastName;
        creditCard = CreditCard;
    }
}