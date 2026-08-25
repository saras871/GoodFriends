namespace Models;

public interface ICreditCard
{
    public string CreditCardNumber {get; set;}
    public string ExpiryMonth {get; set;}
    public string ExpiryYear {get; set;}
}

public interface ICustomer
{
    public string FirstName {get; set;}
    public string LastName {get; set;}   
    public ICreditCard CreditCard {get; set;}
}