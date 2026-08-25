namespace Models;

public class CreditCard : ICreditCard
{
    public virtual string CreditCardNumber { get; set; }
    public virtual string ExpiryMonth { get; set; }
    public virtual string ExpiryYear { get; set; }

    public CreditCard (string creditCardNumber, string expiryMonth, string expiryYear)
    {
creditCardNumber = CreditCardNumber;
expiryMonth = ExpiryMonth;
expiryYear = ExpiryYear;
    }
}