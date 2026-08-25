namespace Models;

public interface ICreditCard
{
    public Guid CreditCardId {get; set;}
    public string CreditCardNumber {get; set;}
    public string ExpiryMonth {get; set;}
    public string ExpiryYear {get; set;}
}

public interface ICustomer
{
    public Guid CustomerId {get; set;}
    public string FirstName {get; set;}
    public string LastName {get; set;}   
    public ICreditCard CreditCard {get; set;}
}